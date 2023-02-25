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

        public DbSet<Post> Trainer { get; set; }
        public DbSet<Department> Assignments { get; set; }
        public DbSet<Comment> Enrollments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Courses { get; set; }

    }
}

