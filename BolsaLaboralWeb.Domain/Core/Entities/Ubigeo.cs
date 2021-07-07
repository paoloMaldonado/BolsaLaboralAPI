using System;
using System.Collections.Generic;

#nullable disable

namespace BolsaLaboralWeb.Domain.Core.Entities
{
    public partial class Ubigeo
    {
        public Ubigeo()
        {
            Empresa = new HashSet<Empresa>();
            OfertaLaboral = new HashSet<OfertaLaboral>();
            Postulante = new HashSet<Postulante>();
        }

        public int IdUbigeo { get; set; }
        public int? IdDepartamento3 { get; set; }
        public int? IdProvincia2 { get; set; }

        public virtual Departamento IdDepartamento3Navigation { get; set; }
        public virtual Provincia IdProvincia2Navigation { get; set; }
        public virtual ICollection<Empresa> Empresa { get; set; }
        public virtual ICollection<OfertaLaboral> OfertaLaboral { get; set; }
        public virtual ICollection<Postulante> Postulante { get; set; }
    }
}
