using Microsoft.EntityFrameworkCore;
using Student_management_system.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_management_system.Database
{
    public class DatabaseContext:DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Lecturer> Lecturers { get; set; }

        public DbSet<Module> Modules { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }

        public DbSet<LecturerModule> LecturerModules { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Enrollment>()
            .HasKey(sm => new { sm.StudentRegNo, sm.ModuleCode });

            modelBuilder.Entity<Enrollment>()
                .HasOne(sm => sm.Student)
                .WithMany(s => s.Enrollments)
                .HasForeignKey(sm => sm.StudentRegNo);

            modelBuilder.Entity<Enrollment>()
                .HasOne(sm => sm.Module)
                .WithMany(m => m.Enrollments)
                .HasForeignKey(sm => sm.ModuleCode);


            modelBuilder.Entity<LecturerModule>()
            .HasKey(lm => new { lm.LecturerId, lm.ModCodelec });

           

            modelBuilder.Entity<LecturerModule>()
                .HasOne(lm => lm.Module)
                .WithMany(m1 => m1.LecturerModules)
                .HasForeignKey(lm => lm.ModCodelec);




        }

        public readonly string Path = @"D:\Semester 03\programming project\Student_management_system\StuDB.db";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite($"Data Source={Path}");

    }
}
