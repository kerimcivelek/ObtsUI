using ObtsUI.Shared.Dto.Operation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ObtsUI.Shared.Abstract
{
    public interface IOperationService
    {
       
        Task<OperationTypesDto[]> GetOperationTypes();
        Task<OperationListDto[]> GetList(int CompanyId);
        Task<OperationListDto[]> GetCustomerById(int CustomerId);
        Task Add(OperationDto model);
        Task Update(OperationDto model);
        Task Delete(OperationDto model);
        Task<OperationPrintDto> OperationPrint(int Id);


    }
}
