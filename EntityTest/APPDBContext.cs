using EntityTest.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTest
{
    internal class APPDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Connectios.source);
        }
        public DbSet<Student> students { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Grade> grades { get; set; }
        public DbSet<Book> books { get; set; }
        public DbSet<StudentBook> studentBooks { get; set; }
        public DbSet<Attendance> attendances { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*
            modelBuilder.Entity<Department>()
                .HasMany(p => p.students)
                .WithOne(c => c.department)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Student>()
                .HasOne(c => c.grade)
                .WithOne(m => m.student)
                .OnDelete(DeleteBehavior.SetNull);
            */
           // modelBuilder.Entity<Attendance>();

            foreach (var relationships in modelBuilder.Model.GetEntityTypes()
                .SelectMany (a => a.GetForeignKeys()))
            {
                relationships.DeleteBehavior = DeleteBehavior.Restrict;
            }
           // modelBuilder.Ignore<Attendance>();
           modelBuilder.Entity<Attendance>().ToTable("tablename","tablescheme"); 
        }
    }
}
