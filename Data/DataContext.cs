using EventyApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EventyApp.Data
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Event> Events { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Theater> Theaters { get; set; }
        public DbSet<Transportation> Transportations { get; set; }
        public DbSet<Airplane> Airplanes { get; set; }
    }
}
