using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FootballCode.Models
{

    public class FootballContext : DbContext
    {
        public FootballContext() : base("DBCS")
        {

        }
        public DbSet<Football> Football { get; set; }
    }

}