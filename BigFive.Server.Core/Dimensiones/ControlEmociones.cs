using System;
using BigFive.Server.Core.Dimensiones.PlantillaDeCorreccion;

namespace BigFive.Server.Core.Dimensiones
{
    public class ControlEmociones : ISubDimension
    {
        private string _name = "Control de Emociones";
        public string Name 
        { 
            get { return _name; }

        }

        private string _symbol = "Ce";
        public string Symbol
        {
            get { return _symbol; }
        }

        private int _positiveScore;
        public int PositiveScore 
        {
            get { return _positiveScore; }
            set { _positiveScore = value; }
        }

        private int _negativeScore;
        public int NegativeScore
        {
            get { return _negativeScore; }
            set { _negativeScore = value; }
        }

        public int GlobalScore
        {
            get { return _constante + _positiveScore - _negativeScore; }
            set{}
        }
        private const int _constante = 36;

        public string Resultado
        {
            get
            {
                //"Ce=36+21-16=41"
                return string.Format("{0}"+"=" + "{1}" + "+" + "{2}" + "-" + "{3}" + "=" + "{4}", 
                    Symbol,_constante ,PositiveScore,NegativeScore,GlobalScore);
            }

              set { throw new NotImplementedException(); }
        }
        private IPlantillaCorreccion _plantillaCorreccion = new ControlEmocionalPlantilla();
        
        public IPlantillaCorreccion PlantillaCorreccion
        {
            get { return _plantillaCorreccion; }
            set { throw new NotImplementedException(); }
        }
    }
}