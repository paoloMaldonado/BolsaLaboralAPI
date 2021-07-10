using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaLaboralWeb.Domain.Core.DTOs
{
    public class NivelExperienciaDTO
    {
        public string Nombre { get; set; }
    }

    public class NivelExperienciaPostDTO
    {
        public int IdNivelExperiencia { get; set; }
        public string Nombre { get; set; }
    }
}
