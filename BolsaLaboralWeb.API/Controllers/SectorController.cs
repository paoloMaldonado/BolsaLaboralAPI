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
    public class SectorController : ControllerBase
    {
        private readonly ISectorRepository _sectorRepository;
        private readonly IMapper _mapper;

        public SectorController(ISectorRepository sectorRepository, IMapper mapper)
        {
            _sectorRepository = sectorRepository;
            _mapper = mapper;
        }


        [HttpGet]
        [Route("GetSector")]
        public async Task<IActionResult> GetSector()
        {
            var sectors = await _sectorRepository.GetSector();

            //var sectorsList = _mapper.Map<IEnumerable<SectorDTO>>(sectors);

            return Ok(sectors);
        }}
    }
