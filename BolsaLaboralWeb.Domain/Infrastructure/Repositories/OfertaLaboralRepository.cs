using BolsaLaboralWeb.Domain.Core.Entities;
using BolsaLaboralWeb.Domain.Core.Interfaces;
using BolsaLaboralWeb.Domain.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaLaboralWeb.Domain.Core.Interfaces
{
    public class OfertaLaboralRepository : IOfertaLaboralRepository
    {
        private readonly Bolsa_LaboralContext _context;

        public OfertaLaboralRepository(Bolsa_LaboralContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<OfertaLaboral>> GetOfertaLaboral()
        {
            return await _context.OfertaLaboral.ToListAsync();
        }

        public async Task<OfertaLaboral> GetOfertaLaboralById(int id)
        {
            return await _context.OfertaLaboral.Where(x => x.IdOferta == id).FirstOrDefaultAsync();
        }

        public async Task InsertOfertaLaboral(OfertaLaboral ofertaLab)
        {
            _context.OfertaLaboral.Add(ofertaLab);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdateOfertaLaboral(OfertaLaboral ofertaLab)
        {
            var ofertaLabNow = await _context.OfertaLaboral
                                .Where(x => x.IdOferta == ofertaLab.IdOferta).FirstOrDefaultAsync();


            ofertaLabNow.Nombre = ofertaLab.Nombre;
            ofertaLabNow.FechaPublicacion = ofertaLab.FechaPublicacion;
            ofertaLabNow.FechaVencimiento = ofertaLab.FechaVencimiento;
            ofertaLabNow.Descripcion = ofertaLab.Descripcion;
            ofertaLabNow.Beneficios = ofertaLab.Beneficios;
            ofertaLabNow.Descripcion = ofertaLab.Descripcion;
            ofertaLabNow.Estado = ofertaLab.Estado;

            int countRows = await _context.SaveChangesAsync();

            return (countRows > 0);
        }

        public async Task<bool> DeleteOfertaLaboral(int id)
        {
            var ofertaLabNow = await _context.OfertaLaboral
                                .Where(x => x.IdOferta == id).FirstOrDefaultAsync();

            if (ofertaLabNow == null)
                return false;

            _context.OfertaLaboral.Remove(ofertaLabNow);

            int countRows = await _context.SaveChangesAsync();
            return (countRows > 0);
        }
    }
}
