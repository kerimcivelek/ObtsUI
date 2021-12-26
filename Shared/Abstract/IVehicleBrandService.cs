using ObtsUI.Shared.Dto.VehicleBrand;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ObtsUI.Shared.Abstract
{
  public  interface IVehicleBrandService
    {
        Task<BrandDto[]> GetBrands();
    }
}
