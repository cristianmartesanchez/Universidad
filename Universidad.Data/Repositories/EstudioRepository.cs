using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidad.Core.Models;
using Universidad.Data;
using Universidad.Data.Repositories;

namespace Universidad.Core.Repositories
{

    public interface IEstudioRepository : IRepository<Carreras>
    {

    }

    public class EstudioRepository : Repository<Carreras>, IEstudioRepository
    {
        private readonly DataContext _context;
        public EstudioRepository(DataContext context): base(context)
        {
            _context = context;
        }
    }
}
