using DAL.Model;
using System.Collections.Generic;

namespace DAL.Repository
{
    public interface IPromotionRepositoryDAL
    {
        Promotion AddPromotion(Promotion promotion);
        bool DeletePromotion(int promotionID);
        bool DeletePromotions(List<int> promotionIDs);
        List<Promotion> GetAllPromotions();
        List<Promotion> SearchPromotions(string keyword);
        bool UpdatePromotion(Promotion promotion);
    }
}