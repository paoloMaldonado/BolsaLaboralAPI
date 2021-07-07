using System;
using System.Collections.Generic;

#nullable disable

namespace BolsaLaboralWeb.Domain.Core.Entities
{
    public partial class Especialidad
    {
        public Especialidad()
        {
            HojaVidaCv = new HashSet<HojaVidaCv>();
        }

        public int IdEspecialidad { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<HojaVidaCv> HojaVidaCv { get; set; }
    }
}
