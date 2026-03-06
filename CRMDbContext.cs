using Microsoft.EntityFrameworkCore;
using CRMSystem.Models;

namespace CRMSystem.Data
{
    public class CRMDbContext : DbContext
    {
        public CRMDbContext(DbContextOptions<CRMDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Interaction> Interactions { get; set; }
    }
}
