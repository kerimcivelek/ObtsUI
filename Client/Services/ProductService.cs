using ObtsUI.Client.Utilities;
using ObtsUI.Shared.Abstract;
using ObtsUI.Shared.Dto.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ObtsUI.Client.Services
{
    public class ProductService : IProductService
    {
        private HttpClient _httpClient;
        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task Add(Product model)
        {
            var response = await _httpClient.PostAsJsonAsync("Products/add", model);
            var exception = await response.Content.ReadAsStringAsync();
            BaseException.ResponseException(exception);
        }

        public async Task Delete(Product model)
        {
            var response = await _httpClient.PostAsJsonAsync("Products/delete", model);
            var exception = await response.Content.ReadAsStringAsync();
            BaseException.ResponseException(exception);
        }

        public   Task<Product> GetProductById(int Id)
        {
            return _httpClient.GetFromJsonAsync<Product>("Products/getbyid?Id=" + Id);
        }

        public Task<ProductDto[]> ProductList(int CategoryId)
        {
            return _httpClient.GetFromJsonAsync<ProductDto[]>("Products/getbyidcategory?CategoryId=" + CategoryId);
          
        }

        public Task<ProductDto[]> Products()
        {
            return _httpClient.GetFromJsonAsync<ProductDto[]>("Products/productlist");
        }

        public Task<Product[]> Products(int CategoryId)
        {
            return _httpClient.GetFromJsonAsync<Product[]>("Products/getbyidcategory?CategoryId=" + CategoryId);
        }

        public async  Task Update(Product model)
        {
            var response = await _httpClient.PostAsJsonAsync("Products/update", model);
            var exception = await response.Content.ReadAsStringAsync();
            BaseException.ResponseException(exception);
        }
    }
}
