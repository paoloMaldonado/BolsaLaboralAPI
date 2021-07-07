using System;
using System.Collections.Generic;

#nullable disable

namespace BolsaLaboralWeb.Domain.Core.Entities
{
    public partial class HojaVidaCv
    {
        public HojaVidaCv()
        {
            Postulante = new HashSet<Postulante>();
        }

        public int IdHojaVida { get; set; }
        public string GradoInstruccion { get; set; }
        public int? IdEspecialidad1 { get; set; }
        public DateTime? FechaIniEstudio { get; set; }
        public DateTime? FechaFinEstudio { get; set; }
        public string CentroEducativo { get; set; }
        public string Puesto { get; set; }
        public string Empresa { get; set; }
        public string FechaIniJob { get; set; }
        public string FechaFinJob { get; set; }
        public int? IdNivelExperiencia2 { get; set; }
        public string NivelIngles { get; set; }
        public string ExamenInter { get; set; }
        public bool? TieneTrabajo { get; set; }
        public bool? BuscaTrabajo { get; set; }
        public string AnioExp { get; set; }
        public string IdPuestoPref { get; set; }
        public string ObjetivosMotivavion { get; set; }

        public virtual Especialidad IdEspecialidad1Navigation { get; set; }
        public virtual NivelExperiencia IdNivelExperiencia2Navigation { get; set; }
        public virtual ICollection<Postulante> Postulante { get; set; }
    }
}
