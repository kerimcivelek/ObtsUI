using ObtsUI.Client.Utilities;
using ObtsUI.Shared.Abstract;
using ObtsUI.Shared.Dto.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ObtsUI.Client.Services
{
    public class CustomerService : ICustomerService
    {
        private HttpClient _httpClient;
        public CustomerService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task Add(CustomerDto model)
        {
            var response = await _httpClient.PostAsJsonAsync("Customers/add", model);
            var exception = await response.Content.ReadAsStringAsync();
            BaseException.ResponseException(exception);
        }

        public async Task Delete(CustomerDto model)
        {
            var response =  await _httpClient.PostAsJsonAsync("Customers/delete", model);
            var exception = await response.Content.ReadAsStringAsync();
            BaseException.ResponseException(exception);
        }

        public Task<CustomerDto[]> GetCustomer()
        {
            return _httpClient.GetFromJsonAsync<CustomerDto[]>("Customers/getall");
        }

        public Task<CustomerDto> GetCustomerById(int Id)
        {

            return _httpClient.GetFromJsonAsync<CustomerDto>("Customers/getbyId?Id=" + Id);
        }

        public Task<CustomerDto[]> GetCustomerDate(string RegisterDate , int CompanyId)
        {
            return _httpClient.GetFromJsonAsync<CustomerDto[]>("Customers/getalldate?RegisterDate=" + RegisterDate+ "&CompanyId=" + CompanyId);
        }

        public Task<CustomerDto[]> GetCustomerSelectedDate(string StartDate, string EndDate, int CompanyId)
        {
            return _httpClient.GetFromJsonAsync<CustomerDto[]>("Customers/getallselecteddate?StartDate=" + StartDate + "&EndDate="+ EndDate+ "&CompanyId=" + CompanyId);
        }

    

        public   Task<CustomerDto[]> SearchCustomer(string Plaka , int CompanyId)
        {
            return _httpClient.GetFromJsonAsync<CustomerDto[]>("Customers/search?Plaka=" + Plaka + "&CompanyId=" + CompanyId);
        }

        public async Task Update(CustomerDto model)
        {
            var response = await _httpClient.PostAsJsonAsync("Customers/update", model);
            var exception = await response.Content.ReadAsStringAsync();
            BaseException.ResponseException(exception);
        }

      
    }
}
