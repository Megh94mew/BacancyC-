using TMS.DTOs;
using TMS.Models;
using TMS.Repositories.Interfaces;
using TMS.Services.Interfaces;
using BCrypt.Net;

namespace TMS.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task CreateUserAsync(CreateUserDto dto)
        {
            var existingUser = await _repository.GetByEmailAsync(dto.Email);

            if (existingUser != null)
                throw new Exception("User already exists");

            var user = new User
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(dto.Password),
                RoleId = dto.RoleId
            };

            await _repository.AddUserAsync(user);
            await _repository.SaveAsync();
        }
    }
}using TMS.DTOs;
using TMS.Models;
using TMS.Repositories.Interfaces;
using TMS.Services.Interfaces;
using BCrypt.Net;

namespace TMS.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task CreateUserAsync(CreateUserDto dto)
        {
            var existingUser = await _repository.GetByEmailAsync(dto.Email);

            if (existingUser != null)
                throw new Exception("User already exists");

            var user = new User
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(dto.Password),
                RoleId = dto.RoleId
            };

            await _repository.AddUserAsync(user);
            await _repository.SaveAsync();
        }
    }
}