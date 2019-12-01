using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;

namespace SportsStore.Models
{
    public class AppLoyaltyDbContext: DbContext
    {
        public AppLoyaltyDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Patron> Patrons { get; set; }

    }
}
