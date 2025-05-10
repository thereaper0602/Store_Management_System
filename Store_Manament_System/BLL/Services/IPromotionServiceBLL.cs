using DTO.DTO;
using System.Collections.Generic;

namespace BLL.Services
{
    public interface IPromotionServiceBLL
    {
        bool AddPromotion(PromotionDTO promotion);
        bool DeletePromotion(int promotionID);
        bool DeletePromotions(List<int> promotionIDs);
        List<PromotionDTO> GetAllPromotions();
        List<PromotionDTO> SearchPromotions(string keyword);
        bool UpdatePromotion(PromotionDTO promotionDto);
    }
}