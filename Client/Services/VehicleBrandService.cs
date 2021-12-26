using ObtsUI.Shared.Abstract;
using ObtsUI.Shared.Dto.VehicleBrand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ObtsUI.Client.Services
{
    public class VehicleBrandService : IVehicleBrandService
    {
        private HttpClient _httpClient;
        public VehicleBrandService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public Task<BrandDto[]> GetBrands()
        {
            return _httpClient.GetFromJsonAsync<BrandDto[]>("VehicleBrands/getall");
        }
    }
}
