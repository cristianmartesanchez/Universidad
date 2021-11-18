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

            CreateMap<Estudio, EstudioDto>();
            CreateMap<EstudioDto, Estudio>();

            CreateMap<Alumno, AlumnoDto>();
            CreateMap<AlumnoDto, Alumno>();

            CreateMap<Profesor, ProfesorDto>();
            CreateMap<ProfesorDto, Profesor>();

            CreateMap<Aula, AulaDto>();
            CreateMap<AulaDto, Aula>();

            CreateMap<Asignatura, AsignaturaDto>();
            CreateMap<AsignaturaDto, Asignatura>();
        }
    }
}
