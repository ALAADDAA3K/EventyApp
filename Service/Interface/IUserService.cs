using EventyApp.DTO.UserDto;

namespace EventyApp.Service.Interface
{
    public interface IUserService
    {
        Task<CustomerGetDto> Registration(CustomerRegistrationDto registrationDto);

        Task<CustomerAuthResponseDto> Authenticate(CustomerLoginDto loginDto);
        Task<CustomerAuthResponseDto> UpdateProfile(int customerId, UpdateProfileDto profileDto);
        Task<CustomerAuthResponseDto> ChangePassword(int customerId, ChangePasswordDto passwordDto);
        Task ReplenishBalanceAsync(int customerId, decimal amount);
        Task<decimal> GetBalanceAsync(int customerId);
    }
}
