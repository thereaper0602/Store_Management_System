using DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

using DAL.Repository;
using DTO.DTO;

//Đổi lại tên namspace thành BLL.Services cho đúng với tên folder bên ngoài
namespace BLL.Services
{
    //Thêm public thay cho internal
    public class PromotionServiceBLL
    {
        private readonly PromotionRepositoryDAL voucher = new PromotionRepositoryDAL();

        // Lấy danh sách tất cả khuyến mãi
        public List<PromotionDTO> GetAllPromotions()
        {
            return voucher.GetAllPromotions();
        }

        // Thêm khuyến mãi mới
        public bool AddPromotion(PromotionDTO promotionDto)
        {
            ValidatePromotion(promotionDto);
            return voucher.AddPromotion(promotionDto);
        }

        // Cập nhật khuyến mãi
        public bool UpdatePromotion(PromotionDTO promotionDto)
        {
            ValidatePromotion(promotionDto);
            return voucher.UpdatePromotion(promotionDto);
        }

        //Kiểm tra tính hợp lệ của khuyến mãi
        private void ValidatePromotion(PromotionDTO dto)
        {
            if (string.IsNullOrWhiteSpace(dto.promotionName))
                throw new ArgumentException("Promotion name cannot be empty.");

            if (dto.discountRate < 0 || dto.discountRate >= 100)
                throw new ArgumentException("Discount rate must be between 0 and less than 100.");

            if (dto.startDate > dto.endDate)
                throw new ArgumentException("Start date must be before the end date.");
        }



        //Xóa khuyến mãi
        //Xóa 1 khuyến mãi dựa trên ID
        public bool DeletePromotion(int promotionID)
        {
            return voucher.DeletePromotion(promotionID);
        }

        // Xóa nhiều khuyến mãi dựa trên danh sách ID
        public bool DeletePromotions(List<int> promotionID)
        {
            return voucher.DeletePromotions(promotionID);
        }

        // Tìm kiếm khuyến mãi dựa trên từ khóa
        public List<PromotionDTO> SearchPromotions(string keyword)
        {
            return voucher.SearchPromotions(keyword);
        }
    }
}
