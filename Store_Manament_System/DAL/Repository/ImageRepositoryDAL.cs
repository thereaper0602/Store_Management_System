using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;
using DTO.DTO;

namespace DAL.Repository
{
    public class ImageRepositoryDAL
    {
        private readonly StoreContext _context = new StoreContext();
        public List<ImageDTO> GetAllImages()
        {
            return _context.Images
                .Select(i => new ImageDTO
                {
                    imageID = i.ImageID,
                    imagePath = i.ImagePath,
                    imageName = i.ImageName
                }).ToList();
        }

        public ImageDTO GetImageById(int id)
        {
            var image = _context.Images.FirstOrDefault(i => i.ImageID == id);
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

        public bool AddImage(ImageDTO imageDTO)
        {
            try
            {
                var image = new Image
                {
                    ImageName = imageDTO.imageName,
                    ImagePath = imageDTO.imagePath,
                    UploadDate = DateTime.Now
                };
                _context.Images.Add(image);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log it)
                return false;
            }
        }

        public bool UpdateImage(ImageDTO imageDTO)
        {
            try
            {
                var image = _context.Images.FirstOrDefault(i => i.ImageID == imageDTO.imageID);
                if (image == null)
                {
                    return false;
                }
                image.ImageName = imageDTO.imageName;
                image.ImagePath = imageDTO.imagePath;
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log it)
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool DeleteImage(int id)
        {
            try
            {
                var image = _context.Images.FirstOrDefault(i => i.ImageID == id);
                if (image == null)
                {
                    return false;
                }
                _context.Images.Remove(image);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log it)
                return false;
            }
        }

    }
}
