using AutoMapper;
using BolsaLaboralWeb.Domain.Core.DTOs;
using BolsaLaboralWeb.Domain.Core.Entities;
using BolsaLaboralWeb.Domain.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BolsaLaboralWeb.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpresaController : ControllerBase
    {
        private readonly IEmpresaRepository _empresaRepository;
        private readonly IMapper _mapper;

        public EmpresaController(IEmpresaRepository empresaRepository, IMapper mapper)
        {
            _empresaRepository = empresaRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetEmpresa")]
        public async Task<IActionResult> GetEmpresa()
        {
            var empresas = await _empresaRepository.GetEmpresa();

            var empresasList = _mapper.Map<IEnumerable<EmpresaDTO>>(empresas);


            return Ok(empresasList);
        }

        [HttpGet]
        [Route("GetEmpresaById/{id}")]
        public async Task<IActionResult> GetEmpresaById(int id)
        {
            var empresa = await _empresaRepository.GetEmpresaById(id);
            if (empresa == null)
                return NotFound();

            return Ok(empresa);
        }

        [HttpPost]
        [Route("PostEmpresa")]
        public async Task<IActionResult> PostEmpresa(EmpresaPostDTO empresaPostDTO)
        {
            var empresa = _mapper.Map<Empresa>(empresaPostDTO);

            await _empresaRepository.InsertEmpresa(empresa);
            return Ok(empresa);
        }

        [HttpPut]
        [Route("PutEmpresa")]
        public async Task<IActionResult> PutEmpresa(Empresa empresa)
        {
            await _empresaRepository.UpdateEmpresa(empresa);
            return Ok(empresa);
        }

        [HttpDelete]
        [Route("DeleteEmpresa/{id}")]
        public async Task<IActionResult> DeleteEmpresa(int id)
        {
            var result = await _empresaRepository.DeleteEmpresa(id);
            if (!result)
                return NotFound();

            return NoContent();
        }


    }
}
