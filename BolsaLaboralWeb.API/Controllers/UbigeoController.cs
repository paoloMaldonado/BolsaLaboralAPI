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
using BolsaLaboralWeb.Domain.Infrastructure.Repositories;

namespace BolsaLaboralWeb.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UbigeoController : ControllerBase
    {
        private readonly IUbigeoRepository _ubigeoRepository;
        private readonly IMapper _mapper;

        public UbigeoController(IUbigeoRepository ubigeoRepository, IMapper mapper)
        {
            _ubigeoRepository = ubigeoRepository;
            _mapper = mapper;
        }


        [HttpGet]
        [Route("GetUbigeo")]
        public async Task<IActionResult> GetUbigeo()
        {
            var ubigeos = await _ubigeoRepository.GetUbigeo();

            //var ubigeosList = _mapper.Map<IEnumerable<UbigeoDTO>>(ubigeos);

            return Ok(ubigeos);
        }

        [HttpGet]
        [Route("GetUbigeoByDepId/{id}")]
        public async Task<IActionResult> GetUbigeosByDepId(int id)
        {
            var ubigeos = await _ubigeoRepository.GetUbigeosByDepaId(id);

            if (ubigeos == null)
                return NotFound();

            var ubigeosList = _mapper.Map<IEnumerable<UbigeoDTO>>(ubigeos);

            return Ok(ubigeosList);
        }

        [HttpGet]
        [Route("GetUbigeoByProvId/{id}")]
        public async Task<IActionResult> GetUbigeosByProvId(int id)
        {
            var ubigeos = await _ubigeoRepository.GetUbigeosByProvId(id);

            if (ubigeos == null)
                return NotFound();

            var ubigeosList = _mapper.Map<IEnumerable<UbigeoDTO>>(ubigeos);

            return Ok(ubigeosList);
        }
    }
}
