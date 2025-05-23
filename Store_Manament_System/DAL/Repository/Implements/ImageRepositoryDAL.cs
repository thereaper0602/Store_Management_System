﻿using DAL.Model;
using DTO.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class ImageRepositoryDAL : IImageRepositoryDAL
    {
        private readonly StoreContext _context = new StoreContext();
        public List<Image> GetAllImages()
        {
            return _context.Images.ToList();
        }

        public Image GetImageById(int id)
        {
            return _context.Images.Find(id);
        }

        public Image AddImage(Image image)
        {
            try
            {
                _context.Images.Add(image);
                _context.SaveChanges();
                return image;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public bool UpdateImage(Image image)
        {
            try
            {
                var existing = _context.Images.Find(image.ImageID);
                if (existing == null)
                {
                    return false;
                }
                existing.ImageName = image.ImageName;
                existing.ImagePath = image.ImagePath;
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
                Console.WriteLine(ex.Message);
                return false;
            }
        }

    }
}
