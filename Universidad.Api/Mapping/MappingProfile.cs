using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Universidad.Core.Dtos;
using Universidad.Core.Models;

namespace Universidad.Api.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Core.Models.Universidad, UniversidadDto>();
            CreateMap<UniversidadDto, Core.Models.Universidad>();

            CreateMap<Carreras, CarrerasDto>();
            CreateMap<CarrerasDto, Carreras>();
        }
    }
}
