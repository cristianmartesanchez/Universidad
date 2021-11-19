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
    public class AsignaturasController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AsignaturasController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<AsignaturaDto>> GetAsync()
        {
            var data = await _unitOfWork.Asignatura.GetAllAsync();
            var asignaturas = _mapper.Map<IEnumerable<AsignaturaDto>>(data);
            return asignaturas;
        }

        [HttpGet("{id}")]
        public async Task<AsignaturaDto> GetAsync(int id)
        {
            var data = await _unitOfWork.Asignatura.GetByIdAsync(id);
            var asignatura = _mapper.Map<AsignaturaDto>(data);
            return asignatura;
        }

        [HttpPost]
        public async Task<AsignaturaDto> PostAsync(AsignaturaDto model)
        {
            if (ModelState.IsValid)
            {
                var data = _mapper.Map<Asignatura>(model);
                await _unitOfWork.Asignatura.AddAsync(data);
                int result = await _unitOfWork.CommitAsync();
                var asignatura = _mapper.Map<AsignaturaDto>(data);

                return asignatura;
            }

            return model;
        }

        [HttpPut]
        public async Task<AsignaturaDto> PutAsync(AsignaturaDto model)
        {
            if (ModelState.IsValid)
            {
                var data = await _unitOfWork.Asignatura.GetByIdAsync(model.Id);
                //Tambien se podria mapear directamente con el mapper
                data.Nombre = model.Nombre;
                data.Codigo = model.Codigo;
                data.ProfesorId = model.ProfesorId;
                data.TipoId = model.TipoId;
                data.Creditos = model.Creditos;

                _unitOfWork.Asignatura.Update(data);
                //int result = await _unitOfWork.CommitAsync(); // por que el int?
                await _unitOfWork.CommitAsync();

                var asignatura = _mapper.Map<AsignaturaDto>(data);

                return asignatura;
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