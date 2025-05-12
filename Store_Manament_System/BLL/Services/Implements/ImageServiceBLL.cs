using DAL.Model;
using DAL.Repository;
using DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ImageServiceBLL : IImageServiceBLL
    {
        private readonly IImageRepositoryDAL _imageRepository = new ImageRepositoryDAL();

        public List<ImageDTO> GetAllImages()
        {
            return _imageRepository.GetAllImages().Select(i => new ImageDTO
            {
                imageID = i.ImageID,
                imagePath = i.ImagePath,
                imageName = i.ImageName
            }).ToList();
        }

        public ImageDTO GetImageById(int id)
        {
            var image = _imageRepository.GetImageById(id);
            if (image == null)
            {
                return null;
            }
            return new ImageDTO
            {
                imageID = image.ImageID,
                imagePath = image.ImagePath,
                imageName = image.ImageName
            };
        }

        public ImageDTO AddImage(ImageDTO imageDTO)
        {
            var image = new Image
            {
                ImageName = imageDTO.imageName,
                ImagePath = imageDTO.imagePath
            };
            var savedImage = _imageRepository.AddImage(image);
            return new ImageDTO
            {
                imageID = savedImage.ImageID,
                imageName = savedImage.ImageName,
                imagePath = savedImage.ImagePath
            };
        }

        public bool UpdateImage(ImageDTO imageDTO)
        {
            var image = new Image
            {
                ImageID = imageDTO.imageID,
                ImageName = imageDTO.imageName,
                ImagePath = imageDTO.imagePath
            };
            return _imageRepository.UpdateImage(image);
        }

        public bool DeleteImage(int id)
        {
            return _imageRepository.DeleteImage(id);
        }
    }
}
