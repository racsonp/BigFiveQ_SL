using System.Collections.Generic;
using BigFive.Server.Core.Common;

namespace BigFive.Server.Core.Dimensiones.PlantillaDeCorreccion
{
    public class CooperacionPlantilla : IPlantillaCorreccion
    {
        public List<IRespuestaDePlantilla> Respuestas
        {
            get { return GetRespuestaDePlantillas(); }
        }

        private static List<IRespuestaDePlantilla> GetRespuestaDePlantillas()
        {

            return new List<IRespuestaDePlantilla>
                       {                            
                           new RespuestaDePlantilla{Number =   4, ScoreType = TipoPuntaje.Negative}
                           ,new RespuestaDePlantilla{Number = 10, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number = 28, ScoreType = TipoPuntaje.Negative}
                           ,new RespuestaDePlantilla{Number = 34, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number = 48, ScoreType = TipoPuntaje.Positive}                                                      
                           ,new RespuestaDePlantilla{Number = 64, ScoreType = TipoPuntaje.Negative}
                           ,new RespuestaDePlantilla{Number = 70, ScoreType = TipoPuntaje.Negative}                           
                           ,new RespuestaDePlantilla{Number = 86, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number = 100, ScoreType = TipoPuntaje.Negative}
                           ,new RespuestaDePlantilla{Number = 109, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number = 111, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number = 130, ScoreType = TipoPuntaje.Negative}
                       };
        }
    }
}