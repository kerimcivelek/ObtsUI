using ObtsUI.Shared.Dto.Login;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ObtsUI.Shared.Abstract
{
   public interface IAuthService
    {

        Task<UserDto[]> GetUsers();
        Task Login(LoginDto loginModel);

        Task Add(UserDto model);
        Task Update(LoginDto model);
        Task LogOut();
        Task<LoginDto> GetByUser(Guid key);
        Task<LoginDto> GetByUserId(int kIdey);
        Task<string> LoginControl(LoginDto loginDto);



    }
}
