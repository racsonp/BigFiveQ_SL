using BigFive.Server.Core.Dimensiones.PlantillaDeCorreccion;

namespace BigFive.Server.Core.Dimensiones
{
    public class Distorsion : ISubDimension
    {
        public string Name { get { return "Distorcion"; } }
        public string Symbol { get { return "D"; } }

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
            get { return  _positiveScore ; }
            set { }
        }

        private const int Constante = 0;

        public string Resultado
        {
            get
            {
                return string.Format("{0}" + "=" + "{1}" + "+" + "{2}" + "-" + "{3}" + "=" + "{4}",
                                     Symbol, Constante, PositiveScore, NegativeScore, GlobalScore);
            }

            set { }
        }
        private readonly IPlantillaCorreccion _plantillaCorreccion = new DistorcionPlantilla();

        public IPlantillaCorreccion PlantillaCorreccion
        {
            get { return _plantillaCorreccion; }

            set { }
        }
    }
}