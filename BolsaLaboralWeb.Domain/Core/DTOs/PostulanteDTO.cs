using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaLaboralWeb.Domain.Core.DTOs
{
    public class PostulanteDTO
    {
        public int IdPostulante { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Genero { get; set; }
        public string Telefono { get; set; }
        public string ZipCode { get; set; }
        public bool? TieneEstudio { get; set; }
        public bool? TieneExperiencia { get; set; }
        public string Estado { get; set; }
    }

    public class PostulantePostDTO
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Genero { get; set; }
        public string Telefono { get; set; }
        public string ZipCode { get; set; }
        public bool? TieneEstudio { get; set; }
        public bool? TieneExperiencia { get; set; }
    }
}
