using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaLaboralWeb.Domain.Core.DTOs
{
    public class HojaVidaCvDTO
    {
        public int IdHojaVida { get; set; }
        public string GradoInstruccion { get; set; }
  
        public DateTime? FechaIniEstudio { get; set; }
        public DateTime? FechaFinEstudio { get; set; }
        public string CentroEducativo { get; set; }
        public string Puesto { get; set; }
        public string Empresa { get; set; }
        public string FechaIniJob { get; set; }
        public string FechaFinJob { get; set; }
       
        public string NivelIngles { get; set; }
        public string ExamenInter { get; set; }
        public bool? TieneTrabajo { get; set; }
        public bool? BuscaTrabajo { get; set; }
        public string AnioExp { get; set; }
 
        public string ObjetivosMotivavion { get; set; }

    
    }

    public class HojaVidaCvPostDTO
    {
        public string GradoInstruccion { get; set; }

        public DateTime? FechaIniEstudio { get; set; }
        public DateTime? FechaFinEstudio { get; set; }
        public string CentroEducativo { get; set; }
        public string Puesto { get; set; }
        public string Empresa { get; set; }
        public string FechaIniJob { get; set; }
        public string FechaFinJob { get; set; }

        public string NivelIngles { get; set; }
        public string ExamenInter { get; set; }
        public bool? TieneTrabajo { get; set; }
        public bool? BuscaTrabajo { get; set; }
        public string AnioExp { get; set; }

        public string ObjetivosMotivavion { get; set; }
    }
}
