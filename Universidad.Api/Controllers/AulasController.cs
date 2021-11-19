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
    public class AulasController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AulasController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<AulaDto>> GetAsync()
        {
            var data = await _unitOfWork.Aula.GetAllAsync();
            var aulas = _mapper.Map<IEnumerable<AulaDto>>(data);
            return aulas;
        }

        [HttpGet("{id}")]
        public async Task<AulaDto> GetAsync(int id)
        {
            var data = await _unitOfWork.Aula.GetByIdAsync(id);
            var aula = _mapper.Map<AulaDto>(data);
            return aula;
        }

        [HttpPost]
        public async Task<AulaDto> PostAsync(AulaDto model)
        {
            if (ModelState.IsValid)
            {
                var data = _mapper.Map<Aula>(model);
                await _unitOfWork.Aula.AddAsync(data);
                int result = await _unitOfWork.CommitAsync();
                var aula = _mapper.Map<AulaDto>(data);

                return aula;
            }

            return model;
        }

        [HttpPut]
        public async Task<AulaDto> PutAsync(AulaDto model)
        {
            if (ModelState.IsValid)
            {
                var data = await _unitOfWork.Aula.GetByIdAsync(model.Id);
                //Tambien se podria mapear directamente con el mapper
                data.Nombre = model.Nombre;
                data.Capasidad = model.Capasidad;

                _unitOfWork.Aula.Update(data);
                //int result = await _unitOfWork.CommitAsync(); // por que el int?
                await _unitOfWork.CommitAsync();

                var aula = _mapper.Map<AulaDto>(data);

                return aula;
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