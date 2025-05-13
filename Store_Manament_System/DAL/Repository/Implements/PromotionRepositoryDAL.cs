using DAL.Model;
using DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class PromotionRepositoryDAL : IPromotionRepositoryDAL
    {
        private readonly StoreContext _context = new StoreContext();
        // Lấy danh sách tất cả khuyến mãi
        public List<Promotion> GetAllPromotions()
        {
            return _context.Promotions.ToList();
        }

        // Thêm khuyến mãi mới
        public Promotion AddPromotion(Promotion promotion)
        {
            _context.Promotions.Add(promotion);
            _context.SaveChanges();
            return promotion;

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
        public bool UpdatePromotion(Promotion promotion)
        {
            try
            {
                var existingPromotion = _context.Promotions
                    .FirstOrDefault(p => p.PromotionID == promotion.PromotionID);
                if (existingPromotion == null)
                {
                    var promotion = context.Promotions
                        .FirstOrDefault(p => p.PromotionID == promotionDto.promotionID);
                    if (promotion == null)
                    {
                    return false;
                }

                existingPromotion.PromotionName = promotion.PromotionName;
                existingPromotion.DiscountRate = promotion.DiscountRate;
                existingPromotion.StartDate = promotion.StartDate;
                existingPromotion.EndDate = promotion.EndDate;
                existingPromotion.Description = promotion.Description;

                _context.SaveChanges();
                return true;
            }
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
                var promotion = _context.Promotions
                    .FirstOrDefault(p => p.PromotionID == promotionID);
                if (promotion == null)
                {
                    return false;
                }

                _context.Promotions.Remove(promotion);
                _context.SaveChanges();
                return true;
            }
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
                var promotions = _context.Promotions
                    .Where(p => promotionIDs.Contains(p.PromotionID))
                    .ToList();
                if (promotions == null || promotions.Count == 0)
                {
                    return false;
                }

                _context.Promotions.RemoveRange(promotions);
                _context.SaveChanges();
                return true;
            }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Tìm kiếm khuyến mãi theo keyword (promotionID hoặc promotionName)
        public List<Promotion> SearchPromotions(string keyword)
        {
            try
            {
                var promotions = _context.Promotions.AsQueryable();

                if (!string.IsNullOrEmpty(keyword))
                {
                    keyword = keyword.ToLower();
                    promotions = promotions.Where(p =>
                        p.PromotionID.ToString().Contains(keyword) ||
                        (p.PromotionName != null && p.PromotionName.ToLower().Contains(keyword)));
                }

                return promotions.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
