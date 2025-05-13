using DAL.Model;
using DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class ProductPromotionDAL : IProductPromotionDAL
    {
        private readonly StoreContext _context = new StoreContext();
        public List<ProductPromotion> GetProductPromotionsByPromotionId(int promotionId)
        {
            return _context.ProductPromotions.ToList();
        }
        public ProductPromotion AddProductPromotion(ProductPromotion productPromotion)
        {
            _context.ProductPromotions.Add(productPromotion);
            _context.SaveChanges();
            return productPromotion;
        }
    }
}
