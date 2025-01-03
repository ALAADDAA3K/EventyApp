using EventyApp.Data;
using EventyApp.DTO.UserDto;
using EventyApp.Enum;
using EventyApp.Models;
using EventyApp.Service.Interface;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace EventyApp.Service.Classess
{
    public class UserService : IUserService
    {
        private readonly DataContext _context;
        private readonly IConfiguration _configuration;

        public UserService(DataContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public Task<CustomerAuthResponseDto> Authenticate(CustomerLoginDto loginDto)
        {
            throw new NotImplementedException();
        }

        public Task<CustomerAuthResponseDto> ChangePassword(int customerId, ChangePasswordDto passwordDto)
        {
            throw new NotImplementedException();
        }

        public Task<decimal> GetBalanceAsync(int customerId)
        {
            throw new NotImplementedException();
        }

        public async Task<CustomerGetDto> Registration(CustomerRegistrationDto registrationDto)
        {
            if (_context.Users.Any(u => u.Email == registrationDto.Email))
                throw new Exception("Email already exists.");

            var user = new Users
            {
                Name = registrationDto.Name,
                Email = registrationDto.Email,
                Password = BCrypt.Net.BCrypt.HashPassword(registrationDto.Password),
                Roles = Roles.Customer
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return new CustomerGetDto
            {
                Name = user.Name,
                Email = user.Email
            };
        }
        public Task ReplenishBalanceAsync(int customerId, decimal amount)
        {
            throw new NotImplementedException();
        }

        public Task<CustomerAuthResponseDto> UpdateProfile(int customerId, UpdateProfileDto profileDto)
        {
            throw new NotImplementedException();
        }
    }
}
