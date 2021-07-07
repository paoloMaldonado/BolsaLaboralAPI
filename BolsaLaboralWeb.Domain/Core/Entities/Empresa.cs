using System;
using System.Collections.Generic;

#nullable disable

namespace BolsaLaboralWeb.Domain.Core.Entities
{
    public partial class Empresa
    {
        public Empresa()
        {
            OfertaLaboral = new HashSet<OfertaLaboral>();
        }

        public int IdEmpresa { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string RazonSocial { get; set; }
        public string Ruc { get; set; }
        public int? IdUbigeo1 { get; set; }
        public string ReferenciaUbigeo { get; set; }
        public int? IdSector1 { get; set; }
        public string Descripcion { get; set; }
        public string Website { get; set; }
        public string ContactName { get; set; }
        public string Telefono { get; set; }
        public string Estado { get; set; }

        public virtual Sector IdSector1Navigation { get; set; }
        public virtual Ubigeo IdUbigeo1Navigation { get; set; }
        public virtual ICollection<OfertaLaboral> OfertaLaboral { get; set; }
    }
}
