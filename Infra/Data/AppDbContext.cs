using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data;

public class AppDbContext : DbContext
{
    public DbSet<Aeroporto> Aeroportos { get; set; }
    public DbSet<Cidade> Cidades { get; set; }
    public DbSet<Voo> Voos { get; set; }
    public DbSet<Classe> Classes { get; set; }
    public DbSet<Passageiro> Passageiros { get; set; }
    public DbSet<Passagem> Passagens { get; set; }
    public DbSet<Bagagem> Bagagens { get; set; }
    public DbSet<Compra> Compras { get; set; }
    public DbSet<Iata> Iatas { get; set; }
    public DbSet<Reserva> Reservas { get; set; }
    public DbSet<Gestor> Gestores { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Aeroporto>().HasKey(a => a.Id);
    }
    public AppDbContext()
    {
        ChangeTracker.AutoDetectChangesEnabled = false;
    }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        ChangeTracker.AutoDetectChangesEnabled = false;
    }
}
