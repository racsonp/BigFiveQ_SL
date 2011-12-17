using System;

namespace ReporteBigFiveQ
{
    public interface IDimencion
    {
        string Simbolo { get; set; }
        int Orden { get; set; }
        int Puntos { get; set; }
    }

    public class Posicion
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
    public class Energia : IDimencion
    {
        public string Simbolo
        {
            get { return "E"; }
            set { }
        }
        public int Orden
        {
            get { return 1; }
            set {  }
        }

        public int Puntos { get; set; }
    }

    public class Afabilidad : IDimencion
    {
        public string Simbolo
        {
            get { return "A"; }
            set { }
        }
        public int Orden
        {
            get { return 2; }
            set {  }
        }

        public int Puntos { get; set; }
    }
    public class Teson : IDimencion
    {
        public string Simbolo
        {
            get { return "EE"; }
            set { }
        }
        public int Orden
        {
            get { return 3; }
            set { }
        }

        public int Puntos { get; set; }
    }
    public class EstabilidadEmocional : IDimencion
    {
        public string Simbolo
        {
            get { return "T"; }
            set { }
        }
        public int Orden
        {
            get { return 4; }
            set {  }
        }

        public int Puntos { get; set; }
    }
    public class AperturaMental : IDimencion
    {
        public string Simbolo
        {
            get { return "A M"; }
            set { }
        }
        public int Orden
        {
            get { return 5; }
            set {  }
        }

        public int Puntos { get; set; }
    }
    public class Distorcion : IDimencion
    {
        public string Simbolo
        {
            get { return "D"; }
            set { }
        }
        public int Orden
        {
            get { return 6; }
            set { }
        }

        public int Puntos { get; set; }
    }

    /// <summary>
    /// SubDimenciones here
    /// </summary>

    public class Dinamismo:IDimencion
    {
        public string Simbolo
        {
            get { return "Di"; }
            set{}
        }

        public int Orden
        {
            get { return 1; }
            set { }
        }

        public int Puntos { get; set; }
    }

    public class Dominancia : IDimencion
    {
        public string Simbolo
        {
            get { return "Do"; }
            set { }
        }

        public int Orden
        {
            get { return 2; }
            set { }
        }

        public int Puntos { get; set; }
    }


    public class Cooperacion : IDimencion
    {
        public string Simbolo
        {
            get { return "Cp"; }
            set { }
        }

        public int Orden
        {
            get { return 3; }
            set { }
        }

        public int Puntos { get; set; }
    }


    public class Cordialidad: IDimencion
    {
        public string Simbolo
        {
            get { return "Co"; }
            set { }
        }

        public int Orden
        {
            get { return 4; }
            set { }
        }

        public int Puntos { get; set; }
    }

    public class Escrupulosidad : IDimencion
    {
        public string Simbolo
        {
            get { return "Es"; }
            set { }
        }

        public int Orden
        {
            get { return 5; }
            set { }
        }

        public int Puntos { get; set; }
    }


    public class Perseverancia: IDimencion
    {
        public string Simbolo
        {
            get { return "Pe"; }
            set { }
        }

        public int Orden
        {
            get { return 6; }
            set { }
        }

        public int Puntos { get; set; }
    }

    public class ControlEmociones: IDimencion
    {
        public string Simbolo
        {
            get { return "Ce"; }
            set { }
        }

        public int Orden
        {
            get { return 7; }
            set { }
        }

        public int Puntos { get; set; }
    }


    public class ControlInpulsos : IDimencion
    {
        public string Simbolo
        {
            get { return "Ci"; }
            set { }
        }

        public int Orden
        {
            get { return 8; }
            set { }
        }

        public int Puntos { get; set; }
    }



    public class AperturaCultura : IDimencion
    {
        public string Simbolo
        {
            get { return "Ac"; }
            set { }
        }

        public int Orden
        {
            get { return 9; }
            set { }
        }

        public int Puntos { get; set; }
    }


    public class AperturaExperincia : IDimencion
    {
        public string Simbolo
        {
            get { return "Ae"; }
            set { }
        }

        public int Orden
        {
            get { return 10; }
            set { }
        }

        public int Puntos { get; set; }
    }
}