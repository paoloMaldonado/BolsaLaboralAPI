using BolsaLaboralWeb.Domain.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BolsaLaboralWeb.Domain.Core.Interfaces
{
    public interface IPostulanteRepository
    {
        Task<bool> DeletePostulante(int id);
        Task<IEnumerable<Postulante>> GetPostulante();
        Task<Postulante> GetPostulanteById(int id);
        Task InsertPostulante(Postulante postulante);
        Task<bool> UpdatePostulante(Postulante postulante);
    }
}