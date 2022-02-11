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
        public DbSet<RazorPagesMovie.Models.Movie> Movie { get; set; }

        public DbSet<RazorPagesMovie.Models.Car> Car { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<AppUser>(entity =>
        //    {
        //        entity.ToTable(name: "Users");
        //    });

        //    modelBuilder.Entity<AppRole>(entity =>
        //    {
        //        entity.ToTable(name: "Roles");
        //    });
        //    modelBuilder.Entity<IdentityUserRole<string>>(entity =>
        //    {
        //        entity.ToTable("UserRoles");
        //    });

        //    modelBuilder.Entity<IdentityUserClaim<string>>(entity =>
        //    {
        //        entity.ToTable("UserClaims");
        //    });

        //    modelBuilder.Entity<IdentityUserLogin<string>>(entity =>
        //    {
        //        entity.ToTable("UserLogins");
        //    });

        //    modelBuilder.Entity<IdentityRoleClaim<string>>(entity =>
        //    {
        //        entity.ToTable("RoleClaims");
        //    });

        //    modelBuilder.Entity<IdentityUserToken<string>>(entity =>
        //    {
        //        entity.ToTable("UserTokens");
        //    });
        //}
    }
}