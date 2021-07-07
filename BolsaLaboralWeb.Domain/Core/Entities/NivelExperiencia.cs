using System;
using System.Collections.Generic;

#nullable disable

namespace BolsaLaboralWeb.Domain.Core.Entities
{
    public partial class NivelExperiencia
    {
        public NivelExperiencia()
        {
            HojaVidaCv = new HashSet<HojaVidaCv>();
            OfertaLaboral = new HashSet<OfertaLaboral>();
        }

        public int IdNivelExperiencia { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<HojaVidaCv> HojaVidaCv { get; set; }
        public virtual ICollection<OfertaLaboral> OfertaLaboral { get; set; }
    }
}
