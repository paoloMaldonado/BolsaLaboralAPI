using BolsaLaboralWeb.Domain.Core.Entities;
using BolsaLaboralWeb.Domain.Core.Interfaces;
using BolsaLaboralWeb.Domain.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaLaboralWeb.Domain.Infrastructure.Repositories
{
    public class EspecialidadRepository : IEspecialidadRepository
    {

        private readonly Bolsa_LaboralContext _context;

        public EspecialidadRepository(Bolsa_LaboralContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Especialidad>> GetEspecialidad()
        {
            return await _context.Especialidad.ToListAsync();
        }

        public async Task<Especialidad> GetEspecialidadById(int id)
        {
            return await _context.Especialidad.Where(x => x.IdEspecialidad == id).FirstOrDefaultAsync();
        }

    }
}
