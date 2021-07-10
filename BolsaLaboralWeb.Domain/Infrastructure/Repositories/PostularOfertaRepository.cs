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
    public class PostularOfertaRepository : IPostularOfertaRepository
    {
        private readonly Bolsa_LaboralContext _context;

        public PostularOfertaRepository(Bolsa_LaboralContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PostularOferta>> GetPostularOferta()
        {
            return await _context.PostularOferta.ToListAsync();
        }

        public async Task<PostularOferta> GetPostularOfertaById(int id)
        {
            return await _context.PostularOferta.Where(x => x.IdPostular == id).FirstOrDefaultAsync();
        }

        public async Task InsertPostularOferta(PostularOferta postOferta)
        {
            _context.PostularOferta.Add(postOferta);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdatePostularOferta(PostularOferta postOferta)
        {
            var postOfertaNow = await _context.PostularOferta
                                .Where(x => x.IdPostular == postOferta.IdPostular).FirstOrDefaultAsync();


            postOfertaNow.FechaPostulacion = postOferta.FechaPostulacion;
            postOfertaNow.FechaFinalizado = postOferta.FechaFinalizado;
            postOfertaNow.CvAdjunto = postOferta.CvAdjunto;
            postOfertaNow.Estado = postOferta.Estado;

            int countRows = await _context.SaveChangesAsync();

            return (countRows > 0);
        }

        public async Task<bool> DeletePostularOferta(int id)
        {
            var postOfertaNow = await _context.PostularOferta
                                .Where(x => x.IdPostular == id).FirstOrDefaultAsync();

            if (postOfertaNow == null)
                return false;

            _context.PostularOferta.Remove(postOfertaNow);

            int countRows = await _context.SaveChangesAsync();
            return (countRows > 0);
        }
    }
}
