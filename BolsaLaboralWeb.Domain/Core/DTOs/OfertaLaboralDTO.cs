using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaLaboralWeb.Domain.Core.DTOs
{
    public class OfertaLaboralDTO
    {
        public int IdOferta { get; set; }
        public string Nombre { get; set; }
        public DateTime? FechaPublicacion { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public string Descripcion { get; set; }
        public string Beneficios { get; set; }
        public string Estado { get; set; }

    }

    public class OfertaLaboralPostDTO
    {
        public string Nombre { get; set; }
        public DateTime? FechaPublicacion { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public string Descripcion { get; set; }
        public string Beneficios { get; set; }
        public string Estado { get; set; }

    }
}
