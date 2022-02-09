using Microsoft.EntityFrameworkCore;

namespace PsyWagonLestes.Data
{
    public class PsyWagonLestesContext : DbContext
    {
        public PsyWagonLestesContext(DbContextOptions<PsyWagonLestesContext> options)
            : base(options)
        {
        }

        //Подключение моделей

        public DbSet<RazorPagesMovie.Models.User> User { get; set; }

        public DbSet<RazorPagesMovie.Models.Car> Car { get; set; }
    }
}