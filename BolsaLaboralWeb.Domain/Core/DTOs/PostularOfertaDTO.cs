using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaLaboralWeb.Domain.Core.DTOs
{
    public class PostularOfertaDTO
    {
        public int IdPostular { get; set; }
        public DateTime? FechaPostulacion { get; set; }
        public DateTime? FechaFinalizado { get; set; }
        public string CvAdjunto { get; set; }
        public string Estado { get; set; }


    }

    public class PostularOfertaPostDTO
    {
        public DateTime? FechaPostulacion { get; set; }
        public DateTime? FechaFinalizado { get; set; }
        public string CvAdjunto { get; set; }
        public string Estado { get; set; }


    }
}
