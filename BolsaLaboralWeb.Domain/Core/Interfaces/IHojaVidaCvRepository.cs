using BolsaLaboralWeb.Domain.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace BolsaLaboralWeb.Domain.Core.Interfaces
{
    public interface IHojaVidaCvRepository
    {
        Task<bool> DeleteHojaVidaCv(int id);
        Task<IEnumerable<HojaVidaCv>> GetHojaVidaCv();
        Task<HojaVidaCv> GetHojaVidaCvById(int id);
        Task InsertHojaVidaCv(HojaVidaCv HojaVidaCv);
        Task<bool> UpdateHojaVidaCv(HojaVidaCv HojaVidaCv);
    }
}