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

PM> Update-Database
Build started...
Build succeeded.
fail: Microsoft.EntityFrameworkCore.Database.Command[20102]
      Failed executing DbCommand (24ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT "MigrationId", "ProductVersion"
      FROM "__EFMigrationsHistory"
      ORDER BY "MigrationId";
Failed executing DbCommand (24ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
SELECT "MigrationId", "ProductVersion"
FROM "__EFMigrationsHistory"
ORDER BY "MigrationId";
Microsoft.EntityFrameworkCore.Migrations[20411]
      Acquiring an exclusive lock for migration application. See https://aka.ms/efcore-docs-migrations-lock for more information if this takes too long.
Acquiring an exclusive lock for migration application. See https://aka.ms/efcore-docs-migrations-lock for more information if this takes too long.
Microsoft.EntityFrameworkCore.Migrations[20402]
      Applying migration '20260306174726_InitialCreate'.
Applying migration '20260306174726_InitialCreate'.
Done.
