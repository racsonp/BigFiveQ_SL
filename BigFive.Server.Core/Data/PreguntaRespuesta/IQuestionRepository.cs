using System.Collections.Generic;
using BigFive.Server.Core.Common;

namespace BigFive.Server.Core.Data.PreguntaRespuesta
{
    public interface IQuestionRepository
    {
        IQuestion GetQuestionById(  int index);
        List<Question> GetAllQuestion();


    }
}