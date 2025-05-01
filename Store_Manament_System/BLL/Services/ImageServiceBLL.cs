using DAL.Repository;
using DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ImageServiceBLL
    {
        private readonly ImageRepositoryDAL _imageRepository = new ImageRepositoryDAL();

        public List<ImageDTO> GetAllImages()
        {
            return _imageRepository.GetAllImages();
        }

        public ImageDTO GetImageById(int id)
        {
            return _imageRepository.GetImageById(id);
        }

        public bool AddImage(ImageDTO imageDTO)
        {
            return _imageRepository.AddImage(imageDTO);
        }

        public bool UpdateImage(ImageDTO imageDTO)
        {
            return _imageRepository.UpdateImage(imageDTO);
        }

        public bool DeleteImage(int id)
        {
            return _imageRepository.DeleteImage(id);
        }
    }
}
