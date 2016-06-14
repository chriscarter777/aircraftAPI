using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AircraftAPI.Models;
using System.Data.Entity;


namespace AircraftAPI.DAL
{
    public class AircraftDbContext : DbContext
    {
        public DbSet<Aircraft> Aircraft { get; set; }
    }
}