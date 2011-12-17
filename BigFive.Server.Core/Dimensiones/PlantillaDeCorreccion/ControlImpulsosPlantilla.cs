using System.Collections.Generic;
using BigFive.Server.Core.Common;


namespace BigFive.Server.Core.Dimensiones.PlantillaDeCorreccion
{
    public class ControlImpulsosPlantilla : IPlantillaCorreccion
    {
        public List<IRespuestaDePlantilla> Respuestas
        {
            get { return RespuestaBuilder(); }

        }

        private static List<IRespuestaDePlantilla> RespuestaBuilder()
        {
            return new List<IRespuestaDePlantilla>
                       {
                           new RespuestaDePlantilla {Number = 15, ScoreType = TipoPuntaje.Negative}
                           ,
                           new RespuestaDePlantilla {Number = 21, ScoreType = TipoPuntaje.Positive}
                           ,
                           new RespuestaDePlantilla {Number = 43, ScoreType = TipoPuntaje.Positive}
                           ,
                           new RespuestaDePlantilla {Number = 45, ScoreType = TipoPuntaje.Negative}
                           ,
                           new RespuestaDePlantilla {Number = 58, ScoreType = TipoPuntaje.Positive}
                           ,
                           new RespuestaDePlantilla {Number = 63, ScoreType = TipoPuntaje.Negative}
                           ,
                           new RespuestaDePlantilla {Number = 76, ScoreType = TipoPuntaje.Positive}
                           ,
                           new RespuestaDePlantilla {Number = 83, ScoreType = TipoPuntaje.Negative}
                           ,
                           new RespuestaDePlantilla {Number = 91, ScoreType = TipoPuntaje.Positive}
                           ,
                           new RespuestaDePlantilla {Number = 104, ScoreType = TipoPuntaje.Negative}
                           ,
                           new RespuestaDePlantilla {Number = 116, ScoreType = TipoPuntaje.Negative}
                           ,
                           new RespuestaDePlantilla {Number = 119, ScoreType = TipoPuntaje.Positive}

                       };

        }


    }
}