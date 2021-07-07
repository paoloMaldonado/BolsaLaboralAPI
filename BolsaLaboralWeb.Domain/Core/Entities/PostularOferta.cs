using System;
using System.Collections.Generic;

#nullable disable

namespace BolsaLaboralWeb.Domain.Core.Entities
{
    public partial class PostularOferta
    {
        public int IdPostular { get; set; }
        public int? IdPostulante1 { get; set; }
        public int? IdOferta1 { get; set; }
        public DateTime? FechaPostulacion { get; set; }
        public DateTime? FechaFinalizado { get; set; }
        public string CvAdjunto { get; set; }
        public string Estado { get; set; }

        public virtual OfertaLaboral IdOferta1Navigation { get; set; }
        public virtual Postulante IdPostulante1Navigation { get; set; }
    }
}
