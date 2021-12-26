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
    public class NoteService : INoteService  
    {
        private HttpClient _httpClient;
        public NoteService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async  Task Add(NoteDto model)
        {
           var response = await _httpClient.PostAsJsonAsync("Notes/add", model);
           var exception = await response.Content.ReadAsStringAsync();
           BaseException.ResponseException(exception);
        }

        public async Task Delete(NoteDto model)
        {
            var response = await _httpClient.PostAsJsonAsync("Notes/delete", model);
            var exception = await response.Content.ReadAsStringAsync();
            BaseException.ResponseException(exception);
        }

        public Task<NoteDto[]> NotesList(int CustomerId)
        {
            return _httpClient.GetFromJsonAsync<NoteDto[]>("Notes/getbyid?CustomerId=" + CustomerId);
        }
      

    }
}
