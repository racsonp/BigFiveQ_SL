using System.Collections.Generic;
using BigFive.Server.Core.Common;
using BigFive.Server.Core.Dimensiones;


namespace BigFive.Server.Core.Process
{
    public class CalculaPuntajeDimension
    {
        private  IEnumerable<IAnsweredQuiz> _examenContestado;
        private  ISubDimension _subDimension;

       public ISubDimension Procesar(IEnumerable<IAnsweredQuiz> answeredQuiz, ISubDimension subDimension)       
        {
            _examenContestado = answeredQuiz;
            _subDimension = subDimension;
            subDimension.NegativeScore = ProcesarNegativos();
            subDimension.PositiveScore = ProcesarPositivos();

         return _subDimension;
        }

      private int ProcesarPositivos()
        {
            return CalculaPuntos(TipoPuntaje.Positive);
        }

      private  int ProcesarNegativos()
        {
            return CalculaPuntos(TipoPuntaje.Negative);
        }
   

        private int CalculaPuntos( TipoPuntaje tipo)
        {
            var proc = new ProcesarPuntos();
            //Toma los punso de la plantilla de correccion ( positivos O regativo)
            var plantillaCorrecion = proc.GetPlatillaCorrecion(_subDimension.PlantillaCorreccion.Respuestas, tipo);
            //Toma las respuestas que aplican para la plantilla de correccion
            var respuestas= proc.GetRespuestasByPlantillaCorrecion(plantillaCorrecion, _examenContestado);
            var puntos = proc.SumaPuntos(respuestas);
            return puntos;

        }

 
    }
}