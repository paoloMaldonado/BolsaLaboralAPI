using Microsoft.AspNetCore.Http;
using BolsaLaboralWeb.Domain.Core.Entities;
using BolsaLaboralWeb.Domain.Core.Interfaces;
using BolsaLaboralWeb.Domain.Core.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace BolsaLaboralWeb.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentoController : ControllerBase
    {
        private readonly IDepartamentoRepository _departamentoRepository;
        private readonly IMapper _mapper;

        public DepartamentoController(IDepartamentoRepository departamentoRepository, IMapper mapper)
        {
            _departamentoRepository = departamentoRepository;
            _mapper = mapper;
        }


        [HttpGet]
        [Route("GetDepartamento")]
        public async Task<IActionResult> GetDepartamento()
        {
            var departamentos = await _departamentoRepository.GetDepartamento();

            var departamentosList = _mapper.Map<IEnumerable<DepartamentoDTO>>(departamentos);

            return Ok(departamentosList);
        }

    }
}
