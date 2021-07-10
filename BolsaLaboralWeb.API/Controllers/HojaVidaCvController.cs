using AutoMapper;
using BolsaLaboralWeb.Domain.Core.DTOs;
using BolsaLaboralWeb.Domain.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BolsaLaboralWeb.Domain.Core.Entities;
namespace BolsaLaboralWeb.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HojaVidaCvController : ControllerBase
    {
        private readonly IHojaVidaCvRepository _HojaVidaCvRepository;
        private readonly IMapper _mapper;

        public HojaVidaCvController(IHojaVidaCvRepository HojaVidaCvRepository, IMapper mapper)
        {
            _HojaVidaCvRepository = HojaVidaCvRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetHojaVidaCv")]
        public async Task<IActionResult> GetHojaVidaCv()
        {
            var HojaVidaCvs = await _HojaVidaCvRepository.GetHojaVidaCv();

            var HojaVidaCvsList = _mapper.Map<IEnumerable<HojaVidaCvDTO>>(HojaVidaCvs);


            return Ok(HojaVidaCvsList);
        }

        [HttpGet]
        [Route("GetHojaVidaCvById/{id}")]
        public async Task<IActionResult> GetHojaVidaCvById(int id)
        {
            var HojaVidaCv = await _HojaVidaCvRepository.GetHojaVidaCvById(id);
            if (HojaVidaCv == null)
                return NotFound();

            return Ok(HojaVidaCv);
        }

        [HttpPost]
        [Route("PostHojaVidaCv")]
        public async Task<IActionResult> PostHojaVidaCv(HojaVidaCvPostDTO HojaVidaCvPostDTO)
        {
            var HojaVidaCv = _mapper.Map<HojaVidaCv>(HojaVidaCvPostDTO);

            await _HojaVidaCvRepository.InsertHojaVidaCv(HojaVidaCv);
            return Ok(HojaVidaCv);
        }

        [HttpPut]
        [Route("PutHojaVidaCv")]
        public async Task<IActionResult> PutHojaVidaCv(HojaVidaCv HojaVidaCv)
        {
            await _HojaVidaCvRepository.UpdateHojaVidaCv(HojaVidaCv);
            return Ok(HojaVidaCv);
        }

        [HttpDelete]
        [Route("DeleteHojaVidaCv/{id}")]
        public async Task<IActionResult> DeleteHojaVidaCv(int id)
        {
            var result = await _HojaVidaCvRepository.DeleteHojaVidaCv(id);
            if (!result)
                return NotFound();

            return NoContent();
        }


    }
}
