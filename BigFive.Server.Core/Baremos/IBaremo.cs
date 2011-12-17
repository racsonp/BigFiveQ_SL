using System.Collections.Generic;

namespace BigFive.Server.Core.Baremos
{
    public interface IBaremo
    {
        List<Valor> GetValores();
    }
}