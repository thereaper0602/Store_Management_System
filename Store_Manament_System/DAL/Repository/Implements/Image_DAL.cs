using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class Image_DAL : IImage_DAL
    {
        private readonly StoreContext _context;

        public Image_DAL()
        {
            _context = new StoreContext();
        }

        public int AddImage(string imagePath, string imageName)
        {
            try
            {
                if (string.IsNullOrEmpty(imagePath) || string.IsNullOrEmpty(imageName))
                {
                    throw new ArgumentException("Đường dẫn hoặc tên ảnh không được để trống.");
                }

                var newImage = new Image
                {
                    ImagePath = imagePath,
                    ImageName = imageName,
                    UploadDate = DateTime.Now
                };

                _context.Images.Add(newImage);
                _context.SaveChanges();

                return newImage.ImageID;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lưu ảnh vào cơ sở dữ liệu: {ex.Message}", ex);
            }
        }
    }
}
