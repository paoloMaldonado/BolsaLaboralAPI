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
    public class PostulanteRepository : IPostulanteRepository
    {
        private readonly Bolsa_LaboralContext _context;

        public PostulanteRepository(Bolsa_LaboralContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Postulante>> GetPostulante()
        {
            return await _context.Postulante.ToListAsync();
        }

        public async Task<Postulante> GetPostulanteById(int id)
        {
            return await _context.Postulante.Where(x => x.IdPostulante == id).FirstOrDefaultAsync();
        }

        public async Task InsertPostulante(Postulante postulante)
        {
            _context.Postulante.Add(postulante);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdatePostulante(Postulante postulante)
        {
            var postulanteNow = await _context.Postulante
                                .Where(x => x.IdPostulante == postulante.IdPostulante).FirstOrDefaultAsync();


            postulanteNow.Nombre = postulante.Nombre;
            postulanteNow.Apellido = postulante.Apellido;
            postulanteNow.Email = postulante.Email;
            postulanteNow.Password = postulante.Password;
            postulanteNow.Genero = postulante.Genero;
            postulanteNow.FechaNacimiento = postulante.FechaNacimiento;
            postulanteNow.Telefono = postulante.Telefono;
            postulanteNow.ZipCode = postulante.ZipCode;
            postulanteNow.Estado = postulante.Estado;

            int countRows = await _context.SaveChangesAsync();

            return (countRows > 0);
        }

        public async Task<bool> DeletePostulante(int id)
        {
            var postulanteNow = await _context.Postulante
                                .Where(x => x.IdPostulante == id).FirstOrDefaultAsync();

            if (postulanteNow == null)
                return false;

            _context.Postulante.Remove(postulanteNow);

            int countRows = await _context.SaveChangesAsync();
            return (countRows > 0);
        }
    }
}
