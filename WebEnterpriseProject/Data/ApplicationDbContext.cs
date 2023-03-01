using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebEnterpriseProject.Models;

namespace WebEnterpriseProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Post> Post { get; set; }
        public DbSet<Department> Category { get; set; }
        public DbSet<Comment> Department { get; set; }
        public DbSet<Category> User { get; set; }
        public DbSet<User> Comment { get; set; }

    }
}

