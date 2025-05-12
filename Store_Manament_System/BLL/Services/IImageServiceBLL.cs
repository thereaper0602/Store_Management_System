using DTO.DTO;
using System.Collections.Generic;

namespace BLL.Services
{
    public interface IImageServiceBLL
    {
        ImageDTO AddImage(ImageDTO imageDTO);
        bool DeleteImage(int id);
        List<ImageDTO> GetAllImages();
        ImageDTO GetImageById(int id);
        bool UpdateImage(ImageDTO imageDTO);
    }
}