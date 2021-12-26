using Blazored.LocalStorage;

using ObtsUI.Client.Utilities;
using ObtsUI.Shared.Abstract;
using ObtsUI.Shared.Dto;
using ObtsUI.Shared.Dto.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ObtsUI.Client.Services
{
    public class AuthService : IAuthService
    {
         

        private HttpClient _http;
        private ILocalStorageService _localStorage;
        public bool IsLoggedIn { get; private set; }
        public AuthService(HttpClient http, ILocalStorageService localStorage)
        {
            _http = http;
            _localStorage = localStorage;
        }
        public async Task<string> LoginControl(LoginDto loginDto)
        {
           var response = await _http.PostAsJsonAsync("https://localhost:44383/api/Auth/login", loginDto);
          
           var result = await response.Content.ReadFromJsonAsync<TokenDto>();
          
            var exception = await response.Content.ReadAsStringAsync();
            if (!string.IsNullOrEmpty(result.Token))
            {
                await _localStorage.SetItemAsync("token", result.Token);
                await _localStorage.SetItemAsync("User", result.UserId);
                await _localStorage.SetItemAsync("Company", result.CompanyId);
                await SetAuthorizationHeader();
            }

            return exception;
        }
        public async Task Login(LoginDto loginDto)
        {
            var response = await _http.PostAsJsonAsync("Auth/login", loginDto);
            var result = await response.Content.ReadFromJsonAsync<TokenDto>(); 
            if (!string.IsNullOrEmpty(result.Token))
                {
                    await _localStorage.SetItemAsync("token", result.Token);
                    await _localStorage.SetItemAsync("key", result.key);
                    await _localStorage.SetItemAsync("role", result.role);
                    await _localStorage.SetItemAsync("Company", result.CompanyId);
                    await SetAuthorizationHeader();
                    IsLoggedIn = true;
                  
            }        
        }

        public async Task LogOut()
        {
            await _localStorage.ClearAsync();
            IsLoggedIn = false;
        }

        private async Task SetAuthorizationHeader()
        {
            if (!_http.DefaultRequestHeaders.Contains("Authorization"))
            {
                var token = await _localStorage.GetItemAsync<string>("token");
                _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
        }

        public  Task<LoginDto> GetByUser(Guid key)
        {
            return _http.GetFromJsonAsync<LoginDto>("Auth/getbyuser?key=" + key);
        }
        public async Task Update(LoginDto model)
        {
            var response = await _http.PostAsJsonAsync("Auth/update", model);
            var exception = await response.Content.ReadAsStringAsync();
            BaseException.ResponseException(exception);
        }

        public Task<LoginDto> GetByUserId(int Id)
        {
            return _http.GetFromJsonAsync<LoginDto>("Auth/getbyuserid?Id=" + Id);
        }

        public async Task Add(UserDto model)
        {

            var response = await _http.PostAsJsonAsync("Auth/register", model);
            var exception = await response.Content.ReadAsStringAsync();
            BaseException.ResponseException(exception);
        }

        public Task<UserDto[]> GetUsers()
        {
            return _http.GetFromJsonAsync<UserDto[]>("Auth/getall");
        }
    }
}
