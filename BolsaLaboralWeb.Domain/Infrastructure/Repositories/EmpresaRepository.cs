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
    public class EmpresaRepository : IEmpresaRepository
    {

        private readonly Bolsa_LaboralContext _context;

        public EmpresaRepository(Bolsa_LaboralContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Empresa>> GetEmpresa()
        {
            return await _context.Empresa.ToListAsync();
        }

        public async Task<Empresa> GetEmpresaById(int id)
        {
            return await _context.Empresa.Where(x => x.IdEmpresa == id).FirstOrDefaultAsync();
        }

        public async Task InsertEmpresa(Empresa empresa)
        {
            _context.Empresa.Add(empresa);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdateEmpresa(Empresa empresa)
        {
            var empresaNow = await _context.Empresa
                                .Where(x => x.IdEmpresa == empresa.IdEmpresa).FirstOrDefaultAsync();


            empresaNow.Email = empresa.Email;
            empresaNow.Password = empresa.Password;
            empresaNow.RazonSocial = empresa.RazonSocial;
            empresaNow.Ruc = empresa.Ruc;
            empresaNow.ReferenciaUbigeo = empresa.ReferenciaUbigeo;
            empresaNow.Descripcion = empresa.Descripcion;
            empresaNow.Website = empresa.Website;
            empresaNow.ContactName = empresa.ContactName;
            empresaNow.Telefono = empresa.Telefono;
            empresaNow.Estado = empresa.Estado;

            int countRows = await _context.SaveChangesAsync();

            return (countRows > 0);
        }

        public async Task<bool> DeleteEmpresa(int id)
        {
            var empresaNow = await _context.Empresa
                                .Where(x => x.IdEmpresa == id).FirstOrDefaultAsync();

            if (empresaNow == null)
                return false;

            _context.Empresa.Remove(empresaNow);

            int countRows = await _context.SaveChangesAsync();
            return (countRows > 0);
        }

    }
}
