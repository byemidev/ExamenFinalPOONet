using AlquilerMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace AlquilerMVC.Data
{
    public class ReservasDbContext : DbContext
    {
        public ReservasDbContext(  DbContextOptions<ReservasDbContext>  options ) : base(options) { 
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }
        public DbSet<Reserva> Reservas { get; set; } 
    }
}
