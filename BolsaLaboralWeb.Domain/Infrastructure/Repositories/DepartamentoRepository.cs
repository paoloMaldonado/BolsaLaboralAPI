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
    public class DepartamentoRepository : IDepartamentoRepository
    {
        private readonly Bolsa_LaboralContext _context;

        public DepartamentoRepository(Bolsa_LaboralContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Departamento>> GetDepartamento()
        {
            return await _context.Departamento.ToListAsync();
        }

        public async Task<Departamento> GetDepartamentoById(int id)
        {
            return await _context.Departamento.Where(x => x.IdDepartamento == id).FirstOrDefaultAsync();
        }


    }
}
