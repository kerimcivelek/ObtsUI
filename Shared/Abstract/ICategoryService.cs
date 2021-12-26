using ObtsUI.Shared.Dto.Product;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ObtsUI.Shared.Abstract
{
   public interface ICategoryService
    {
        Task Add(Category model);
        Task<CategoryDto[]> CategoryList(int CompanyId);
    }
}
