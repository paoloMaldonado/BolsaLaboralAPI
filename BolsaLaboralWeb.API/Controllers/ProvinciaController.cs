using BolsaLaboralWeb.Domain.Core.Entities;
using BolsaLaboralWeb.Domain.Core.Interfaces;
using BolsaLaboralWeb.Domain.Core.DTOs;
using Microsoft.AspNetCore.Http;
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
    public class ProvinciaController : ControllerBase
    {
        private readonly IProvinciaRepository _provinciaRepository;
        private readonly IMapper _mapper;

        public ProvinciaController(IProvinciaRepository provinciaRepository, IMapper mapper)
        {
            _provinciaRepository = provinciaRepository;
            _mapper = mapper;
        }


        [HttpGet]
        [Route("GetProvincia")]
        public async Task<IActionResult> GetProvincia()
        {
            var provincias = await _provinciaRepository.GetProvincia();

            //var provinciasList = _mapper.Map<IEnumerable<ProvinciaDTO>>(provincias);

            return Ok(provincias);
        }

        [HttpGet]
        [Route("GetProvinciaByDepId/{id}")]
        public async Task<IActionResult> GetProvinciaByDepId(int id)
        {
            var provincias = await _provinciaRepository.GetProvinciasByDepaId(id);

            if (provincias == null)
                return NotFound();

            var provinciasList = _mapper.Map<IEnumerable<ProvinciaDTO>>(provincias);

            return Ok(provinciasList);
        }
    }
}
