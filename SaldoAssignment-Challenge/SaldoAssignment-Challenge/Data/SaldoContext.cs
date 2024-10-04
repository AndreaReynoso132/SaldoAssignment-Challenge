using Microsoft.EntityFrameworkCore;
using SaldoAssignment.Domain.Entities;

namespace SaldoAssignment.Data
{
    public class SaldoContext : DbContext
    {
        public SaldoContext(DbContextOptions<SaldoContext> options) : base(options) { }

        public DbSet<Gestor> Gestores { get; set; }
        public DbSet<Saldo> Saldos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Gestor>().HasData(
                new Gestor { Id = 1, Nombre = "Gestor 1" },
                new Gestor { Id = 2, Nombre = "Gestor 2" }
            );
        }
    }
}
