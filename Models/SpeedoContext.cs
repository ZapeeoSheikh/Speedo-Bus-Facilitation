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

        DbSet<Bus_Attendent> attendent { get; set; }
        DbSet<Bus_Card> card { get; set; }
        DbSet<Bus_Stop> busStop { get; set; }
        DbSet<Stop> stop { get; set; }
        DbSet<Bus> bus { get; set; }
        DbSet<Direction> direction { get; set; }
        DbSet<Driver> driver { get; set; }
        DbSet<Jobs> jobs { get; set; }
        DbSet<Line> line { get; set; }
        DbSet<Passenger> passenger { get; set; }
        DbSet<Route> routes { get; set; }
        DbSet<Token> token { get; set; }
    }
}