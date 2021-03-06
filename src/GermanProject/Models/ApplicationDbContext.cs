﻿using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;

namespace GermanProject.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<VocabWord> VocabWords { get; set; }
        public DbSet<Result> Results { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}