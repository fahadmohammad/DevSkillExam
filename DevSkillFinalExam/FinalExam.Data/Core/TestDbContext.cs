using FinalExam.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExam.Data.Core
{
    public class TestDbContext : DbContext
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public TestDbContext(DbContextOptions<TestDbContext> dbContextOptions)
            : base(dbContextOptions)
        {

        }
        public TestDbContext(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer(_connectionString, m => m.MigrationsAssembly(_migrationAssemblyName));
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>().HasMany(t => t.TeacherStudents).WithOne
                (ts => ts.Teacher).HasForeignKey(ts => ts.TeachertId);
            modelBuilder.Entity<Student>().HasMany(s => s.TeacherStudents).WithOne
                (ts => ts.Student).HasForeignKey(ts => ts.StudentId);
            modelBuilder.Entity<TeacherStudnets>().HasKey(ts => new { ts.TeachertId, ts.StudentId });

            modelBuilder.Entity<Course>().HasMany(c => c.StudentCourses).WithOne
                (sc => sc.Course).HasForeignKey(sc => sc.CourseId);
            modelBuilder.Entity<Student>().HasMany(s => s.StudentCourses).WithOne
                (sc => sc.Student).HasForeignKey(sc => sc.StudentId);
            modelBuilder.Entity<StudentCourses>().HasKey(sc => new { sc.StudentId, sc.CourseId });           
        }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<TeacherStudnets> TeacherStudnets { get; set; }
        public DbSet<StudentCourses> StudentCourses { get; set; }
        
    }
}
