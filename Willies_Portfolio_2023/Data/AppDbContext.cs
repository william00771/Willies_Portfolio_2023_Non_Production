using Microsoft.EntityFrameworkCore;
using Willies_Portfolio_2023.Models;

namespace Willies_Portfolio_2023.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Film> Films { get; set; }
        public DbSet<Still> Stills { get; set; }
        public DbSet<NetProject> NetProjects { get; set; }
        public DbSet<NetProjectBreakdownSection> NetProjectsBreakdownSections { get; set; }
        public DbSet<NetProjectDescription> NetProjectsDescriptions { get; set; }
    }
}
