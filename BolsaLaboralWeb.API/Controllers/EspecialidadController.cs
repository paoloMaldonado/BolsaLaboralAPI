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
    public class EspecialidadController : ControllerBase
    {
        private readonly IEspecialidadRepository _especialidadRepository;
        private readonly IMapper _mapper;

        public EspecialidadController(IEspecialidadRepository especialidadRepository, IMapper mapper)
        {
            _especialidadRepository = especialidadRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetEspecialidad")]
        public async Task<IActionResult> GetEspecialidad()
        {
            var especialidad = await _especialidadRepository.GetEspecialidad();

            var especialidadList = _mapper.Map<IEnumerable<EspecialidadDTO>>(especialidad);

            return Ok(especialidadList);
        }
    }
}
