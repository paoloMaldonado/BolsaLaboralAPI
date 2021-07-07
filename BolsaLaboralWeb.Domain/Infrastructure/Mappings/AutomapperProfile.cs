using AutoMapper;
using BolsaLaboralWeb.Domain.Core.DTOs;
using BolsaLaboralWeb.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaLaboralWeb.Domain.Infrastructure.Mappings
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Postulante, PostulanteDTO>();
            CreateMap<PostulanteDTO, Postulante>();

            CreateMap<PostulantePostDTO, Postulante>();

        }

    }
}
