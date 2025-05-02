using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;
using DTO.DTO;
using DAL.Repository;
namespace BLL.Services
{     //{
    public class ImageBLL
    {
        private readonly Image_DAL _imageDAL;

        public ImageBLL()
        {
            _imageDAL = new Image_DAL();
        }

        // Nhận DTO từ UI, gọi DAL để lưu ảnh
        public int AddImage(ImageDTO image)
        {
            return _imageDAL.AddImage(image.imagePath, image.imageName);
        }
    }
}




