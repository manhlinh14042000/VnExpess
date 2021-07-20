using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VnExpress.ViewModel.Users;

namespace VnExpress.Application.Users
{
    public interface IUserService
    {
        Task<string> Authencate(LoginRequest request);

        Task<bool> Register(RegisterRequest request);
        Task<List<UserVm>> GetAll();
        Task<int> Create(UserCreateRequest request);

        Task<int> Update(UserUpdateRequest request);
        Task<int> Delete(int idUser);
        Task<UserVm> GetById(int idUser);
    }
}
