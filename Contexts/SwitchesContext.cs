using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using switchAPI.Models;

namespace switchAPI.Contexts;

public partial class SwitchesContext : DbContext
{
    public SwitchesContext() {}

    public SwitchesContext(DbContextOptions<SwitchesContext> options) : base(options) {}

    public virtual DbSet<Switch> Switches { get; set; }

    public virtual DbSet<Variant> Variants { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=.\\Database\\switches.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Switch>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("switches");

            entity.Property(e => e.Actuation).HasColumnName("actuation");
            entity.Property(e => e.Bottom).HasColumnName("bottom");
            entity.Property(e => e.Curvesource).HasColumnName("curvesource");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Imagesource).HasColumnName("imagesource");
            entity.Property(e => e.Info).HasColumnName("info");
            entity.Property(e => e.Infosource).HasColumnName("infosource");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Ptravel).HasColumnName("ptravel");
            entity.Property(e => e.Review).HasColumnName("review");
            entity.Property(e => e.Reviewsource).HasColumnName("reviewsource");
            entity.Property(e => e.Soundsource).HasColumnName("soundsource");
            entity.Property(e => e.Tactileforce).HasColumnName("tactileforce");
            entity.Property(e => e.Ttravel).HasColumnName("ttravel");
        });

        modelBuilder.Entity<Variant>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("variants");

            entity.Property(e => e.Actuation).HasColumnName("actuation");
            entity.Property(e => e.Bottom).HasColumnName("bottom");
            entity.Property(e => e.Curve).HasColumnName("curve");
            entity.Property(e => e.From).HasColumnName("from");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Ptravel).HasColumnName("ptravel");
            entity.Property(e => e.Review).HasColumnName("review");
            entity.Property(e => e.Reviewfrom).HasColumnName("reviewfrom");
            entity.Property(e => e.Sound).HasColumnName("sound");
            entity.Property(e => e.Tactileforce).HasColumnName("tactileforce");
            entity.Property(e => e.Ttravel).HasColumnName("ttravel");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
