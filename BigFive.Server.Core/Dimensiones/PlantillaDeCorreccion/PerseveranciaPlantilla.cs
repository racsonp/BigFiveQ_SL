using System.Collections.Generic;
using BigFive.Server.Core.Common;

namespace BigFive.Server.Core.Dimensiones.PlantillaDeCorreccion
{
    public class PerseveranciaPlantilla : IPlantillaCorreccion
    {
        public List<IRespuestaDePlantilla> Respuestas
        {
            get { return GetRespuestaDePlantillas(); }
        }

        private static List<IRespuestaDePlantilla> GetRespuestaDePlantillas()
        {
            return new List<IRespuestaDePlantilla>
                       {                            
                           new RespuestaDePlantilla{Number =   14, ScoreType = TipoPuntaje.Negative}
                           ,new RespuestaDePlantilla{Number = 20, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number =  38, ScoreType = TipoPuntaje.Negative}
                           ,new RespuestaDePlantilla{Number = 46, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number = 49, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number = 54, ScoreType = TipoPuntaje.Negative}
                           ,new RespuestaDePlantilla{Number = 75, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number = 85, ScoreType = TipoPuntaje.Negative}
                           ,new RespuestaDePlantilla{Number = 96, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number = 107, ScoreType = TipoPuntaje.Negative}
                           ,new RespuestaDePlantilla{Number = 115, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number = 125, ScoreType = TipoPuntaje.Negative}
                       };
        }
    }
}