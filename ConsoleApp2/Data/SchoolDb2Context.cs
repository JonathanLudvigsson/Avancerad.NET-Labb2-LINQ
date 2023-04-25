using System;
using System.Collections.Generic;
using Labb2LINQ.Models;
using Microsoft.EntityFrameworkCore;

namespace Labb2LINQ.Data;

public partial class SchoolDb2Context : DbContext
{
    public SchoolDb2Context()
    {
    }

    public SchoolDb2Context(DbContextOptions<SchoolDb2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<CourseSubject> CourseSubjects { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<StudentCourse> StudentCourses { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    public virtual DbSet<Teacher> Teachers { get; set; }

    public virtual DbSet<TeacherCourse> TeacherCourses { get; set; }

    public virtual DbSet<TeacherSubject> TeacherSubjects { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=MIDGAR;Initial Catalog=SchoolDB2; TrustServerCertificate=True; Integrated Security = true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>(entity =>
        {
            entity.Property(e => e.CourseId)
                .ValueGeneratedNever()
                .HasColumnName("CourseID");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CourseSubject>(entity =>
        {
            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CourseId).HasColumnName("CourseID");
            entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

            entity.HasOne(d => d.Course).WithMany(p => p.CourseSubjects)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK_CourseSubjects_Courses");

            entity.HasOne(d => d.Subject).WithMany(p => p.CourseSubjects)
                .HasForeignKey(d => d.SubjectId)
                .HasConstraintName("FK_CourseSubjects_Subjects");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.Property(e => e.StudentId)
                .ValueGeneratedNever()
                .HasColumnName("StudentID");
            entity.Property(e => e.Fname)
                .HasMaxLength(50)
                .HasColumnName("FName");
            entity.Property(e => e.Lname)
                .HasMaxLength(50)
                .HasColumnName("LName");
        });

        modelBuilder.Entity<StudentCourse>(entity =>
        {
            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CourseId).HasColumnName("CourseID");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");

            entity.HasOne(d => d.Course).WithMany(p => p.StudentCourses)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StudentCourses_Courses");

            entity.HasOne(d => d.Student).WithMany(p => p.StudentCourses)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_StudentCourses_Students");
        });

        modelBuilder.Entity<Subject>(entity =>
        {
            entity.Property(e => e.SubjectId)
                .ValueGeneratedNever()
                .HasColumnName("SubjectID");
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Teacher>(entity =>
        {
            entity.Property(e => e.TeacherId)
                .ValueGeneratedNever()
                .HasColumnName("TeacherID");
            entity.Property(e => e.Fname)
                .HasMaxLength(50)
                .HasColumnName("FName");
            entity.Property(e => e.Lname)
                .HasMaxLength(50)
                .HasColumnName("LName");
        });

        modelBuilder.Entity<TeacherCourse>(entity =>
        {
            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CourseId).HasColumnName("CourseID");
            entity.Property(e => e.TeacherId).HasColumnName("TeacherID");

            entity.HasOne(d => d.Course).WithMany(p => p.TeacherCourses)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK_TeacherCourses_Courses");

            entity.HasOne(d => d.Teacher).WithMany(p => p.TeacherCourses)
                .HasForeignKey(d => d.TeacherId)
                .HasConstraintName("FK_TeacherCourses_Teachers");
        });

        modelBuilder.Entity<TeacherSubject>(entity =>
        {
            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.SubjectId).HasColumnName("SubjectID");
            entity.Property(e => e.TeacherId).HasColumnName("TeacherID");

            entity.HasOne(d => d.Subject).WithMany(p => p.TeacherSubjects)
                .HasForeignKey(d => d.SubjectId)
                .HasConstraintName("FK_TeacherSubjects_Subjects");

            entity.HasOne(d => d.Teacher).WithMany(p => p.TeacherSubjects)
                .HasForeignKey(d => d.TeacherId)
                .HasConstraintName("FK_TeacherSubjects_Teachers");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
