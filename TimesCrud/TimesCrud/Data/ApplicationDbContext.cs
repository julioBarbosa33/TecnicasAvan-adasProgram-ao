using Microsoft.EntityFrameworkCore;
using TimesCrud.Models;

namespace TimesCrud.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {          
        }
        
        public DbSet<Jogador> Jogadores { get; set; }
    }
}
