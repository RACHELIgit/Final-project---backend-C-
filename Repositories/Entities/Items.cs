//using Humanizer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Entities
{
    public class Items
    {
       
        public int ItemsId { get; set; }

        public string ItemseName { get; set; } = null!;

        public bool IsPrivate { get; set; }
        public string ItemsImg { get; set; }
        public int? Weight { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual AgeGroup AgeGroup { get; set; }
        public virtual Occupation Occupation { get; set; }
        public virtual DbSet<ItemToCategory> ItemToCategoriel { get; set; }
        public virtual DbSet<ItemTravelToUser> ItemTravelToUserl { get; set; }

    }
    public class Categories
    {
        public int CategoriesId { get; set; }
        public string CategoriesName { get; set; }
        public bool CategoriesByUser { get; set; }
        public virtual DbSet<ItemToCategory> ItemToCategoriel { get; set; }

    }
    public class ItemToCategory
    {
        public int ItemToCategoryId { get; set; }
        public virtual Items Items { get; set; }
        public virtual Categories  Categories { get; set; }
        public int Score { get; set; }
        public bool IsPrivate { get; set; }
        public virtual Users? Users { get; set; }

    }
    public class Users
    {
        public int UsersId { get; set; }
        public string UsersName { get; set; }
        public string UserPess { get; set; }
        // מגדר 
        public virtual Gender? Gender { get; set; }
        // מגזר
        public virtual Sector? Sector { get; set; }
        // תחום עיסוק 
        public virtual Occupation? Occupation { get; set; }
        public string UserEmail { get; set; }
        public string UserPhon { get; set; }
        public virtual DbSet<ItemToCategory> ItemToCategoriel { get; set; }
        public virtual DbSet<TravelToUser> TravelToUserl { get; set; }




    }
    public class TravelToUser
    {
        public int TravelToUserId { get; set; }

        public DateTime TravelToUserDate { get; set; }

        public virtual Users Users { get; set; }

        public string TravelToUserName { get; set; }

        public virtual ReasonTravel ReasonTravel { get; set; }
        public virtual TimeTravel TimeTravel { get; set; }

        public string Descriebe { get; set; }
        public int? MaxWeight { get; set; }
        public virtual DbSet<ItemTravelToUser> ItemTravelToUserl { get; set; }




    }
    public class ItemTravelToUser
    {
        public int ItemTravelToUserId { get; set; }
        public virtual TravelToUser TravelToUser { get; set; }

        public virtual Items Items { get; set; }
        public int Amount { get; set; }
        public string Note { get; set; }

        public bool DidTake { get; set; }

        public bool Reminder { get; set; }

        public DateTime? ReminderDeatiles { get; set; }



    }
    //קבוצת גיל
    public class AgeGroup
    {
        public int AgeGroupId { get; set; }
        public string AgeGroupName { get; set; }
        public virtual DbSet<Items> Itemsl { get; set; }
        public virtual DbSet<Users> Usersl { get; set; }



    }
    //מגזר
    public class Sector
    { 
        public int SectorId { get; set; }
        public string SectorName { get; set;}
        public virtual DbSet<Items> Itemsl { get; set; }
        public virtual DbSet<Users> Usersl { get; set; }


    }
    //תחום עיסוק
    public class Occupation
    {
        public int OccupationId { get; set; }
        public string OccupationName { get; set; }
        public virtual DbSet<Items> Itemsl { get; set; }
        public virtual DbSet<Users> Usersl { get; }

    }
    //מגדר זכר.. 
    public class Gender 
    { 
        public int GenderId { get; set;}
        public string GenderName { get; set;}
        public virtual DbSet<Items> Itemsl { get; set; }
        public virtual DbSet<Users> Usersl { get; set; }
    }
    //סיבת נסיעה
    public class ReasonTravel 
    {
        public int ReasonTravelId { get; set; }
        public string ReasonTravelName { get; set; }
        public virtual DbSet<TravelToUser> TravelToUserl { get; set; }
    }
    //זמן נסיעה
    public class TimeTravel 
    { 
        public int TimeTravelId { get; set;}
        public string TimeTravelName { get; set;}
        public virtual DbSet<TravelToUser> TravelToUserl { get; set; }



    }
}
