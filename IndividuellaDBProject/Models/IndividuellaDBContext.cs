using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace IndividuellaDBProject.Models
{
    public partial class IndividuellaDBContext : DbContext
    {
        public IndividuellaDBContext()
        {
        }

        public IndividuellaDBContext(DbContextOptions<IndividuellaDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ClassTbl> ClassTbl { get; set; }
        public virtual DbSet<CourseTbl> CourseTbl { get; set; }
        public virtual DbSet<EmployeeTbl> EmployeeTbl { get; set; }
        public virtual DbSet<EnrollmentTbl> EnrollmentTbl { get; set; }
        public virtual DbSet<GradesTbl> GradesTbl { get; set; }
        public virtual DbSet<JunctionTbl> JunctionTbl { get; set; }
        public virtual DbSet<StudentTbl> StudentTbl { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-HB2LGAV; Initial Catalog = IndividuellaProjectDB; Integrated Security = True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClassTbl>(entity =>
            {
                entity.HasKey(e => e.ClassId);

                entity.ToTable("ClassTBL");

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.ClassName).HasMaxLength(50);
            });

            modelBuilder.Entity<CourseTbl>(entity =>
            {
                entity.HasKey(e => e.CourseId);

                entity.ToTable("CourseTBL");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.CourseName).HasMaxLength(50);

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.CourseTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_CourseTBL_EmployeeTBL");
            });

            modelBuilder.Entity<EmployeeTbl>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.ToTable("EmployeeTBL");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.DateOfEmployment).HasColumnType("date");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Role).HasMaxLength(50);

                entity.Property(e => e.Salary).HasColumnType("money");
            });

            modelBuilder.Entity<EnrollmentTbl>(entity =>
            {
                entity.HasKey(e => e.EnrollmentId);

                entity.ToTable("EnrollmentTBL");

                entity.Property(e => e.EnrollmentId).HasColumnName("EnrollmentID");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.EnrollmentTbl)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK_EnrollmentTBL_CourseTBL");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.EnrollmentTbl)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_EnrollmentTBL_StudentTBL");
            });

            modelBuilder.Entity<GradesTbl>(entity =>
            {
                entity.HasKey(e => e.GradesId);

                entity.ToTable("GradesTBL");

                entity.Property(e => e.GradesId).HasColumnName("GradesID");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EnrollmentId).HasColumnName("EnrollmentID");

                entity.Property(e => e.Grade)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.GradesDateSet).HasColumnType("date");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.GradesTbl)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK_GradesTBL_CourseTBL");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.GradesTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_GradesTBL_EmployeeTBL");

                entity.HasOne(d => d.Enrollment)
                    .WithMany(p => p.GradesTbl)
                    .HasForeignKey(d => d.EnrollmentId)
                    .HasConstraintName("FK_GradesTBL_EnrollmentTBL");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.GradesTbl)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_GradesTBL_StudentTBL");
            });

            modelBuilder.Entity<JunctionTbl>(entity =>
            {
                entity.HasKey(e => e.JunctionId);

                entity.ToTable("JunctionTBL");

                entity.Property(e => e.JunctionId).HasColumnName("JunctionID");

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.EnrollmentId).HasColumnName("EnrollmentID");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.JunctionTbl)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_JunctionTBL_ClassTBL");

                entity.HasOne(d => d.Enrollment)
                    .WithMany(p => p.JunctionTbl)
                    .HasForeignKey(d => d.EnrollmentId)
                    .HasConstraintName("FK_JunctionTBL_EnrollmentTBL");
            });

            modelBuilder.Entity<StudentTbl>(entity =>
            {
                entity.HasKey(e => e.StudentId);

                entity.ToTable("StudentTBL");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.StudentTbl)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_StudentTBL_ClassTBL");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
