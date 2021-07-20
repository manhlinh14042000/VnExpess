using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VnExpress.Data.EF;
using VnExpress.Data.Entities;
using VnExpress.ViewModel.Users;

namespace VnExpress.Application.Users
{
    public class UserService : IUserService
    {
        private readonly VnExpressDbContext _context;

        public UserService(VnExpressDbContext context)
        {
            _context = context;

        }

        public Task<string> Authencate(LoginRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Create(UserCreateRequest request)
        {
            var user = new User()
            {
                IdUser = request.IdUser,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                UserName = request.UserName,
                Password = request.Password,
                ConfirmPassword = request.ConfirmPassword
            };
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user.IdUser;
        }
        public async Task<int> Delete(int idUser)
        {
            var user = await _context.Users.FindAsync(idUser);
            if (user == null) throw new Exception($"Cannot find a User: {idUser}");
            _context.Users.Remove(user);
            return await _context.SaveChangesAsync();
        }
        public async Task<List<UserVm>> GetAll()
        {
            var users = await _context.Users.OrderByDescending(user => user.IdUser).Select(user => new UserVm()
            {
                IdUser = user.IdUser,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                UserName = user.UserName,
                Password = user.Password,
                ConfirmPassword = user.ConfirmPassword
            }).ToListAsync();
            return users;
        }
        public async Task<UserVm> GetById(int idUser)
        {
            var user = await _context.Users.FindAsync(idUser);
            var userViewModel = new UserVm()
            {

                IdUser = user.IdUser,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                UserName = user.UserName,
                Password = user.Password,
                ConfirmPassword = user.ConfirmPassword
            };
            return userViewModel;
        }

        public Task<bool> Register(RegisterRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Update(UserUpdateRequest request)
        {
            var user = await _context.Users.FindAsync(request.IdUser);
            if (user == null) throw new Exception($"Cannot find a user with id: {request.IdUser}");
            user.FirstName = request.FirstName;
            user.LastName = request.LastName;
            user.Email = request.Email;
            user.UserName = request.UserName;
            user.Password = request.Password;
            user.ConfirmPassword = request.ConfirmPassword;
            return await _context.SaveChangesAsync();
        }
    }
}
