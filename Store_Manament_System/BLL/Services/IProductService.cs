using DTO.DTO;
using System.Collections.Generic;

namespace BLL.Services
{
    public interface IProductService
    {
        bool AddProduct(ProductDTO productDTO, ImageDTO imageDTO);
        bool DeleteProduct(int id);
        List<ProductDTO> GetAllProducts(string kw);
        List<ProductDTO> GetAvailableProducts(string kw);
        ProductDTO GetProductById(int id);
        bool UpdateProduct(ProductDTO productDTO);
    }
}