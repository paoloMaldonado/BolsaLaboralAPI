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
    public class NivelExperienciaRepository : INivelExperienciaRepository
    {
        private readonly Bolsa_LaboralContext _context;

        public NivelExperienciaRepository(Bolsa_LaboralContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<NivelExperiencia>> GetNivelExperiencia()
        {
            return await _context.NivelExperiencia.ToListAsync();
        }

    }

}

