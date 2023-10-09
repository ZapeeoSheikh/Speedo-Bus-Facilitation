using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Speedo_Bus_Facilitation.Models
{

    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("ConnectionString")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }

        public DbSet<Bus> Bus { get; set; }
        public DbSet<BusAttendent> BusAttendent { get; set; }
        public DbSet<BusCard> BusCard { get; set; }
        public DbSet<BusStop> BusStop { get; set; }
       public DbSet<HomeRoutes> HomeRoutes { get; set; }
        public DbSet<Depot> Depot { get; set; }
        public DbSet<Role> role { get; set; }
        ////public DbSet<BusStop> BusBusStops { get; set; }

        public DbSet<Direction> Direction { get; set; }
        public DbSet<Driver> Driver { get; set; }
        public DbSet<Jobs> Jobs { get; set; }
        public DbSet<Line> Line { get; set; }
        public DbSet<Passenger> Passenger { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Token> Token { get; set; }
        public DbSet<BalanceHistory> BalanceHistory { get; set; }
    }
}