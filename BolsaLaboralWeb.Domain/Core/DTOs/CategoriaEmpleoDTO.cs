using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaLaboralWeb.Domain.Core.DTOs
{
    public class CategoriaEmpleoDTO
    {
        public string Categoria { get; set; }
    }

    public class CategoriaEmpleoPostDTO
    {
        public int IdCatEmpleo { get; set; }
        public string Categoria { get; set; }
    }
}
