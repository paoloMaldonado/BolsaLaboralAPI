using System;
using System.Collections.Generic;

#nullable disable

namespace BolsaLaboralWeb.Domain.Core.Entities
{
    public partial class Departamento
    {
        public Departamento()
        {
            Provincia = new HashSet<Provincia>();
            Ubigeo = new HashSet<Ubigeo>();
        }

        public int IdDepartamento { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Provincia> Provincia { get; set; }
        public virtual ICollection<Ubigeo> Ubigeo { get; set; }
    }
}
