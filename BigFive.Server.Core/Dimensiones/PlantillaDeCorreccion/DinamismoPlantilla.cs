using System.Collections.Generic;
using BigFive.Server.Core.Common;

namespace BigFive.Server.Core.Dimensiones.PlantillaDeCorreccion
{
    public class DinamismoPlantilla : IPlantillaCorreccion
    {
        public List<IRespuestaDePlantilla> Respuestas
        {
            get { return GetRespuestaDePlantillas(); }
        }

        private static List<IRespuestaDePlantilla> GetRespuestaDePlantillas()
        {

            return new List<IRespuestaDePlantilla>
                       {                            
                           new RespuestaDePlantilla{Number =   1, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number = 7, ScoreType = TipoPuntaje.Negative}
                           ,new RespuestaDePlantilla{Number = 25, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number =  37, ScoreType = TipoPuntaje.Negative}
                           ,new RespuestaDePlantilla{Number = 51, ScoreType = TipoPuntaje.Negative}                                                      
                           ,new RespuestaDePlantilla{Number = 53, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number = 68, ScoreType = TipoPuntaje.Positive}                                                      
                           ,new RespuestaDePlantilla{Number = 78, ScoreType = TipoPuntaje.Negative}
                           ,new RespuestaDePlantilla{Number = 94, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number = 99, ScoreType = TipoPuntaje.Negative}
                           ,new RespuestaDePlantilla{Number = 114, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number = 121, ScoreType = TipoPuntaje.Negative}
                       };
        }
    }
}