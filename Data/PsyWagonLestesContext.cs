using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace PsyWagonLestes.Data
{
    public class PsyWagonLestesContext : DbContext
    {
        public PsyWagonLestesContext (DbContextOptions<PsyWagonLestesContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie.Models.Movie> Movie { get; set; }

        public DbSet<RazorPagesMovie.Models.Car> Car { get; set; }
    }
}
