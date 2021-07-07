using System;
using System.Collections.Generic;

#nullable disable

namespace BolsaLaboralWeb.Domain.Core.Entities
{
    public partial class OfertaLaboral
    {
        public OfertaLaboral()
        {
            PostularOferta = new HashSet<PostularOferta>();
        }

        public int IdOferta { get; set; }
        public int? IdEmpresa1 { get; set; }
        public string Nombre { get; set; }
        public int? IdUbigeo3 { get; set; }
        public DateTime? FechaPublicacion { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public string Descripcion { get; set; }
        public string Beneficios { get; set; }
        public int? IdNivelExperiencia1 { get; set; }
        public int? IdCatEmpleo1 { get; set; }
        public string Estado { get; set; }

        public virtual CategoriaEmpleo IdCatEmpleo1Navigation { get; set; }
        public virtual Empresa IdEmpresa1Navigation { get; set; }
        public virtual NivelExperiencia IdNivelExperiencia1Navigation { get; set; }
        public virtual Ubigeo IdUbigeo3Navigation { get; set; }
        public virtual ICollection<PostularOferta> PostularOferta { get; set; }
    }
}
