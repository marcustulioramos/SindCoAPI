using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
using SindCoAPI.Models;

namespace SindCoAPI.Data
{
    public class SindcoDbContext : IdentityDbContext
    {
        public SindcoDbContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<Complex> Complexes { get; set; }
        public DbSet<Block > Blocks { get; set; }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Apartment> Apartments { get; set; }
        
    }
}