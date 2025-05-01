using DAL.Model;
using DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class PromotionRepositoryDAL
    {
        private readonly StoreContext voucher = new StoreContext();

        // Lấy danh sách tất cả khuyến mãi
        public List<PromotionDTO> GetAllPromotions()
        {
            return voucher.Promotions
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
        public bool AddPromotion(PromotionDTO promotionDto)
        {
            try
            {
                using (var context = new StoreContext())
                {
                    var promotion = new Promotion
                    {
                        PromotionName = promotionDto.promotionName,
                        DiscountRate = promotionDto.discountRate,
                        StartDate = promotionDto.startDate,
                        EndDate = promotionDto.endDate,
                        Description = promotionDto.description
                    };

                    context.Promotions.Add(promotion);
                    context.SaveChanges();
                    return true;
                }
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
                using (var context = new StoreContext())
                {
                    var promotion = context.Promotions
                        .FirstOrDefault(p => p.PromotionID == promotionDto.promotionID);
                    if (promotion == null)
                    {
                        return false;
                    }

                    promotion.PromotionName = promotionDto.promotionName;
                    promotion.DiscountRate = promotionDto.discountRate;
                    promotion.StartDate = promotionDto.startDate;
                    promotion.EndDate = promotionDto.endDate;
                    promotion.Description = promotionDto.description;

                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Xóa khuyến mãi

        //Xóa 1 khuyến mãi
        public bool DeletePromotion(int promotionID)
        {
            try
            {
                using (var context = new StoreContext())
                {
                    var voucher = context.Promotions.FirstOrDefault(v => v.PromotionID == promotionID);
                    if (voucher == null)
                    {
                        return false; // Không tìm thấy nhân viên
                    }

                    context.Promotions.Remove(voucher);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Phương thức xóa nhiều nhân viên dựa trên danh sách UserID
        public bool DeletePromotions(List<int> promotionID)
        {
            try
            {
                using (var context = new StoreContext())
                {
                    var vouchers = context.Promotions.Where(v => promotionID.Contains(v.PromotionID)).ToList();
                    if (vouchers == null || vouchers.Count == 0)
                    {
                        return false; // Không tìm thấy nhân viên nào
                    }

                    context.Promotions.RemoveRange(vouchers);
                    context.SaveChanges();
                    return true;
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Tìm kiếm khuyến mãi dựa trên từ Id và tên khuyến mãi
        public List<PromotionDTO> SearchPromotions(string keyword)
        {
            try
            {
                // Nếu từ khóa trống, trả về toàn bộ danh sách
                if (string.IsNullOrEmpty(keyword))
                {
                    return GetAllPromotions();
                }

                // Chuyển từ khóa thành chữ thường để tìm kiếm không phân biệt hoa thường
                keyword = keyword.ToLower();

                var allPromotions = GetAllPromotions();

                // Chỉ tìm kiếm theo promotionID và promotionName
                return allPromotions
                    .Where(p =>
                        p.promotionID.ToString().Contains(keyword) ||
                        (p.promotionName != null && p.promotionName.ToLower().Contains(keyword))
                    )
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    } 
}
