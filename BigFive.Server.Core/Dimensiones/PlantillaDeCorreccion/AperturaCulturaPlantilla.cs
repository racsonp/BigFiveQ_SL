using System.Collections.Generic;
using BigFive.Server.Core.Common;

namespace BigFive.Server.Core.Dimensiones.PlantillaDeCorreccion
{
    public class AperturaCulturaPlantilla : IPlantillaCorreccion
    {
        public List<IRespuestaDePlantilla> Respuestas
        {
            get { return GetRespuestaDePlantillas(); }
        }

 
        private static List<IRespuestaDePlantilla> GetRespuestaDePlantillas()
        {
            return new List<IRespuestaDePlantilla>
                       {
                              new RespuestaDePlantilla{Number =    5, ScoreType = TipoPuntaje.Positive}                           
                            , new RespuestaDePlantilla{Number =   11, ScoreType = TipoPuntaje.Negative}
                           ,new RespuestaDePlantilla{Number =  29, ScoreType = TipoPuntaje.Positive}                       
                           ,new RespuestaDePlantilla{Number = 42, ScoreType = TipoPuntaje.Negative}
                           ,new RespuestaDePlantilla{Number =  55, ScoreType = TipoPuntaje.Negative}
                           ,new RespuestaDePlantilla{Number =  60, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number =  77, ScoreType = TipoPuntaje.Negative}
                           ,new RespuestaDePlantilla{Number =  87, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number =  90, ScoreType = TipoPuntaje.Negative}
                           ,new RespuestaDePlantilla{Number = 105, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number = 112, ScoreType = TipoPuntaje.Positive}
                           ,new RespuestaDePlantilla{Number = 124, ScoreType = TipoPuntaje.Negative}                           
                       };
        }
    }
}