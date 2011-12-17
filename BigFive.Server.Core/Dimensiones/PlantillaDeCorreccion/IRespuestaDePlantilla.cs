using BigFive.Server.Core.Common;

namespace BigFive.Server.Core.Dimensiones.PlantillaDeCorreccion
{
    public interface IRespuestaDePlantilla
    {
       int Number { get; set; }
      TipoPuntaje ScoreType { get; set; }
    }
}