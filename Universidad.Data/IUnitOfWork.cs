using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidad.Core.Repositories;

namespace Universidad.Data
{
    public interface IUnitOfWork : IDisposable
    {
        IUniversidadRepository Universidad { get; }
        IEstudioRepository Carrera { get; }
        IAlumnoRepository Alumno { get; }
        IProfesorRepository Profesor { get; }
        IAulaRepository Aula { get; }
        Task<int> CommitAsync();
    }
}
