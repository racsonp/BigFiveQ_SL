using System.Collections.Generic;
using BigFive.Server.Core.Common;


namespace BigFive.Server.Core.Dimensiones.PlantillaDeCorreccion
{
    public class DominaciaPlanilla: IPlantillaCorreccion
    {
        public List<IRespuestaDePlantilla> Respuestas
        {
            get { return GetRespuestaDePlantillas(); }
        }

        private static List<IRespuestaDePlantilla> GetRespuestaDePlantillas()
        {
            return new List<IRespuestaDePlantilla>
                       {                            
                           new RespuestaDePlantilla{Number =   13, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number = 19, ScoreType = TipoPuntaje.Negative}
                           ,new RespuestaDePlantilla{Number =  31, ScoreType = TipoPuntaje.Negative}
                           ,new RespuestaDePlantilla{Number = 39, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number = 59, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number = 61, ScoreType = TipoPuntaje.Negative}
                           ,new RespuestaDePlantilla{Number = 71, ScoreType = TipoPuntaje.Negative}
                           ,new RespuestaDePlantilla{Number = 73, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number = 95, ScoreType = TipoPuntaje.Negative}
                           ,new RespuestaDePlantilla{Number = 102, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number = 117, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number = 123, ScoreType = TipoPuntaje.Negative}      
                       };
        }
    }
}