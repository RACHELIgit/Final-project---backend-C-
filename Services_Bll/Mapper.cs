using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Repositories.Entities;
using Common_DTO.DTOs;
namespace Services_Bll
{
    public class Mapper:Profile
    {
        public Mapper()
        {

            CreateMap<UsersDto,Users>().ReverseMap()
                //.ForMember(dest => dest.GenderName,
                // opt => opt.MapFrom(src => src.Gender.GenderName))
               // .ForMember(dest => dest.SectorName,
               //  opt => opt.MapFrom(src => src.Sector.SectorName))
                .ForMember(dest => dest.OccupationName,
                 opt => opt.MapFrom(src => src.Occupation.OccupationName))

                ; 

        }
    }
}
