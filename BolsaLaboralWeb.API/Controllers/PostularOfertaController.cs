using AutoMapper;
using BolsaLaboralWeb.Domain.Core.DTOs;
using BolsaLaboralWeb.Domain.Core.Entities;
using BolsaLaboralWeb.Domain.Infrastructure.Repositories;
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
    public class PostularOfertaController : ControllerBase
    {
        private readonly IPostularOfertaRepository _postularOfertaRepository;
        private readonly IMapper _mapper;

        public PostularOfertaController(IPostularOfertaRepository postularOfertaRepository, IMapper mapper)
        {
            _postularOfertaRepository = postularOfertaRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetPostularOferta")]
        public async Task<IActionResult> GetPostularOferta()
        {
            var postularOfertas = await _postularOfertaRepository.GetPostularOferta();

            var postularOfertasList = _mapper.Map<IEnumerable<PostularOfertaDTO>>(postularOfertas);


            return Ok(postularOfertasList);
        }

        [HttpGet]
        [Route("GetPostularOfertaById/{id}")]
        public async Task<IActionResult> GetPostularOfertaById(int id)
        {
            var postularOferta = await _postularOfertaRepository.GetPostularOfertaById(id);
            if (postularOferta == null)
                return NotFound();

            return Ok(postularOferta);
        }

        [HttpPost]
        [Route("PostPostularOferta")]
        public async Task<IActionResult> PostPostularOferta(PostularOfertaPostDTO postularOfertaPostDTO)
        {
            var postularOferta = _mapper.Map<PostularOferta>(postularOfertaPostDTO);

            await _postularOfertaRepository.InsertPostularOferta(postularOferta);
            return Ok(postularOferta);
        }

        [HttpPut]
        [Route("PutPostularOferta")]
        public async Task<IActionResult> PutPostularOferta(PostularOferta postularOferta)
        {
            await _postularOfertaRepository.UpdatePostularOferta(postularOferta);
            return Ok(postularOferta);
        }

        [HttpDelete]
        [Route("DeletePostularOferta/{id}")]
        public async Task<IActionResult> DeletePostularOferta(int id)
        {
            var result = await _postularOfertaRepository.DeletePostularOferta(id);
            if (!result)
                return NotFound();

            return NoContent();
        }

    }
}
