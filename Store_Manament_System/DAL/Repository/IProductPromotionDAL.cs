using DAL.Model;
using System.Collections.Generic;

namespace DAL.Repository
{
    public interface IProductPromotionDAL
    {
        ProductPromotion AddProductPromotion(ProductPromotion productPromotion);
        List<ProductPromotion> GetProductPromotionsByPromotionId(int promotionId);
    }
}