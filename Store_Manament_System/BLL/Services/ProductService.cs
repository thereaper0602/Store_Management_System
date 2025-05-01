using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DTO.DTO;
using DAL.Repository;

namespace BLL.Services
{
    public class ProductService
    {
        private readonly ProductRepositoryDAL productRepositoryDAL = new ProductRepositoryDAL();
        public List<ProductDTO> GetAllProducts(String kw)
        {
            if(kw == null)
            {
                kw = "";
            }
            return productRepositoryDAL.GetAllProducts(kw)
                .Where(p => p.ProductName.Contains(kw) || p.Description.Contains(kw))
                .Select(p => new ProductDTO
                {
                    id = p.ProductID,
                    name = p.ProductName,
                    categoryID = p.CategoryID ?? 1,
                    stockQuantity = p.StockQuantity,
                    price = p.Price,
                    description = p.Description,
                    expiryDate = p.ExpiryDate ?? DateTime.MinValue,
                    imageID = p.ImageID ?? 1,
                    barcode = p.Barcode
                })
                .ToList();
        }

        public ProductDTO GetProductById(int id)
        {
            var product = productRepositoryDAL.GetProductById(id);
            if (product == null)
            {
                return null;
            }
            return new ProductDTO
            {
                id = product.ProductID,
                name = product.ProductName,
                categoryID = product.CategoryID ?? 1,
                stockQuantity = product.StockQuantity,
                price = product.Price,
                description = product.Description,
                expiryDate = product.ExpiryDate ?? DateTime.MinValue,
                imageID = product.ImageID ?? 1,
                barcode = product.Barcode
            };
        }

        public bool AddProduct(ProductDTO productDTO, ImageDTO imageDTO)
        {
            return productRepositoryDAL.AddProduct(productDTO, imageDTO);
        }

        public bool UpdateProduct(ProductDTO productDTO)
        {
            return productRepositoryDAL.UpdateProduct(productDTO);
        }

        public bool DeleteProduct(int id)
        {
            return productRepositoryDAL.DeleteProduct(id);
        }

        public List<ProductDTO> GetAvailableProducts(String kw)
        {
            if(kw == null)
            {
                kw = "";
            }
            var products = productRepositoryDAL.GetAvailableProducts(kw);
            return products.Select(p => new ProductDTO
            {
                id = p.ProductID,
                name = p.ProductName,
                categoryID = p.CategoryID ?? 1,
                stockQuantity = p.StockQuantity,
                price = p.Price,
                description = p.Description,
                expiryDate = p.ExpiryDate ?? DateTime.MinValue,
                imageID = p.ImageID ?? 1,
                barcode = p.Barcode
            }).ToList();
        }

    }
}
