using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Universidad.Core.Dtos;
using Universidad.Core.Models;
using Universidad.Data;

namespace Universidad.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnosController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWord;
        private readonly IMapper _mapper;
        public AlumnosController(IUnitOfWork unitOfWord, IMapper mapper)
        {
            _unitOfWord = unitOfWord;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<AlumnoDto>> GetAsync()
        {
            var data = await _unitOfWord.Alumno.GetAllAsync();
            var Alumnos = _mapper.Map<IEnumerable<AlumnoDto>>(data);
            return Alumnos;
        }

        [HttpGet("{id}")]
        public async Task<AlumnoDto> GetAsync(int id)
        {
            var data = await _unitOfWord.Alumno.GetByIdAsync(id);
            var alumno = _mapper.Map<AlumnoDto>(data);
            return alumno;
        }

        [HttpPost]
        public async Task<AlumnoDto> PostAsync(AlumnoDto model)
        {
            if (ModelState.IsValid)
            {
                var data = _mapper.Map<Alumno>(model);
                await _unitOfWord.Alumno.AddAsync(data);
                int result = await _unitOfWord.CommitAsync();
                var carrera = _mapper.Map<AlumnoDto>(data);

                return carrera;
            }

            return model;
        }

        [HttpPut]
        public async Task<AlumnoDto> PutAsync(AlumnoDto model)
        {
            if (ModelState.IsValid)
            {
                var data = await _unitOfWord.Alumno.GetByIdAsync(model.Id);

                data.Nombre = model.Nombre;
                data.Matricula = model.Matricula;
                data.Apellido = model.Apellido;
                data.FechaNacimiento = model.FechaNacimiento;

                _unitOfWord.Alumno.Update(data);
                int result = await _unitOfWord.CommitAsync();

                var alumno = _mapper.Map<AlumnoDto>(data);

                return alumno;
            }

            return model;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            //TODO: this
        }
    }
}