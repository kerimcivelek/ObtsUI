using ObtsUI.Client.Utilities;
using ObtsUI.Shared.Abstract;
using ObtsUI.Shared.Dto.Operation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ObtsUI.Client.Services
{
    public class OperationService : IOperationService
    {
        private HttpClient _httpClient;
        public OperationService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task Add(OperationDto model)
        {
            var response = await _httpClient.PostAsJsonAsync("Operations/add", model);
            var exception = await response.Content.ReadAsStringAsync();
            BaseException.ResponseException(exception);
        }

        public async Task Delete(OperationDto model)
        {
            var response =  await _httpClient.PostAsJsonAsync("Operations/delete", model);
            var exception = await response.Content.ReadAsStringAsync();
            BaseException.ResponseException(exception);
        }

        public Task<OperationListDto[]> GetCustomerById(int CustomerId)
        {
            return _httpClient.GetFromJsonAsync<OperationListDto[]>("Operations/getlistcustomerid?CustomerId=" + CustomerId);
         
        }

        public Task<OperationListDto[]> GetList(int CompanyId)
        {
            return _httpClient.GetFromJsonAsync<OperationListDto[]>("Operations/getall" + "&CompanyId=" + CompanyId);
        }

        public Task<OperationTypesDto[]> GetOperationTypes()
        {
            return _httpClient.GetFromJsonAsync<OperationTypesDto[]>("OperationTypes/getall");
        }

        public Task<OperationPrintDto> OperationPrint(int Id)
        {
            return _httpClient.GetFromJsonAsync<OperationPrintDto>("Operations/operationprint?Id=" + Id );
        }

        public async Task Update(OperationDto model)
        {
           var response = await _httpClient.PostAsJsonAsync("Operations/update", model);
            var exception = await response.Content.ReadAsStringAsync();
            BaseException.ResponseException(exception);
        }
    }
}


