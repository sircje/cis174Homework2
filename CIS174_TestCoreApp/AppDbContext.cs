using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using CIS174_TestCoreApp.Models;
namespace CIS174_TestCoreApp
{
    public class AppDbContext : DbContext
    {


        public AppDbContext(DbContextOptions<AppDbContext> options)
: base(options) { }
        public DbSet<FamousPeople> FamousPeoples { get; set; }
        public DbSet<CIS174_TestCoreApp.Models.Achievements> Achievements { get; set; }
    }
   
}
