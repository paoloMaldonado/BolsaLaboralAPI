using AutoMapper;
using BolsaLaboralWeb.Domain.Core.DTOs;
using BolsaLaboralWeb.Domain.Core.Entities;
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
    public class OfertaLaboralController : ControllerBase
    {
        private readonly IOfertaLaboralRepository _ofertaLaboralRepository;
        private readonly IMapper _mapper;

        public OfertaLaboralController(IOfertaLaboralRepository ofertaLaboralRepository, IMapper mapper)
        {
            _ofertaLaboralRepository = ofertaLaboralRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetOfertaLaboral")]
        public async Task<IActionResult> GetOfertaLaboral()
        {
            var ofertaLaborals = await _ofertaLaboralRepository.GetOfertaLaboral();

            var ofertaLaboralsList = _mapper.Map<IEnumerable<OfertaLaboralDTO>>(ofertaLaborals);


            return Ok(ofertaLaboralsList);
        }

        [HttpGet]
        [Route("GetOfertaLaboralById/{id}")]
        public async Task<IActionResult> GetOfertaLaboralById(int id)
        {
            var ofertaLaboral = await _ofertaLaboralRepository.GetOfertaLaboralById(id);
            if (ofertaLaboral == null)
                return NotFound();

            return Ok(ofertaLaboral);
        }

        [HttpPost]
        [Route("PostOfertaLaboral")]
        public async Task<IActionResult> PostOfertaLaboral(OfertaLaboralPostDTO ofertaLaboralPostDTO)
        {
            var ofertaLaboral = _mapper.Map<OfertaLaboral>(ofertaLaboralPostDTO);

            await _ofertaLaboralRepository.InsertOfertaLaboral(ofertaLaboral);
            return Ok(ofertaLaboral);
        }

        [HttpPut]
        [Route("PutOfertaLaboral")]
        public async Task<IActionResult> PutOfertaLaboral(OfertaLaboral ofertaLaboral)
        {
            await _ofertaLaboralRepository.UpdateOfertaLaboral(ofertaLaboral);
            return Ok(ofertaLaboral);
        }

        [HttpDelete]
        [Route("DeleteOfertaLaboral/{id}")]
        public async Task<IActionResult> DeleteOfertaLaboral(int id)
        {
            var result = await _ofertaLaboralRepository.DeleteOfertaLaboral(id);
            if (!result)
                return NotFound();

            return NoContent();
        }
    }
}
