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
    public class OperationDetailService : IOperationDetailService
    {
        HttpClient _httpClient;

        public OperationDetailService(HttpClient client)
        {
            _httpClient = client;
        }
        public  async Task Add(OperationDetailDto model)
        {
            var response = await _httpClient.PostAsJsonAsync("OperationDetails/add", model);
            var exception = await response.Content.ReadAsStringAsync();
            BaseException.ResponseException(exception);
        }

        public  Task Delete(int Id)
        {
            return _httpClient.GetFromJsonAsync<int>("OperationDetails/deletegetbyid?Id="+ Id);
        }

        public async Task DeleteModel(OperationDetailDto model)
        {
           var response = await _httpClient.PostAsJsonAsync("OperationDetails/delete", model);
           var exception = await response.Content.ReadAsStringAsync();
           BaseException.ResponseException(exception);
        }

        public Task<OperationDetailListDto[]> GetListMonth()
        {
            return _httpClient.GetFromJsonAsync<OperationDetailListDto[]>("OperationDetails/getallmonth");
        }
        public Task<OperationDetailListDto[]> GetListDay()
        {
            return _httpClient.GetFromJsonAsync<OperationDetailListDto[]>("OperationDetails/getallday");
        }

        public Task<OperationDetailListDto[]> GetOperationById(int OperationId)
        {
            return _httpClient.GetFromJsonAsync<OperationDetailListDto[]>("OperationDetails/getlistoperationid?OperationId=" + OperationId);
        }

        public async Task Update(OperationDetailDto model)
        {
            var response = await _httpClient.PostAsJsonAsync("OperationDetails/update", model);
            var exception = await response.Content.ReadAsStringAsync();
            BaseException.ResponseException(exception);
        }

        public Task<OperationDetailDto> GetById(int Id)
        {
            return _httpClient.GetFromJsonAsync<OperationDetailDto>("OperationDetails/getbyid?Id=" + Id);
        }

        public Task<OperationDetailListDto> GetByProductInfo(int Id)
        {
            return _httpClient.GetFromJsonAsync<OperationDetailListDto>("OperationDetails/getbyidproductinfo?Id=" + Id);
        }
    }
}




