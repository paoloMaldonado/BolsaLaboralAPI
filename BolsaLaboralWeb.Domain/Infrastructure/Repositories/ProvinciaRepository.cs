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
    public class ProvinciaRepository : IProvinciaRepository
    {
        private readonly Bolsa_LaboralContext _context;

        public ProvinciaRepository(Bolsa_LaboralContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Provincia>> GetProvincia()
        {
            return await _context.Provincia.ToListAsync();
        }

        public async Task<IEnumerable<Provincia>> GetProvinciasByDepaId(int id)
        {
            return await _context.Provincia.Where(x => x.IdDepartamento1 == id).ToListAsync();
        }
    }
}
