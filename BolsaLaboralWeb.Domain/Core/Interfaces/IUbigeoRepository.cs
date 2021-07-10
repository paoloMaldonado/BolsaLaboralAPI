using BolsaLaboralWeb.Domain.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BolsaLaboralWeb.Domain.Infrastructure.Repositories
{
    public interface IUbigeoRepository
    {
        Task<IEnumerable<Ubigeo>> GetUbigeo();
        Task<IEnumerable<Ubigeo>> GetUbigeosByDepaId(int id);
        Task<IEnumerable<Ubigeo>> GetUbigeosByProvId(int id);
    }
}