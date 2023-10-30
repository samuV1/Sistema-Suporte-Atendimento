using Microsoft.EntityFrameworkCore;

namespace Sistema_Suporte_Atendimento.Models;

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Avisos> Avisos { get; set; }
        public DbSet<Equipamentos> Equipamentos { get; set; }
        public DbSet<OrdemServicos> OrdemServicos { get; set; }
        public DbSet<Setores> Setores { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }


    }
