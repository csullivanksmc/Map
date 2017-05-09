using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using spotter.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace spotter.DAL
{
    
        public class SpotContext : DbContext
        {
            public SpotContext() : base("SpotContext")
            {

            }

            public DbSet<Spot> Spots { get; set; }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            }
        }
  
}