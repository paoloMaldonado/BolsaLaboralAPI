using System;
using System.Collections.Generic;

#nullable disable

namespace BolsaLaboralWeb.Domain.Core.Entities
{
    public partial class Sector
    {
        public Sector()
        {
            Empresa = new HashSet<Empresa>();
        }

        public int IdSector { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Empresa> Empresa { get; set; }
    }
}
