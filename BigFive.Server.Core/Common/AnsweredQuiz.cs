namespace BigFive.Server.Core.Common
{
    public class AnsweredQuiz : IAnsweredQuiz
    {
        private readonly IQuestion _question;
        private readonly IResponse _response;

        public AnsweredQuiz( IQuestion question, IResponse response)
        {
            _question = question;
            _response = response;

        }


        public  virtual IQuestion Question
        {
            get { return _question; }

        }

        public virtual IResponse Response
        {
            get { return _response; }
          
        }
    }

}