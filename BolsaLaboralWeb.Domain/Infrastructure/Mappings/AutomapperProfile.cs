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


            CreateMap<Departamento, DepartamentoDTO>();

            CreateMap<Provincia, ProvinciaDTO>();


            CreateMap<CategoriaEmpleo, CategoriaEmpleoDTO>();

            CreateMap<Empresa, EmpresaDTO>();
            CreateMap<EmpresaDTO, Empresa>();
            CreateMap<EmpresaPostDTO, Empresa>();

            CreateMap<NivelExperiencia, NivelExperienciaDTO>();

            CreateMap<OfertaLaboral, OfertaLaboralDTO>();
            CreateMap<OfertaLaboralDTO, OfertaLaboral>();
            CreateMap<OfertaLaboralPostDTO, OfertaLaboral>();

            CreateMap<PostularOferta, PostularOfertaDTO>();
            CreateMap<PostularOfertaDTO, PostularOferta>();
            CreateMap<PostularOfertaPostDTO, PostularOferta>();

            CreateMap<Especialidad, EspecialidadDTO>();


            CreateMap<HojaVidaCv, HojaVidaCvDTO>();
            CreateMap<HojaVidaCvDTO, HojaVidaCv>();
            CreateMap<HojaVidaCvPostDTO, HojaVidaCv>();

            CreateMap<Sector, SectorDTO>();
            CreateMap<Ubigeo, UbigeoDTO>();

        }

    }
}
