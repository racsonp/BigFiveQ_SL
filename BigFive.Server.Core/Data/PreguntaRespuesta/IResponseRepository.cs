using System.Collections.Generic;
using BigFive.Server.Core.Common;

namespace BigFive.Server.Core.Data.PreguntaRespuesta
{
    public interface IResponseRepository
    {
        IResponse GetResponseById(int id);
        IEnumerable<IResponse> GetAllResponse();
    }
}