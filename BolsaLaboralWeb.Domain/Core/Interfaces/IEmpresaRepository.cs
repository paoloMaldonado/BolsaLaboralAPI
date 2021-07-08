using BolsaLaboralWeb.Domain.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BolsaLaboralWeb.Domain.Core.Interfaces
{
    public interface IEmpresaRepository
    {
        Task<bool> DeleteEmpresa(int id);
        Task<IEnumerable<Empresa>> GetEmpresa();
        Task<Empresa> GetEmpresaById(int id);
        Task InsertEmpresa(Empresa empresa);
        Task<bool> UpdateEmpresa(Empresa empresa);

    }
}