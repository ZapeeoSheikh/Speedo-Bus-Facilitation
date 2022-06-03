using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Speedo_Bus_Facilitation.Models
{

    public class SpeedoContext : DbContext
    {
        public SpeedoContext() : base("ConnectionString")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }

        public DbSet<BusAttendent> attendent { get; set; }
        public DbSet<BusCard> card { get; set; }
        public DbSet<BusStop> busStop { get; set; }
        public DbSet<Depot> depot { get; set; }
        public DbSet<Role> role { get; set; }
        public DbSet<Stop> stop { get; set; }
        public DbSet<Bus> bus { get; set; }
        public DbSet<Direction> direction { get; set; }
        public DbSet<Driver> driver { get; set; }
        public DbSet<Jobs> jobs { get; set; }
        public DbSet<Line> line { get; set; }
        public DbSet<Passenger> passenger { get; set; }
        public DbSet<Route> routes { get; set; }
        public DbSet<Token> token { get; set; }
        public DbSet<BalanceHistory> balance { get; set; }
    }
}