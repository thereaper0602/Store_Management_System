using DTO.DTO;
using System.Collections.Generic;

namespace BLL.Services
{
    public interface IProductPromotionBLL
    {
        bool AddProductPromotion(ProductPromotionDTO deals);
        List<ProductPromotionDTO> GetProductPromotionsByPromotionId(int promotionId);
    }
}