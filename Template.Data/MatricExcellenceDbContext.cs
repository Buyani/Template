using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Template.Core.Entities;

namespace Template.Data
{
    public class MatricExcellenceDbContext : IdentityDbContext<ApplicationUser>
    {

        public MatricExcellenceDbContext()
        {
        }

        public MatricExcellenceDbContext(DbContextOptions<MatricExcellenceDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<StudentSubject> StudentSubjects { get; set; }
        public DbSet<Guardian> Guradians { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<FormerSchool> FormerSchools { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

    }
}
