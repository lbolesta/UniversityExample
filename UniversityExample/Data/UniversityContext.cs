using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityExample.Models;


namespace UniversityExample.Data
{
    class UniversityContext : DbContext 
    {

        public DbSet<StudentsModel> Students { get; set; }
        public DbSet<ClassModel> Classes { get; set; }

        public UniversityContext(DbContextOptions<UniversityContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Enrollment>()
                .HasKey(s => new { s.StudentID, s.ClassID });

            modelBuilder.Entity<Enrollment>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.Enrollment)
                .HasForeignKey(sc => sc.StudentID);

            modelBuilder.Entity<Enrollment>()
                .HasOne(cc => cc.Class)
                .WithMany(c => c.Enrollment)
                .HasForeignKey(cc => cc.ClassID);

            modelBuilder.Entity<StudentsModel>().ToTable("Student");
            modelBuilder.Entity<ClassModel>().ToTable("Class");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            

        }
    }
}
