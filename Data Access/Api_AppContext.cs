using Api_App.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api_App.Data_Access
{
    public class Api_AppContext : DbContext
    {
        public Api_AppContext() { }

        public Api_AppContext(DbContextOptions<Api_AppContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=DbApi_App;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        public virtual DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().HasData(
            new Team
            {
                Id = 1,
                Image = "https://a.espncdn.com/combiner/i?img=/i/teamlogos/soccer/500/5.png&h=200&w=200",
                Name = "Boca",
                Location = "La Boca",
                Titles = 74
            },
            new Team
            {
                Id = 2,
                Image = "https://a.espncdn.com/combiner/i?img=/i/teamlogos/soccer/500/16.png&h=200&w=200",
                Name = "River",
                Location = "Nuñez",
                Titles = 70
            },
            new Team
            {
                Id = 3,
                Image = "https://a.espncdn.com/combiner/i?img=/i/teamlogos/soccer/500/11.png&h=200&w=200",
                Name = "Independiente",
                Location = "Avellaneda",
                Titles = 45
            },
            new Team
            {
                Id = 4,
                Image = "https://a.espncdn.com/combiner/i?img=/i/teamlogos/soccer/500/15.png&h=200&w=200",
                Name = "Racing Club",
                Location = "Avellaneda",
                Titles = 39
            },
            new Team
            {
                Id = 5,
                Image = "https://a.espncdn.com/combiner/i?img=/i/teamlogos/soccer/500/18.png&h=200&w=200",
                Name = "San Lorenzo",
                Location = "Flores",
                Titles = 22
            },
            new Team
            {
                Id = 6,
                Image = "https://a.espncdn.com/combiner/i?img=/i/teamlogos/soccer/500/21.png&h=200&w=200",
                Name = "Velez",
                Location = "Liniers",
                Titles = 16
            },
            new Team
            {
                Id = 7,
                Image = "https://a.espncdn.com/combiner/i?img=/i/teamlogos/soccer/500/8.png&h=200&w=200",
                Name = "Estudiantes",
                Location = "La Plata",
                Titles = 14
            },
            new Team
            {
                Id = 8,
                Image = "https://a.espncdn.com/combiner/i?img=/i/teamlogos/soccer/500/10.png&h=200&w=200",
                Name = "Huracan",
                Location = "Parque Patricios",
                Titles = 13
            },
            new Team
            {
                Id = 9,
                Image = "https://a.espncdn.com/combiner/i?img=/i/teamlogos/soccer/500/17.png&h=200&w=200",
                Name = "Rosario Central",
                Location = "Rosario",
                Titles = 11
            },
            new Team
            {
                Id = 10,
                Image = "https://a.espncdn.com/combiner/i?img=/i/teamlogos/soccer/500/14.png&h=200&w=200",
                Name = "Newells",
                Location = "Rosario",
                Titles = 9
            });
        }
    }
}
