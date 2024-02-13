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
        protected override void  OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Connectios.source);
        }
        public DbSet<Student> students { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Grade> grades { get; set; }
        public DbSet<Book> books { get; set; }
        public DbSet<StudentBook> studentBooks { get; set; }
    }
}
