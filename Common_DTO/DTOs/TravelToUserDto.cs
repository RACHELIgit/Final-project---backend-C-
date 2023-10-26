using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_DTO.DTOs
{
    public class TravelToUserDto
    {
        public int TravelToUserId { get; set; }

        public DateTime TravelToUserDate { get; set; }

        public UsersDto Users { get; set; }

        public string TravelToUserName { get; set; }

        public ReasonTravelDto ReasonTravel { get; set; }
        public TimeTravelDto TimeTravel { get; set; }

        public string Descriebe { get; set; }
        public int? MaxWeight { get; set; }


    }
}
