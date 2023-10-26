using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_DTO.DTOs
{
      
    
        public class ItemToCategoryDto
    {
            public int ItemToCategoryId { get; set; }
          //  public ItemsDto Items { get; set; }
            public string ItemsName { get; set; 
        }

        public CategoriesDto Categories { get; set; }
            public int Score { get; set; }
            public bool IsPrivate { get; set; }
            public UsersDto? Users { get; set; }

        }
}
