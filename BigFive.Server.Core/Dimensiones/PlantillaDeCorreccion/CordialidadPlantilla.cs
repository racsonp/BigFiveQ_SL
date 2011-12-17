using System.Collections.Generic;
using BigFive.Server.Core.Common;


namespace BigFive.Server.Core.Dimensiones.PlantillaDeCorreccion
{
    public class CordialidadPlantilla : IPlantillaCorreccion
    {
        public List<IRespuestaDePlantilla> Respuestas
        {
            get { return GetRespuestaDePlantillas(); }
        }

        private static List<IRespuestaDePlantilla> GetRespuestaDePlantillas()
        {
            return new List<IRespuestaDePlantilla>
                       {                            
                            new RespuestaDePlantilla{Number =   16, ScoreType = TipoPuntaje.Negative}
                           ,new RespuestaDePlantilla{Number = 22, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number =  40, ScoreType = TipoPuntaje.Negative}
                           ,new RespuestaDePlantilla{Number = 44, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number = 52, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number = 65, ScoreType = TipoPuntaje.Negative}
                           ,new RespuestaDePlantilla{Number = 74, ScoreType = TipoPuntaje.Negative}
                           ,new RespuestaDePlantilla{Number = 88, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number = 93, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number = 108, ScoreType = TipoPuntaje.Negative}
                           ,new RespuestaDePlantilla{Number = 126, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number = 128, ScoreType = TipoPuntaje.Negative}
                       };
        }
    }
}