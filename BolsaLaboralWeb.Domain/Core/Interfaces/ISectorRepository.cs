using BolsaLaboralWeb.Domain.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BolsaLaboralWeb.Domain.Infrastructure.Repositories
{
    public interface ISectorRepository
    {
        Task<IEnumerable<Sector>> GetSector();
    }
}