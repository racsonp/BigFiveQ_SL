
using System.Windows.Controls;


namespace ReporteBigFiveQ
{
    public partial class HojaPerfilBfq : UserControl
    {
        public HojaPerfilBfq()
        {
            InitializeComponent();

        }

        public ReporteBfq Reporte { get; set; }


        public void Cargar(ReporteBfq reporte)
        {
            Reporte = reporte;
            if (Reporte == null) return;
         Dimenciones.Run(reporte.Dimenciones);
            SubDimenciones.Run(reporte.SunDimenciones);
        }
    }
}
