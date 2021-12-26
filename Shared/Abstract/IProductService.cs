using ObtsUI.Shared.Dto.Product;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ObtsUI.Shared.Abstract
{
   public interface IProductService
    {
        Task<ProductDto[]> ProductList(int CategoryId);
     
        Task<ProductDto[]> Products();


        Task<Product[]> Products(int CategoryId);
        Task<Product> GetProductById(int Id);
        Task Add(Product model);
        Task Update(Product model);
        Task Delete(Product model);

    }
}
