using DAL.Model;
using System.Collections.Generic;

namespace DAL.Repository
{
    public interface IImageRepositoryDAL
    {
        Image AddImage(Image image);
        bool DeleteImage(int id);
        List<Image> GetAllImages();
        Image GetImageById(int id);
        bool UpdateImage(Image image);
    }
}