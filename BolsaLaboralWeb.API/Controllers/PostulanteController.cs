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
    public class PostulanteController : ControllerBase
    {
        private readonly IPostulanteRepository _postulanteRepository;
        private readonly IMapper _mapper;

        public PostulanteController(IPostulanteRepository postulanteRepository, IMapper mapper)
        {
            _postulanteRepository = postulanteRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetPostulante")]
        public async Task<IActionResult> GetPostulante()
        {
            var postulantes = await _postulanteRepository.GetPostulante();

            var postulantesList = _mapper.Map<IEnumerable<PostulanteDTO>>(postulantes);


            return Ok(postulantesList);
        }

        [HttpGet]
        [Route("GetPostulanteById/{id}")]
        public async Task<IActionResult> GetCustomerById(int id)
        {
            var postulante = await _postulanteRepository.GetPostulanteById(id);
            if (postulante == null)
                return NotFound();

            return Ok(postulante);
        }

        [HttpPost]
        [Route("PostPostulante")]
        public async Task<IActionResult> PostPostulante(PostulantePostDTO postulantePostDTO)
        {
            var postulante = _mapper.Map<Postulante>(postulantePostDTO);

            await _postulanteRepository.InsertPostulante(postulante);
            return Ok(postulante);
        }

        [HttpPut]
        [Route("PutPostulante")]
        public async Task<IActionResult> PutPostulante(Postulante postulante)
        {
            await _postulanteRepository.UpdatePostulante(postulante);
            return Ok(postulante);
        }

        [HttpDelete]
        [Route("DeletePostulante/{id}")]
        public async Task<IActionResult> DeletePostulante(int id)
        {
            var result = await _postulanteRepository.DeletePostulante(id);
            if (!result)
                return NotFound();

            return NoContent();
        }


    }
}
