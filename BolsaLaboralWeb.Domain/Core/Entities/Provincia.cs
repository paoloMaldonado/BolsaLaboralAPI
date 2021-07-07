using System;
using System.Collections.Generic;

#nullable disable

namespace BolsaLaboralWeb.Domain.Core.Entities
{
    public partial class Provincia
    {
        public Provincia()
        {
            Ubigeo = new HashSet<Ubigeo>();
        }

        public int IdProvincia { get; set; }
        public string Nombre { get; set; }
        public int? IdDepartamento1 { get; set; }

        public virtual Departamento IdDepartamento1Navigation { get; set; }
        public virtual ICollection<Ubigeo> Ubigeo { get; set; }
    }
}
