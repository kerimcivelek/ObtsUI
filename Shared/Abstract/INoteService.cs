using ObtsUI.Shared.Dto.Customer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ObtsUI.Shared.Abstract
{
   public interface INoteService
    {
        Task<NoteDto[]> NotesList(int CustomerId);
        Task Add(NoteDto model);
        Task Delete(NoteDto model);
    }
}
