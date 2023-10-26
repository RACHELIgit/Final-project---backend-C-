using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories.Entities;

namespace Repositories
{
    public interface IContext
    {
        DbSet<Items> Items { get; set; } 
        DbSet<Categories> Categories { get; set;}
        DbSet<ItemToCategory> ItemToCategory { get; set; }
        DbSet<Users> Users { get; set; }
        DbSet<TravelToUser> TravelToUser { get; set; }
        DbSet<ItemTravelToUser> ItemTravelToUser { get; set; }
        DbSet<AgeGroup> AgeGroup { get; set; }
        DbSet<Sector> Sector { get; set; }
        DbSet<Occupation> Occupation { get; set; }
        DbSet<Gender> Gender { get; set; }
        DbSet<ReasonTravel> ReasonTravel { get; set; }
        DbSet<TimeTravel> TimeTravel { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
