using BolsaLaboralWeb.Domain.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BolsaLaboralWeb.Domain.Core.Interfaces
{
    public interface IOfertaLaboralRepository
    {
        Task<bool> DeleteOfertaLaboral(int id);
        Task<IEnumerable<OfertaLaboral>> GetOfertaLaboral();
        Task<OfertaLaboral> GetOfertaLaboralById(int id);
        Task InsertOfertaLaboral(OfertaLaboral ofertaLab);
        Task<bool> UpdateOfertaLaboral(OfertaLaboral ofertaLab);
    }
}