using System.Collections.Generic;
using BigFive.Server.Core.Common;

namespace BigFive.Server.Core.Dimensiones.PlantillaDeCorreccion
{
    public class AperturaExperienciaPlantilla : IPlantillaCorreccion
    {
        public List<IRespuestaDePlantilla> Respuestas
        {
            get { return GetRespuestaDePlantillas(); }
        }

        private static List<IRespuestaDePlantilla> GetRespuestaDePlantillas()
        {
            return new List<IRespuestaDePlantilla>
                       {
                           new RespuestaDePlantilla{Number =    17, ScoreType = TipoPuntaje.Negative}                           
                           ,new RespuestaDePlantilla{Number =    23, ScoreType = TipoPuntaje.Positive}                                                   
                           ,new RespuestaDePlantilla{Number =  35, ScoreType = TipoPuntaje.Negative}                           
                           ,new RespuestaDePlantilla{Number =  41, ScoreType = TipoPuntaje.Positive}                           
                           ,new RespuestaDePlantilla{Number =  47, ScoreType = TipoPuntaje.Negative}
                           ,new RespuestaDePlantilla{Number =  56, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number =  67, ScoreType = TipoPuntaje.Negative}
                           ,new RespuestaDePlantilla{Number = 72, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number = 97, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number = 103, ScoreType = TipoPuntaje.Negative}                           
                           ,new RespuestaDePlantilla{Number = 118, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number = 131, ScoreType = TipoPuntaje.Negative}                           
                       };
        }
    }


   

  



}