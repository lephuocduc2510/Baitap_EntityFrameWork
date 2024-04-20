using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace db_fisrt.Models;

public partial class StudentsContext : DbContext
{
    public StudentsContext()
    {
    }

    public StudentsContext(DbContextOptions<StudentsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Faculty> Faculties { get; set; }

    public virtual DbSet<Lop> Lops { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-B0D0J2Q;Initial Catalog=Students;Persist Security Info=True;User ID=sa;Password=12345;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Faculty>(entity =>
        {
            entity.Property(e => e.FacultyId).HasColumnName("FacultyID");
        });

        modelBuilder.Entity<Lop>(entity =>
        {
            entity.HasKey(e => e.ClassId);

            entity.HasIndex(e => e.FacultyId, "IX_Lops_FacultyID");

            entity.Property(e => e.ClassId).HasColumnName("classID");
            entity.Property(e => e.ClassName).HasColumnName("className");
            entity.Property(e => e.FacultyId).HasColumnName("FacultyID");

            entity.HasOne(d => d.Faculty).WithMany(p => p.Lops).HasForeignKey(d => d.FacultyId);
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasIndex(e => e.ClassId, "IX_Students_classID");

            entity.Property(e => e.ClassId).HasColumnName("classID");

            entity.HasOne(d => d.Class).WithMany(p => p.Students).HasForeignKey(d => d.ClassId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
