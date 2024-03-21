using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infra.Persistence;

public class SeradDbContext : DbContext
{
    public SeradDbContext(DbContextOptions<SeradDbContext> options) : base(options)
    {
    }
    
    public DbSet<Cliente> Clientes { get; init; }
    public DbSet<Endereco> Enderecos { get; init; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<Cliente>()
            .HasMany(c => c.Enderecos)
            .WithOne(e => e.Cliente)
            .IsRequired();
    }
    
}