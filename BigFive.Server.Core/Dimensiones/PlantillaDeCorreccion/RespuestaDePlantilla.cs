using BigFive.Server.Core.Common;

namespace BigFive.Server.Core.Dimensiones.PlantillaDeCorreccion
{
    public  class RespuestaDePlantilla : IRespuestaDePlantilla
    {
        public int Number { get; set; }
        public TipoPuntaje ScoreType { get; set; }
    }
}