using ObtsUI.Client.Utilities;
using ObtsUI.Shared.Abstract;
using ObtsUI.Shared.Dto;
using ObtsUI.Shared.Dto.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ObtsUI.Client.Services
{
    public class CompanyService : ICopmanyService
    {
        private HttpClient _httpClient;
        public CompanyService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task Add(CompanyDto model)
        {
            var response = await _httpClient.PostAsJsonAsync("Companies/add", model);
            var exception = await response.Content.ReadAsStringAsync();
            BaseException.ResponseException(exception);
        }

        public async Task Delete(CompanyDto model)
        {
            var response = await _httpClient.PostAsJsonAsync("Companies/delete", model);
            var exception = await response.Content.ReadAsStringAsync();
            BaseException.ResponseException(exception);
        }

        public Task<CompanyDto[]> GetCompanies()
        {
            return _httpClient.GetFromJsonAsync<CompanyDto[]>("Companies/getall");
        }

        public Task<CompanyDto> GetCompanyById(int Id)
        {
            return _httpClient.GetFromJsonAsync<CompanyDto>("Companies/getbyId?Id=" + Id);
        }

        public Task<SelectCompanyDto[]> SelectCompany()
        {
            return _httpClient.GetFromJsonAsync<SelectCompanyDto[]>("Companies/selectcompany");
        }

        public async Task Update(CompanyDto model)
        {
            var response = await _httpClient.PostAsJsonAsync("Companies/update", model);
            var exception = await response.Content.ReadAsStringAsync();
            BaseException.ResponseException(exception);
        }
        
    }
}
