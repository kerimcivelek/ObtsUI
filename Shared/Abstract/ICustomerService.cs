using ObtsUI.Shared.Dto.Customer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ObtsUI.Shared.Abstract
{
    public interface ICustomerService
    {
        Task<CustomerDto[]> GetCustomer();
        Task<CustomerDto[]> GetCustomerDate(string RegisterDate ,int CompanyId);
        Task<CustomerDto[]> GetCustomerSelectedDate(string StartDate , string EndDate, int CompanyId);
        Task<CustomerDto> GetCustomerById(int Id);
        Task<CustomerDto[]> SearchCustomer(string Plaka, int CompanyId);
        Task Add(CustomerDto model);
        Task Update(CustomerDto model);
        Task Delete(CustomerDto model);
    }
}
