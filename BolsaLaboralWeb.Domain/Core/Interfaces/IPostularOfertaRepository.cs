using BolsaLaboralWeb.Domain.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BolsaLaboralWeb.Domain.Infrastructure.Repositories
{
    public interface IPostularOfertaRepository
    {
        Task<bool> DeletePostularOferta(int id);
        Task<IEnumerable<PostularOferta>> GetPostularOferta();
        Task<PostularOferta> GetPostularOfertaById(int id);
        Task InsertPostularOferta(PostularOferta postOferta);
        Task<bool> UpdatePostularOferta(PostularOferta postOferta);
    }
}