using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EF_lez01_single_table.Models;

public partial class EfLez01SingleTableContext : DbContext
{
    public EfLez01SingleTableContext()
    {
    }

    public EfLez01SingleTableContext(DbContextOptions<EfLez01SingleTableContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Contatto> Contattos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=BOOK-N57JVKH6HJ\\SQLEXPRESS;Database=ef_lez01_single_table;User Id=academy;Password=academy!;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Contatto>(entity =>
        {
            entity.HasKey(e => e.ContattoId).HasName("PK__Contatto__29999534AA6D709C");

            entity.ToTable("Contatto");

            entity.HasIndex(e => e.Email, "UQ__Contatto__AB6E61645F2CEDA3").IsUnique();

            entity.HasIndex(e => e.CodFis, "UQ__Contatto__FFE8FD98E5387B38").IsUnique();

            entity.Property(e => e.ContattoId).HasColumnName("contattoID");
            entity.Property(e => e.CodFis)
                .HasMaxLength(16)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cod_fis");
            entity.Property(e => e.Cognome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cognome");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Eta).HasColumnName("eta");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
