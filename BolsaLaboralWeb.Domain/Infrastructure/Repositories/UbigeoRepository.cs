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
    public class UbigeoRepository : IUbigeoRepository
    {
        private readonly Bolsa_LaboralContext _context;

        public UbigeoRepository(Bolsa_LaboralContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Ubigeo>> GetUbigeo()
        {
            return await _context.Ubigeo.ToListAsync();
        }

        public async Task<IEnumerable<Ubigeo>> GetUbigeosByDepaId(int id)
        {
            return await _context.Ubigeo.Where(x => x.IdDepartamento3 == id).ToListAsync();
        }
        public async Task<IEnumerable<Ubigeo>> GetUbigeosByProvId(int id)
        {
            return await _context.Ubigeo.Where(x => x.IdProvincia2 == id).ToListAsync();
        }
    }
}
