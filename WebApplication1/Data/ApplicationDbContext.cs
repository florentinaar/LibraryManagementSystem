using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        internal object Customers;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<WebApplication1.Models.ProjectRole> ProjectRole { get; set; }
        public DbSet<WebApplication1.Models.Author> Author { get; set; }
        public DbSet<WebApplication1.Models.Book> Book { get; set; }
        public DbSet<WebApplication1.Models.Customer> Customer { get; set; }
    }
}
