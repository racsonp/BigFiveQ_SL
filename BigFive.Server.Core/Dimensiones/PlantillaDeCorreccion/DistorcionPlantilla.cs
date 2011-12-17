using System.Collections.Generic;
using BigFive.Server.Core.Common;

namespace BigFive.Server.Core.Dimensiones.PlantillaDeCorreccion
{
    public class DistorcionPlantilla : IPlantillaCorreccion
    {
        public List<IRespuestaDePlantilla> Respuestas
        {
            get { return GetRespuestaDePlantillas(); }
        }

        private static List<IRespuestaDePlantilla> GetRespuestaDePlantillas()
        {
            return new List<IRespuestaDePlantilla>
                       {                            
                           new RespuestaDePlantilla{Number =    6, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number =  12, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number =  18, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number =  24, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number =  30, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number =  36, ScoreType = TipoPuntaje.Positive}                           
                           ,new RespuestaDePlantilla{Number =  80, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number =  84, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number =  92, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number =  101, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number =  113, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number =  127, ScoreType = TipoPuntaje.Positive}                           
                       };
        }
    }
}