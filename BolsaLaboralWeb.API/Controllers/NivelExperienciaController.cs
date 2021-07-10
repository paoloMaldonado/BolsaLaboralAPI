using AutoMapper;
using BolsaLaboralWeb.Domain.Core.DTOs;
using BolsaLaboralWeb.Domain.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BolsaLaboralWeb.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NivelExperienciaController : ControllerBase
    {
        private readonly INivelExperienciaRepository _nivelExperienciaRepository;
        private readonly IMapper _mapper;

        public NivelExperienciaController(INivelExperienciaRepository nivelExperienciaRepository, IMapper mapper)
        {
            _nivelExperienciaRepository = nivelExperienciaRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetNivelExperiencia")]
        public async Task<IActionResult> GetNivelExperiencia()
        {
            var nivelExperiencia = await _nivelExperienciaRepository.GetNivelExperiencia();

            var nivelExperienciaList = _mapper.Map<IEnumerable<NivelExperienciaDTO>>(nivelExperiencia);

            return Ok(nivelExperienciaList);
        }
    }
}

