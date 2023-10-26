using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Entities;
using System;

namespace Context_dal
{
    public class TravelOrganizationContext : DbContext, IContext
    {
        public TravelOrganizationContext() { }
        public TravelOrganizationContext(DbContextOptions<TravelOrganizationContext> options)
         : base(options)
        { }
        public DbSet<Items> Items { get ; set ; }
        public DbSet<Categories> Categories { get ; set ; }
        public DbSet<ItemToCategory> ItemToCategory { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<TravelToUser> TravelToUser { get; set; }
        public DbSet<ItemTravelToUser> ItemTravelToUser { get; set; }
        public DbSet<AgeGroup> AgeGroup { get; set; }
        public DbSet<Sector> Sector { get; set; }
        public DbSet<Occupation> Occupation { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<ReasonTravel> ReasonTravel { get; set; }
        public DbSet<TimeTravel> TimeTravel { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(@"server=DESKTOP-FN0Q6EQ\SQLEXPRESS03;database=newTravelOrganization;trusted_Connection=True;TrustServerCertificate=True");
    }


}