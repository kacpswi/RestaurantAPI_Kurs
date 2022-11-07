using Microsoft.AspNetCore.Identity;
using RestaurantAPI_v2.Entities;
using RestaurantAPI_v2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAPI_v2.Services
{
    public interface IAccountService
    {
        void RegisterUser(RegisterUserDto dto);
    }
    public class AccountService : IAccountService
    {
        private readonly RestaurantDbContext _context;
        private readonly IPasswordHasher<User> _passwodrHasher;
        public AccountService(RestaurantDbContext context, IPasswordHasher<User> passwordHasher)
        {
            _context = context;
            _passwodrHasher = passwordHasher;
        }
        public void RegisterUser(RegisterUserDto dto)
        {
            var newUser = new User()
            {
                Email = dto.Email,
                DateOfBirth = dto.DateOfBirth,
                Nationality = dto.Nationality,
                RoleId = dto.RoleId,
            };
            var hasherdPassword = _passwodrHasher.HashPassword(newUser,dto.Password);
            newUser.PasswordHash = hasherdPassword;
            _context.Users.Add(newUser);
            _context.SaveChanges();

        }
    }
}
