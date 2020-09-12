using AutoMapper;
using backend_project.Dtos;
using backend_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend_project.Helpers
{
    public class AutotMapperProfiles : Profile
    {
        public AutotMapperProfiles()
        {
            CreateMap<User, UserForListDto>().
                ForMember(dest=>dest.PictureUrl,
                opt => opt.MapFrom(src=> src.picture.url))
                .ForMember(dest => dest.Age,
                opt => opt.MapFrom(src => src.BirthDate.CalculateAge()));
        }
    }
}
