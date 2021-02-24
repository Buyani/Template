using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Template.Core.Entities;

namespace Template.Data
{
    public class MatricExcellenceDbContext : IdentityDbContext
    {

        public MatricExcellenceDbContext()
        {
        }

        public MatricExcellenceDbContext(DbContextOptions<MatricExcellenceDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollement> StudentSubjects { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<School> FormerSchools { get; set; }
        public DbSet<Payment> Payments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

    }
}
