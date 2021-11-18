using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidad.Core.Repositories;

namespace Universidad.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;
        private UniversidadRepository _universidadRepository;
        private EstudioRepository _carreraRepository;
        private AlumnoRepository _alumnoRepository;
        private ProfesorRepository _profesorRepository;

        public UnitOfWork(DataContext context)
        {
            this._context = context;
        }

        public IUniversidadRepository Universidad => _universidadRepository = _universidadRepository ?? new UniversidadRepository(_context);
        public IEstudioRepository Carrera => _carreraRepository = _carreraRepository ?? new EstudioRepository(_context);
        public IAlumnoRepository Alumno => _alumnoRepository = _alumnoRepository ?? new AlumnoRepository(_context);
        public IProfesorRepository Profesor => _profesorRepository = _profesorRepository ?? new ProfesorRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
