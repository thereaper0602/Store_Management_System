using DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Repository;
using DAL.Model;


namespace BLL.Services
{
    public class ProductPromotionBLL : IProductPromotionBLL
    {
        private readonly ProductPromotionDAL _productPromotionDAL = new ProductPromotionDAL();

        public List<ProductPromotionDTO> GetProductPromotionsByPromotionId(int promotionId)
        {
            return _productPromotionDAL.GetProductPromotionsByPromotionId(promotionId)
                .Where(pp => pp.PromotionID == promotionId)
                .Select(pp => new ProductPromotionDTO
                {
                    productID = pp.ProductID,
                    promotionID = pp.PromotionID
                }).ToList();
        }

        public bool AddProductPromotion(ProductPromotionDTO deals)
        {
            var productPromotion = new ProductPromotion
            {
                ProductPromotionID = deals.productPromotionID,
                ProductID = deals.productID,
                PromotionID = deals.promotionID

            };
            _productPromotionDAL.AddProductPromotion(productPromotion);

            return true;
        }
    }
}
