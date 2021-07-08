using BolsaLaboralWeb.Domain.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BolsaLaboralWeb.Domain.Core.Interfaces
{
    public interface IDepartamentoRepository
    {
        Task<IEnumerable<Departamento>> GetDepartamento();
        Task<Departamento> GetDepartamentoById(int id);
    }
}