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
    public class CategoryService : ICategoryService
    {
        private HttpClient _httpClient;
        public CategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
 

        public   Task<CategoryDto[]> CategoryList(int CompanyId)
        {
            return _httpClient.GetFromJsonAsync<CategoryDto[]>("Categories/getall?CompanyId=" + CompanyId);
        }

        public async Task Add(Category model)
        {
            var response = await _httpClient.PostAsJsonAsync("Categories/add", model);
            var exception = await response.Content.ReadAsStringAsync();
            BaseException.ResponseException(exception);
        }
    }
}
