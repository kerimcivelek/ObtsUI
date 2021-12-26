using ObtsUI.Shared.Dto.Company;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ObtsUI.Shared.Abstract
{
   public interface ICopmanyService
    {
        Task<CompanyDto[]> GetCompanies();
        Task<SelectCompanyDto[]> SelectCompany();
        Task<CompanyDto> GetCompanyById(int Id);
        Task Add(CompanyDto model);
        Task Update(CompanyDto model);
        Task Delete(CompanyDto model);
    }
}
