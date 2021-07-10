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
    public class HojaVidaCvRepository : IHojaVidaCvRepository
    {
        private readonly Bolsa_LaboralContext _context;

        public HojaVidaCvRepository(Bolsa_LaboralContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<HojaVidaCv>> GetHojaVidaCv()
        {
            return await _context.HojaVidaCv.ToListAsync();
        }

        public async Task<HojaVidaCv> GetHojaVidaCvById(int id)
        {
            return await _context.HojaVidaCv.Where(x => x.IdHojaVida == id).FirstOrDefaultAsync();
        }

        public async Task InsertHojaVidaCv(HojaVidaCv HojaVidaCv)
        {
            _context.HojaVidaCv.Add(HojaVidaCv);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdateHojaVidaCv(HojaVidaCv HojaVidaCv)
        {
            var HojaVidaCvNow = await _context.HojaVidaCv
                                .Where(x => x.IdHojaVida == HojaVidaCv.IdHojaVida).FirstOrDefaultAsync();


            HojaVidaCvNow.GradoInstruccion = HojaVidaCv.GradoInstruccion;
            HojaVidaCvNow.IdEspecialidad1 = HojaVidaCv.IdEspecialidad1;
            HojaVidaCvNow.FechaIniEstudio = HojaVidaCv.FechaIniEstudio;
            HojaVidaCvNow.FechaFinJob = HojaVidaCv.FechaFinJob;
            HojaVidaCvNow.IdNivelExperiencia2 = HojaVidaCv.IdNivelExperiencia2;
            HojaVidaCvNow.NivelIngles = HojaVidaCv.NivelIngles;
            HojaVidaCvNow.ExamenInter = HojaVidaCv.ExamenInter;
            HojaVidaCvNow.TieneTrabajo = HojaVidaCv.TieneTrabajo;
            HojaVidaCvNow.BuscaTrabajo = HojaVidaCv.BuscaTrabajo;
            HojaVidaCvNow.AnioExp = HojaVidaCv.AnioExp;
            HojaVidaCvNow.IdPuestoPref = HojaVidaCv.IdPuestoPref;
            HojaVidaCvNow.ObjetivosMotivavion = HojaVidaCv.ObjetivosMotivavion;

            int countRows = await _context.SaveChangesAsync();

            return (countRows > 0);
        }

        public async Task<bool> DeleteHojaVidaCv(int id)
        {
            var HojaVidaCvNow = await _context.HojaVidaCv
                                .Where(x => x.IdHojaVida == id).FirstOrDefaultAsync();

            if (HojaVidaCvNow == null)
                return false;

            _context.HojaVidaCv.Remove(HojaVidaCvNow);

            int countRows = await _context.SaveChangesAsync();
            return (countRows > 0);
        }
    }
}
