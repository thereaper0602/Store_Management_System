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
            return productRepositoryDAL.GetAllProducts(kw);
        }

        public ProductDTO GetProductById(int id)
        {
            return productRepositoryDAL.GetProductById(id);
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

    }
}
