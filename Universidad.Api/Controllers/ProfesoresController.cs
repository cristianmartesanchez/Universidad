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
    public class ProfesoresController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProfesoresController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<ProfesorDto>> GetAsync()
        {
            var data = await _unitOfWork.Profesor.GetAllAsync();
            var profesores = _mapper.Map<IEnumerable<ProfesorDto>>(data);
            return profesores;
        }

        [HttpGet("{id}")]
        public async Task<ProfesorDto> GetAsync(int id)
        {
            var data = await _unitOfWork.Profesor.GetByIdAsync(id);
            var profesor = _mapper.Map<ProfesorDto>(data);
            return profesor;
        }

        [HttpPost]
        public async Task<ProfesorDto> PostAsync(ProfesorDto model)
        {
            if (ModelState.IsValid)
            {
                var data = _mapper.Map<Profesor>(model);
                await _unitOfWork.Profesor.AddAsync(data);
                int result = await _unitOfWork.CommitAsync();
                var profesor = _mapper.Map<ProfesorDto>(data);

                return profesor;
            }

            return model;
        }

        [HttpPut]
        public async Task<ProfesorDto> PutAsync(ProfesorDto model)
        {
            if (ModelState.IsValid)
            {
                var data = await _unitOfWork.Profesor.GetByIdAsync(model.Id);
                //Tambien se podria mapear directamente con el mapper
                data.Nombre = model.Nombre;
                data.Codigo = model.Codigo;
                data.Apellido = model.Apellido;
                data.Titulo = model.Titulo;

                _unitOfWork.Profesor.Update(data);
                //int result = await _unitOfWork.CommitAsync(); // por que el int?
                await _unitOfWork.CommitAsync();

                var profesor = _mapper.Map<ProfesorDto>(data);

                return profesor;
            }

            return model;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}