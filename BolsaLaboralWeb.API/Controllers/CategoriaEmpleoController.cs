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
    public class CategoriaEmpleoController : ControllerBase
    {
        private readonly ICategoriaEmpleoRepository _categoriaEmpleoRepository;
        private readonly IMapper _mapper;

        public CategoriaEmpleoController(ICategoriaEmpleoRepository categoriaEmpleoRepository, IMapper mapper)
        {
            _categoriaEmpleoRepository = categoriaEmpleoRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetCategoriaEmpleo")]
        public async Task<IActionResult> GetCategoriaEmpleo()
        {
            var categoriaEmpleos = await _categoriaEmpleoRepository.GetCategoriaEmpleo();

            var categoriaEmpleosList = _mapper.Map<IEnumerable<CategoriaEmpleoDTO>>(categoriaEmpleos);

            return Ok(categoriaEmpleosList);
        }
    }
}
