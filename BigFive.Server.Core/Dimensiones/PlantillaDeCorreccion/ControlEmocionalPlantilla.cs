using System.Collections.Generic;
using BigFive.Server.Core.Common;

namespace BigFive.Server.Core.Dimensiones.PlantillaDeCorreccion
{
    public class ControlEmocionalPlantilla : IPlantillaCorreccion
    {
        public List<IRespuestaDePlantilla> Respuestas
        {
            get { return GetRespuestaDePlantillas(); }
        }

        private static List<IRespuestaDePlantilla> GetRespuestaDePlantillas()
        {
            return new List<IRespuestaDePlantilla>
                       {
                            new RespuestaDePlantilla{Number =    3, ScoreType = TipoPuntaje.Negative}                           
                          , new RespuestaDePlantilla{Number =    9, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number =  27, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number =  33, ScoreType = TipoPuntaje.Negative}
                           ,new RespuestaDePlantilla{Number =  50, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number =  62, ScoreType = TipoPuntaje.Negative}
                           ,new RespuestaDePlantilla{Number =  69, ScoreType = TipoPuntaje.Negative}
                           ,new RespuestaDePlantilla{Number =  81, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number =  89, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number =  98, ScoreType = TipoPuntaje.Negative}
                           ,new RespuestaDePlantilla{Number = 120, ScoreType = TipoPuntaje.Negative}
                           ,new RespuestaDePlantilla{Number = 122, ScoreType = TipoPuntaje.Positive}
                       };
        }
    }
}