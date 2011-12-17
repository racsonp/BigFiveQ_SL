using System.Collections.Generic;
using System.Linq;
using BigFive.Server.Core.Common;
using BigFive.Server.Core.Dimensiones.PlantillaDeCorreccion;


namespace BigFive.Server.Core.Process
{
    public class ProcesarPuntos
    {

        //.......................................................1...................................

        // enviarl;e  _subDimension.PlantillaCorreccion--.Respuestas
        public List<int> GetPlatillaCorrecion(List<IRespuestaDePlantilla> respuestas, TipoPuntaje tipo)
        {
            var indicesRespustas = from respuesta in respuestas
                                   where respuesta.ScoreType == tipo
                                   orderby respuesta.Number ascending 
                                   select respuesta.Number;

            return indicesRespustas.ToList();
        }
        //......................................................2..................................
        // enviarl;e _examenContestado[].Response.Value..or Question
        public List<IResponse> GetRespuestasByPlantillaCorrecion(IEnumerable<int> indicePlatillaPreguntas, IEnumerable<IAnsweredQuiz> contestaciones)
        {
            var newContestaciones = (from indicePlatillaPregunta in indicePlatillaPreguntas
                                     from contestacion in contestaciones
                                     
                                     where indicePlatillaPregunta == contestacion.Question.Index 
                                     select contestacion.Response).ToList();

            return newContestaciones;
        }
        //.......................................................3...................................
        public int SumaPuntos(IEnumerable<IResponse> responses)
        {
          //  int puntos = responses.Aggregate(0, (current, response) => current + response.Value);
            var puntos = 0;
            foreach (var response in responses)
            {
                if(response.Value == 0)
                response.Value = 3;
                puntos = puntos + response.Value;
            }
            return puntos;
        }

   
    }
}