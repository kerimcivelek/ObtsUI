using ObtsUI.Shared.Dto.Operation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ObtsUI.Shared.Abstract
{
   public interface IOperationDetailService
    {

        Task<OperationDetailListDto[]> GetOperationById(int OperationId);

        Task<OperationDetailDto> GetById(int Id);
        Task<OperationDetailListDto> GetByProductInfo(int Id);
        Task Add(OperationDetailDto model);
        Task Update(OperationDetailDto model);
        Task DeleteModel(OperationDetailDto model);
        Task Delete(int Id);
    }
}
