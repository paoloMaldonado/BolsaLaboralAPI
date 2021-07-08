using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaLaboralWeb.Domain.Core.DTOs
{
    public class DepartamentoDTO
    {
        public int IdDepartamento { get; set; }
        public string Nombre { get; set; }

    }

    public class DepartamentoPostDTO
    {
        //public int IdDepartamento { get; set; }
        public string Nombre { get; set; }

    }
}
