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
    public class PromotionServiceBLL : IPromotionServiceBLL
    {
        private readonly PromotionRepositoryDAL voucher = new PromotionRepositoryDAL();


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
        public List<PromotionDTO> GetAllPromotions()
        {
            return voucher.GetAllPromotions()
                .Select(p => new PromotionDTO
                {
                    promotionID = p.PromotionID,
                    promotionName = p.PromotionName,
                    discountRate = p.DiscountRate,
                    startDate = p.StartDate,
                    endDate = p.EndDate,
                    description = p.Description
                })
            .ToList();

        }

        // Thêm khuyến mãi mới
        public bool AddPromotion(PromotionDTO promotion)
        {
            try
            {
                ValidatePromotion(promotion);
                var newPromotion = new Promotion
                {
                    PromotionID = promotion.promotionID,
                    PromotionName = promotion.promotionName,
                    DiscountRate = promotion.discountRate,
                    StartDate = promotion.startDate,
                    EndDate = promotion.endDate,
                    Description = promotion.description
                };

                voucher.AddPromotion(newPromotion);
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Cập nhật khuyến mãi
        public bool UpdatePromotion(PromotionDTO promotionDto)
        {
            try
            {
                ValidatePromotion(promotionDto);
                var promotion = new Promotion
                {
                    PromotionID = promotionDto.promotionID,
                    PromotionName = promotionDto.promotionName,
                    DiscountRate = promotionDto.discountRate,
                    StartDate = promotionDto.startDate,
                    EndDate = promotionDto.endDate,
                    Description = promotionDto.description
                };

                return voucher.UpdatePromotion(promotion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Xóa 1 khuyến mãi
        public bool DeletePromotion(int promotionID)
        {
            try
            {
                return voucher.DeletePromotion(promotionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Xóa nhiều khuyến mãi
        public bool DeletePromotions(List<int> promotionIDs)
        {
            try
            {
                return voucher.DeletePromotions(promotionIDs);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Tìm kiếm khuyến mãi theo keyword
        public List<PromotionDTO> SearchPromotions(string keyword)
        {
            try
            {
                var promotions = voucher.SearchPromotions(keyword);
                return promotions.Select(p => new PromotionDTO
                {
                    promotionID = p.PromotionID,
                    promotionName = p.PromotionName,
                    discountRate = p.DiscountRate,
                    startDate = p.StartDate,
                    endDate = p.EndDate,
                    description = p.Description
                }).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
