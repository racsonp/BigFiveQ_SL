using System;
using System.Collections.Generic;

namespace ReporteBigFiveQ
{
    public class ReporteBfq
    {
        public string Nombres { get; set; }
        public virtual string Apellidos { get; set; }
        //public string Genero { get; set; }
        public int Edad { get; set; }
        public string Institucion { get; set; }
        public DateTime Fecha { get; set; }
        public List<IDimencion> Dimenciones { get; set; }
        public List<IDimencion> SunDimenciones { get; set; }
    }
}