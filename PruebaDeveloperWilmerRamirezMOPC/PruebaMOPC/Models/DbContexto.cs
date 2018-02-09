using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PruebaMOPC.Models
{
    public class DbContexto : DbContext
    {

        public DbContexto() : base("WilmerMOPC")
        {
           
        }

        public DbSet<MOPCData> MOPCData { get; set; }
    }
}