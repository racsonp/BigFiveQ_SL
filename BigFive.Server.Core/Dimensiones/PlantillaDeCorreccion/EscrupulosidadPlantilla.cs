using System.Collections.Generic;
using BigFive.Server.Core.Common;


namespace BigFive.Server.Core.Dimensiones.PlantillaDeCorreccion
{
    public class EscrupulosidadPlantilla : IPlantillaCorreccion
    {
        public List<IRespuestaDePlantilla> Respuestas
        {
            get { return GetRespuestaDePlantillas(); }
        }

        private static List<IRespuestaDePlantilla> GetRespuestaDePlantillas()
        {
            return new List<IRespuestaDePlantilla>
                       {                            
                           new RespuestaDePlantilla{Number =   2, ScoreType = TipoPuntaje.Negative}
                           ,new RespuestaDePlantilla{Number = 8, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number = 26, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number =  32, ScoreType = TipoPuntaje.Negative}
                           ,new RespuestaDePlantilla{Number = 57, ScoreType = TipoPuntaje.Positive}                                                      
                           ,new RespuestaDePlantilla{Number = 66, ScoreType = TipoPuntaje.Negative}
                           ,new RespuestaDePlantilla{Number = 79, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number = 82, ScoreType = TipoPuntaje.Negative}
                           ,new RespuestaDePlantilla{Number = 106, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number = 110, ScoreType = TipoPuntaje.Negative}
                           ,new RespuestaDePlantilla{Number = 129, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number = 132, ScoreType = TipoPuntaje.Negative}
                       };
        }
    }
}