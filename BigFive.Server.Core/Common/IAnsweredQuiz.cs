

namespace BigFive.Server.Core.Common
{
    public interface IAnsweredQuiz
    {
        IQuestion Question { get; }
        IResponse Response { get; }
        
    }
}