using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_DTO.DTOs
{
    public class ItemsDto
    {

        public int ItemsId { get; set; }

        public string ItemseName { get; set; } = null!;

        public bool IsPrivate { get; set; }
        public string ItemsImg { get; set; }
        public int? Weight { get; set; }
        public GenderDto Gender { get; set; }
        public AgeGroupDto AgeGroup { get; set; }
        public OccupationDto Occupation { get; set; }


    }
}
