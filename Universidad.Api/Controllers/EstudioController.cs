using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Universidad.Core.Dtos;
using Universidad.Core.Models;
using Universidad.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Universidad.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudioController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWord;
        private readonly IMapper _mapper;
        public EstudioController(IUnitOfWork unitOfWord, IMapper mapper)
        {
            _unitOfWord = unitOfWord;
            _mapper = mapper;
        }

        // GET: api/<EstudioController>
        [HttpGet]
        public async Task<IEnumerable<CarrerasDto>> GetAsync()
        {
            var data = await _unitOfWord.Carrera.GetAllAsync();
            var carreras = _mapper.Map<IEnumerable<CarrerasDto>>(data);
            return carreras;
        }

        // GET api/<EstudioController>/5
        [HttpGet("{id}")]
        public async Task<CarrerasDto> GetAsync(int id)
        {
            var data = await _unitOfWord.Carrera.GetByIdAsync(id);
            var carrera = _mapper.Map<CarrerasDto>(data);
            return carrera;
        }

        // POST api/<EstudioController>
        [HttpPost]
        public async Task<CarrerasDto> PostAsync(CarrerasDto model)
        {
            if (ModelState.IsValid)
            {
                var data = _mapper.Map<Carreras>(model);
                await _unitOfWord.Carrera.AddAsync(data);
                int result = await _unitOfWord.CommitAsync();
                var carrera = _mapper.Map<CarrerasDto>(data);

                return carrera;
            }

            return model;
        }

        // PUT api/<EstudioController>/5
        [HttpPut]
        public async Task<CarrerasDto> PutAsync(CarrerasDto model)
        {
            if (ModelState.IsValid)
            {
                var data = await _unitOfWord.Carrera.GetByIdAsync(model.Id);

                data.Nombre = model.Nombre;
                data.Duracion = model.Duracion;
                data.TotalCredito = model.TotalCredito;

                _unitOfWord.Carrera.Update(data);
                int result = await _unitOfWord.CommitAsync();

                var carrera = _mapper.Map<CarrerasDto>(data);

                return carrera;
            }

            return model;
        }

        // DELETE api/<EstudioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
