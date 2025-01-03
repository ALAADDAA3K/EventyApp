using EventyApp.Enum;

namespace EventyApp.DTO.UserDto
{
    public struct CustomerRegistrationDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
    public struct CustomerLoginDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public struct CustomerAuthResponseDto
    {
        public string Token { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Roles Role { get; set; }
    }

    public struct CustomerGetDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
    public struct UpdateProfileDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }

    public struct ChangePasswordDto
    {
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
