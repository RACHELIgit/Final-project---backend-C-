using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 using AutoMapper;
using Common_DTO.DTOs;
using Repositories.Entities;

namespace Services_Bll

{
    public class UserProfilGender:Profile
    {
        public UserProfilGender()
        {

            CreateMap<Users, UsersDto>()
                 .ForMember(dest => dest.GenderName,
                 opt => opt.MapFrom(src => src.Gender.GenderName));
        }
    }

    public class UserProfilSector : Profile
    {
        public UserProfilSector()
        {

            CreateMap<Users, UsersDto>()
                 .ForMember(dest => dest.SectorName,
                 opt => opt.MapFrom(src => src.Sector.SectorName));
        }
    }

    public class UserProfilOccupation : Profile
    {
        public UserProfilOccupation()
        {

            CreateMap<Users, UsersDto>()
                 .ForMember(dest => dest.OccupationName,
                 opt => opt.MapFrom(src => src.Occupation.OccupationName));
        }
    }
}
