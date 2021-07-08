using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaLaboralWeb.Domain.Core.DTOs
{
    public class EmpresaDTO
    {
        public int IdEmpresa { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string RazonSocial { get; set; }
        public string Ruc { get; set; }
        public string ReferenciaUbigeo { get; set; }
        public string Descripcion { get; set; }
        public string Website { get; set; }
        public string ContactName { get; set; }
        public string Telefono { get; set; }
        public string Estado { get; set; }

    }

    public class EmpresaPostDTO
    { 
        public string Email { get; set; }
        public string Password { get; set; }
        public string RazonSocial { get; set; }
        public string Ruc { get; set; }
        public string ReferenciaUbigeo { get; set; }
        public string Descripcion { get; set; }
        public string Website { get; set; }
        public string ContactName { get; set; }
        public string Telefono { get; set; }
    }
}
