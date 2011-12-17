﻿using BigFive.Server.Core.Dimensiones.PlantillaDeCorreccion;

namespace BigFive.Server.Core.Dimensiones
{
    public class AperturaExperiencia: ISubDimension
    {
        public string Name { get { return "Apertura a la experiancia"; } }
        public string Symbol { get { return "Ae"; } }

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
            get { return Constante + _positiveScore - _negativeScore; }
            set { }
        }

        private const int Constante = 36;

        public string Resultado
        {
            get
            {
                return string.Format("{0}" + "=" + "{1}" + "+" + "{2}" + "-" + "{3}" + "=" + "{4}",
                                     Symbol, Constante, PositiveScore, NegativeScore, GlobalScore);
            }

            set { }
        }

        private readonly IPlantillaCorreccion _plantillaCorreccion = new AperturaExperienciaPlantilla();

        public IPlantillaCorreccion PlantillaCorreccion
        {
            get { return _plantillaCorreccion; }

            set {  }
        }
    }
}