using BolsaLaboralWeb.Domain.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BolsaLaboralWeb.Domain.Core.Interfaces
{
    public interface ICategoriaEmpleoRepository
    {
        Task<IEnumerable<CategoriaEmpleo>> GetCategoriaEmpleo();
    }
}