using BolsaLaboralWeb.Domain.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BolsaLaboralWeb.Domain.Core.Interfaces
{
    public interface IEspecialidadRepository
    {
        Task<IEnumerable<Especialidad>> GetEspecialidad();
        Task<Especialidad> GetEspecialidadById(int id);
    }
}