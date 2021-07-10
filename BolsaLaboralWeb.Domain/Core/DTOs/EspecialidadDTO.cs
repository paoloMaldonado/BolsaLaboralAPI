using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaLaboralWeb.Domain.Core.DTOs
{
    public class EspecialidadDTO
    {
        public int IdCatEmpleo { get; set; }
        public string Nombre { get; set; }
    }

    public class EspecialidadPostDTO
    {

        public string Nombre { get; set; }
    }
}
