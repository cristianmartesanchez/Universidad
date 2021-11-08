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
        Task<int> CommitAsync();
    }
}
