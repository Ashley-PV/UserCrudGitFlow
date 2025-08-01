using System.Collections.Generic;
using UserCRUD.Models;
using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;

namespace UserCRUD.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
