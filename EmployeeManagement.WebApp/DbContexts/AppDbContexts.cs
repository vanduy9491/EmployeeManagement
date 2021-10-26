
using EmployeeManagement.WebApp.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.WebApp.DbContexts
{
    public class AppDbContexts : IdentityDbContext<AppIdentityUser>
    {
        public AppDbContexts(DbContextOptions<AppDbContexts> options) : base(options)
        {

        }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}
