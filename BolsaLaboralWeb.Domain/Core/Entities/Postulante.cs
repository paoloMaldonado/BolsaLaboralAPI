using System;
using System.Collections.Generic;

#nullable disable

namespace BolsaLaboralWeb.Domain.Core.Entities
{
    public partial class Postulante
    {
        public Postulante()
        {
            PostularOferta = new HashSet<PostularOferta>();
        }

        public int IdPostulante { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Genero { get; set; }
        public string Telefono { get; set; }
        public string ZipCode { get; set; }
        public int? IdUbigeo2 { get; set; }
        public bool? TieneEstudio { get; set; }
        public bool? TieneExperiencia { get; set; }
        public int? IdCvVirtual { get; set; }
        public string Estado { get; set; }

        public virtual HojaVidaCv IdCvVirtualNavigation { get; set; }
        public virtual Ubigeo IdUbigeo2Navigation { get; set; }
        public virtual ICollection<PostularOferta> PostularOferta { get; set; }
    }
}
