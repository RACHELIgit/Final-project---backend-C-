using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_DTO.DTOs
{
    public class UsersDto
    {
        public int UsersId { get; set; }
        public string UsersName { get; set; }
        public string UserPess { get; set; }
        // מגדר 
       // public GenderDto? Gender { get; set; }
        public string? GenderName { get; set; }

        // מגזר
       // public SectorDto? Sector { get; set; }
        public string? SectorName { get; set; }

        // תחום עיסוק 
      //  public OccupationDto? Occupation { get; set; }
        public string? OccupationName { get; set; }

        public string UserEmail { get; set; }
        public string UserPhon { get; set; }
    }
}
