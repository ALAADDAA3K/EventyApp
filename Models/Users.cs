using EventyApp.Enum;

namespace EventyApp.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Ticket> Tickets { get; set; }
        public Roles Roles { get; set; }
    }
}
