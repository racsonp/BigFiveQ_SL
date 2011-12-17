

using BigFive.Server.Core.Dimensiones.PlantillaDeCorreccion;

namespace BigFive.Server.Core.Dimensiones
{
    public interface  ISubDimension
    {

        string Name { get;  }
        string Symbol { get;  }
        int PositiveScore { get; set; }
        int NegativeScore { get; set; }
        int GlobalScore { get; set; }
        string Resultado { get; set; }
        IPlantillaCorreccion PlantillaCorreccion {  get; set; }
      
    }
}