using AutoMapper;
using eTraining.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TreningRS2.WebAPI.Mappers
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<ApplicationUser, Models.ApplicationUser.ApplicationUser>()
                .ForMember(x => x.Opcina, y => y.MapFrom(src => src.Opcina.Naziv));
            CreateMap<ApplicationUser, Models.ApplicationUser.ApplicationUserInsert>().ReverseMap();
            CreateMap<Opcina, Models.Općina.OpcinaModel>().ReverseMap();
            CreateMap<Trening, Models.Trening.TreningModel>().ReverseMap();
            CreateMap<Trening, Models.Trening.TreningModelSearch>().ReverseMap();




        }
    }
}
