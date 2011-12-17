using System.Collections.Generic;

namespace BigFive.Server.Core.Baremos
{
    public class MujeresEE : IBaremo
    {
        public List<Valor> GetValores()
        {
            return new List<Valor>
                       {
                           new Valor {Percentil = 1  , PuntuacionDirectaHasta = 24, PuntuacionT = 27}
                           ,new Valor{Percentil = 1  , PuntuacionDirectaHasta = 36, PuntuacionT = 27}
                           ,new Valor{Percentil = 2  , PuntuacionDirectaHasta = 37, PuntuacionT = 29}
                           ,new Valor{Percentil = 3  , PuntuacionDirectaHasta = 38, PuntuacionT = 31}
                           ,new Valor{Percentil = 4  , PuntuacionDirectaHasta = 40, PuntuacionT = 32}
                           ,new Valor{Percentil = 5  , PuntuacionDirectaHasta = 44, PuntuacionT = 34}
                           ,new Valor{Percentil = 10, PuntuacionDirectaHasta = 49, PuntuacionT = 37}
                           ,new Valor{Percentil = 15, PuntuacionDirectaHasta = 52, PuntuacionT = 40}
                           ,new Valor{Percentil = 20, PuntuacionDirectaHasta = 54, PuntuacionT = 42}
                           ,new Valor{Percentil = 25, PuntuacionDirectaHasta = 57, PuntuacionT = 43}
                           
                           ,new Valor{Percentil = 30, PuntuacionDirectaHasta = 59, PuntuacionT = 44}
                           ,new Valor{Percentil = 35, PuntuacionDirectaHasta = 61, PuntuacionT = 46}
                           ,new Valor{Percentil = 40, PuntuacionDirectaHasta = 62, PuntuacionT = 47}
                           ,new Valor{Percentil = 45, PuntuacionDirectaHasta = 64,PuntuacionT = 49}

                           ,new Valor{Percentil = 50, PuntuacionDirectaHasta = 66, PuntuacionT = 50}
                           
                           ,new Valor{Percentil = 55, PuntuacionDirectaHasta = 68, PuntuacionT = 51}
                           ,new Valor{Percentil = 60, PuntuacionDirectaHasta = 69, PuntuacionT = 53}
                           ,new Valor{Percentil = 65, PuntuacionDirectaHasta = 71, PuntuacionT = 54}
                           ,new Valor{Percentil = 70, PuntuacionDirectaHasta = 73, PuntuacionT = 56}
                           ,new Valor{Percentil = 75, PuntuacionDirectaHasta = 75, PuntuacionT = 57}

                           ,new Valor{Percentil = 80, PuntuacionDirectaHasta = 77, PuntuacionT = 58}
                           ,new Valor{Percentil = 85, PuntuacionDirectaHasta = 80, PuntuacionT = 60}
                           ,new Valor{Percentil = 90, PuntuacionDirectaHasta = 83, PuntuacionT = 63}
                           ,new Valor{Percentil = 95, PuntuacionDirectaHasta = 86, PuntuacionT = 66}
                           ,new Valor{Percentil = 96, PuntuacionDirectaHasta = 87, PuntuacionT = 68}
                           ,new Valor{Percentil = 97, PuntuacionDirectaHasta = 89, PuntuacionT = 69}
                           ,new Valor{Percentil = 98, PuntuacionDirectaHasta = 90, PuntuacionT = 71}
                           ,new Valor{Percentil = 99, PuntuacionDirectaHasta = 120,PuntuacionT = 73}
                           
                       };
        }
    }
}