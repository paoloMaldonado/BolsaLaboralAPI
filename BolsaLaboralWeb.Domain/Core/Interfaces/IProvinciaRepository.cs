using BolsaLaboralWeb.Domain.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BolsaLaboralWeb.Domain.Core.Interfaces
{
    public interface IProvinciaRepository
    {
        Task<IEnumerable<Provincia>> GetProvincia();
        Task<IEnumerable<Provincia>> GetProvinciasByDepaId(int id);
    }
}