using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_DTO.DTOs
{
    public class ItemTravelToUserDto
    {
        public int ItemTravelToUserId { get; set; }
        public TravelToUserDto TravelToUser { get; set; }

        public ItemsDto Items { get; set; }
        public int Amount { get; set; }
        public string Note { get; set; }

        public bool DidTake { get; set; }

        public bool Reminder { get; set; }

        public DateTime? ReminderDeatiles { get; set; }



    }
}
