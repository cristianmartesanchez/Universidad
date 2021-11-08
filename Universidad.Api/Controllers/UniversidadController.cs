using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Universidad.Core.Dtos;
using Universidad.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Universidad.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UniversidadController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWord;
        private readonly IMapper _mapper;
        public UniversidadController(IUnitOfWork unitOfWord, IMapper mapper)
        {
            _unitOfWord = unitOfWord;
            _mapper = mapper;
        }

        // GET: api/<UniversidadController>
        [HttpGet]
        public async Task<IEnumerable<UniversidadDto>> GetAsync()
        {
            var data = await _unitOfWord.Universidad.GetAllAsync();
            var universidades = _mapper.Map<IEnumerable<UniversidadDto>>(data);
            return universidades;
        }

        // GET api/<UniversidadController>/5
        [HttpGet("{id}")]
        public async Task<UniversidadDto> GetAsync(int id)
        {
            var data = await _unitOfWord.Universidad.GetByIdAsync(id);
            var universidad = _mapper.Map<UniversidadDto>(data);
            return universidad;
        }

        // POST api/<UniversidadController>
        [HttpPost]
        public async Task<UniversidadDto> PostAsync(UniversidadDto model)
        {
            if (ModelState.IsValid)
            {
                var data = _mapper.Map<Core.Models.Universidad>(model);
                await _unitOfWord.Universidad.AddAsync(data);
                int result = await _unitOfWord.CommitAsync();
                var universidad = _mapper.Map<UniversidadDto>(data);

                return universidad;
            }

            return model;
        }

        // PUT api/<UniversidadController>/5
        [HttpPut]
        public async Task<UniversidadDto> PutAsync(UniversidadDto model)
        {
            if (ModelState.IsValid)
            {
                var data = await _unitOfWord.Universidad.GetByIdAsync(model.Id);

                data.Nombre = model.Nombre;
                data.Telefono = model.Telefono;
                data.Direccion = model.Direccion;

                 _unitOfWord.Universidad.Update(data);
                int result = await _unitOfWord.CommitAsync();

                var universidad = _mapper.Map<UniversidadDto>(data);

                return universidad;
            }

            return model;
        }

        // DELETE api/<UniversidadController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
