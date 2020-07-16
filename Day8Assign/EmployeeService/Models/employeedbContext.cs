using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EmployeeService.Models
{
    public partial class employeedbContext : DbContext
    {
        public employeedbContext()
        {
        }

        public employeedbContext(DbContextOptions<employeedbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Projects> Projects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=vinay1998;database=employeedb");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employees>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PRIMARY");

                entity.ToTable("employees");

                entity.HasIndex(e => e.Pid)
                    .HasName("pid");

                entity.Property(e => e.Eid)
                    .HasColumnName("eid")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ename)
                    .HasColumnName("ename")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Joindate).HasColumnName("joindate");

                entity.Property(e => e.Pid)
                    .HasColumnName("pid")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.P)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.Pid)
                    .HasConstraintName("employees_ibfk_1");
            });

            modelBuilder.Entity<Projects>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PRIMARY");

                entity.ToTable("projects");

                entity.Property(e => e.Pid)
                    .HasColumnName("pid")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Pname)
                    .HasColumnName("pname")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
