using System.Collections.Generic;

namespace BigFive.Server.Core.Dimensiones.PlantillaDeCorreccion
{
    public interface IPlantillaCorreccion
    {
        List<IRespuestaDePlantilla> Respuestas { get; }
    }
}