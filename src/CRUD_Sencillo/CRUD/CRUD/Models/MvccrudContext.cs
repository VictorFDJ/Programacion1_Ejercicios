using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Models;

public partial class MvccrudContext : DbContext
{
    // Constructor sin parámetros
    public MvccrudContext()
    {
    }

    // Constructor con DbContextOptions para inyección de dependencias
    public MvccrudContext(DbContextOptions<MvccrudContext> options)
        : base(options)
    {
    }

    // DbSet de Usuario
    public virtual DbSet<Usuario> Usuarios { get; set; }

    // Eliminamos la cadena de conexión del OnConfiguring
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Ya no necesitamos la cadena de conexión aquí
    }

    // Configuración de la entidad Usuario
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__USUARIOS__3214EC0728E39EE5");

            entity.ToTable("USUARIOS");

            entity.Property(e => e.Clave)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    // Método parcial para extensión
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
