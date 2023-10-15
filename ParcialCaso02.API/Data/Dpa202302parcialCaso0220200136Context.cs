using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ParcialCaso02.API.Data;

public partial class Dpa202302parcialCaso0220200136Context : DbContext
{
    public Dpa202302parcialCaso0220200136Context()
    {
    }

    public Dpa202302parcialCaso0220200136Context(DbContextOptions<Dpa202302parcialCaso0220200136Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Country> Country { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=WS2302504;Database=DPA202302ParcialCaso0220200136;Integrated Security=true;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Country>(entity =>
        {
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.Currency).HasMaxLength(3);
            entity.Property(e => e.Description).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
