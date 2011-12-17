using System.Collections.Generic;

using System.Linq;
using BigFive.Server.Core.Common;
using BigFive.Server.Core.Data.PreguntaRespuesta;

namespace BigFive.Server.Core.Data
{
    public class ExamenBuilder
    {
        public List<AnsweredQuiz> GetCompletedQuiz()
        {

            var qServ = new QuestionDataService();
            var aServ = new ResponseDataService();

            List<IResponseDataObject> responses = Contestaciones.GetAllContestaciones();

            var answeredQuizzes = (from contestacion in responses
                                   let question = qServ.GetQuestionById(contestacion.Index)
                                   let response = aServ.GetResponseById(contestacion.Value)
                                   select new AnsweredQuiz(question, response)).ToList();


            return  answeredQuizzes;
       
        }




    }

    public interface IResponseDataObject
    {
        int Index { get; set; }
        int Value { get; set; }
    }

    public class ResponseDataObject : IResponseDataObject
    {
        public int Index { get; set; }
        public int Value { get; set; }

    }

    class Contestaciones
    {
        public static List<IResponseDataObject> GetAllContestaciones()
        {
            var contestaciones = new List<IResponseDataObject>
                                     {
                                         new ResponseDataObject {Index = 1, Value = 3}
                                         ,
                                         new ResponseDataObject {Index = 2, Value = 3}
                                         ,
                                         new ResponseDataObject() {Index = 3, Value = 3}
                                         ,
                                         new ResponseDataObject() {Index = 4, Value = 4}
                                         ,
                                         new ResponseDataObject() {Index = 5, Value = 3}

                                         ,
                                         new ResponseDataObject() {Index = 6, Value = 1}
                                         ,
                                         new ResponseDataObject() {Index = 7, Value = 3}
                                         ,
                                         new ResponseDataObject() {Index = 8, Value = 3}
                                         ,
                                         new ResponseDataObject() {Index = 9, Value = 4}
                                         ,
                                         new ResponseDataObject() {Index = 10, Value = 3}


                                         ,
                                         new ResponseDataObject() {Index = 11, Value = 2}
                                         ,
                                         new ResponseDataObject() {Index = 12, Value = 1}
                                         ,
                                         new ResponseDataObject() {Index = 13, Value = 1}
                                         ,
                                         new ResponseDataObject() {Index = 14, Value = 4}
                                         ,
                                         new ResponseDataObject() {Index = 15, Value = 2}


                                         ,
                                         new ResponseDataObject() {Index = 16, Value = 5}
                                         ,
                                         new ResponseDataObject() {Index = 17, Value = 4}
                                         ,
                                         new ResponseDataObject() {Index = 18, Value = 3}
                                         ,
                                         new ResponseDataObject() {Index = 19, Value = 3}
                                         ,
                                         new ResponseDataObject() {Index = 20, Value = 4}


                                         ,
                                         new ResponseDataObject() {Index = 21, Value = 3}
                                         ,
                                         new ResponseDataObject() {Index = 22, Value = 4}
                                         ,
                                         new ResponseDataObject() {Index = 23, Value = 3}
                                         ,
                                         new ResponseDataObject() {Index = 24, Value = 3}
                                         ,
                                         new ResponseDataObject() {Index = 25, Value = 2}


                                         ,
                                         new ResponseDataObject() {Index = 26, Value = 4}
                                         ,
                                         new ResponseDataObject() {Index = 27, Value = 4}
                                         ,
                                         new ResponseDataObject() {Index = 28, Value = 4}
                                         ,
                                         new ResponseDataObject() {Index = 29, Value = 4}
                                         ,
                                         new ResponseDataObject() {Index = 30, Value = 3}


                                         ,
                                         new ResponseDataObject() {Index = 31, Value = 3}
                                         ,
                                         new ResponseDataObject() {Index = 32, Value = 3}
                                         ,
                                         new ResponseDataObject() {Index = 33, Value = 2}
                                         ,
                                         new ResponseDataObject() {Index = 34, Value = 4}
                                         ,
                                         new ResponseDataObject() {Index = 35, Value = 4}

                                         ,
                                         new ResponseDataObject() {Index = 36, Value = 1}
                                         ,
                                         new ResponseDataObject() {Index = 37, Value = 4}
                                         ,
                                         new ResponseDataObject() {Index = 38, Value = 4}
                                         ,
                                         new ResponseDataObject() {Index = 39, Value = 3}
                                         ,
                                         new ResponseDataObject() {Index = 40, Value = 2}

                                         ,
                                         new ResponseDataObject() {Index = 41, Value = 1}
                                         ,
                                         new ResponseDataObject() {Index = 42, Value = 4}
                                         ,
                                         new ResponseDataObject() {Index = 43, Value = 3}
                                         ,
                                         new ResponseDataObject() {Index = 44, Value = 3}
                                         ,
                                         new ResponseDataObject() {Index = 45, Value = 2}


                                         ,
                                         new ResponseDataObject {Index = 46, Value = 4}
                                         ,
                                         new ResponseDataObject() {Index = 47, Value = 4}
                                         ,
                                         new ResponseDataObject() {Index = 48, Value = 3}
                                         ,
                                         new ResponseDataObject() {Index = 49, Value = 3}
                                         ,
                                         new ResponseDataObject() {Index = 50, Value = 2}

                                         ,
                                         new ResponseDataObject() {Index = 51, Value = 4}
                                         ,
                                         new ResponseDataObject() {Index = 52, Value = 4}
                                         ,
                                         new ResponseDataObject() {Index = 53, Value = 4}
                                         ,
                                         new ResponseDataObject() {Index = 54, Value = 4}
                                         ,
                                         new ResponseDataObject() {Index = 55, Value = 4}


                                         ,
                                         new ResponseDataObject() {Index = 56, Value = 3}
                                         ,
                                         new ResponseDataObject() {Index = 57, Value = 3}
                                         ,
                                         new ResponseDataObject() {Index = 58, Value = 4}
                                         ,
                                         new ResponseDataObject() {Index = 59, Value = 3}
                                         ,
                                         new ResponseDataObject() {Index = 60, Value = 5}


                                         ,
                                         new ResponseDataObject() {Index = 61, Value = 3}
                                         ,
                                         new ResponseDataObject() {Index = 62, Value = 3}
                                         ,
                                         new ResponseDataObject() {Index = 63, Value = 3}
                                         ,
                                         new ResponseDataObject() {Index = 64, Value = 5}
                                         ,
                                         new ResponseDataObject() {Index = 65, Value = 4}


                                         ,new ResponseDataObject(){Index = 66, Value = 3}
                                         ,new ResponseDataObject(){Index = 67, Value = 5}
                                         ,new ResponseDataObject(){Index = 68, Value = 4}
                                         ,new ResponseDataObject(){Index = 69, Value = 3}
                                         ,new ResponseDataObject(){Index = 70, Value = 5}

                                         ,new ResponseDataObject(){Index = 71, Value = 3}
                                         ,new ResponseDataObject(){Index = 72, Value = 5}
                                         ,new ResponseDataObject(){Index = 73, Value = 5}
                                         ,new ResponseDataObject(){Index = 74, Value = 5}
                                         ,new ResponseDataObject(){Index = 75, Value = 4}


                                         ,new ResponseDataObject(){Index = 76, Value = 3}
                                         ,new ResponseDataObject(){Index = 77, Value = 4}
                                         ,new ResponseDataObject() {Index = 78, Value = 4}
                                         ,new ResponseDataObject(){Index = 79, Value = 2}
                                         ,new ResponseDataObject(){Index = 80, Value = 4}


                                         ,new ResponseDataObject(){Index = 81, Value = 3}
                                         ,new ResponseDataObject(){Index = 82, Value = 4}
                                         ,new ResponseDataObject(){Index = 83, Value = 2}
                                         ,new ResponseDataObject(){Index = 84, Value = 1}
                                         ,new ResponseDataObject(){Index = 85, Value = 4}

                                         ,new ResponseDataObject(){Index = 86, Value = 5}
                                         ,new ResponseDataObject(){Index = 87, Value = 3}
                                         ,new ResponseDataObject(){Index = 88, Value = 3}
                                         ,new ResponseDataObject(){Index = 89, Value = 4}
                                         ,new ResponseDataObject(){Index = 90, Value = 5}
                                         
                                         
                                         ,new ResponseDataObject(){Index = 91, Value = 2}
                                         ,new ResponseDataObject(){Index  =92, Value = 1}
                                         ,new ResponseDataObject(){Index = 93, Value = 5}
                                         ,new ResponseDataObject(){Index = 94, Value = 4}
                                         ,new ResponseDataObject(){Index = 95, Value = 3}

                                             
                                         ,new ResponseDataObject(){Index = 96, Value = 3}
                                         ,new ResponseDataObject(){Index = 97,Value = 5}
                                         ,new ResponseDataObject(){Index = 98, Value = 3}
                                         ,new ResponseDataObject(){Index = 99, Value = 4}
                                         ,new ResponseDataObject(){Index = 100, Value = 4}


                                         ,new ResponseDataObject(){Index = 101, Value = 2}
                                         ,new ResponseDataObject(){Index = 102, Value = 3}
                                         ,new ResponseDataObject(){Index = 103, Value = 4}
                                         ,new ResponseDataObject(){Index = 104, Value = 3}
                                         , new ResponseDataObject(){Index = 105, Value = 4}


                                         ,new ResponseDataObject(){Index = 106, Value = 4}
                                         ,new ResponseDataObject(){Index = 107, Value = 4}
                                         ,new ResponseDataObject(){Index = 108, Value = 3}
                                         ,new ResponseDataObject(){Index = 109, Value = 4}
                                         ,new ResponseDataObject(){Index = 110, Value = 4}

                                         ,new ResponseDataObject(){Index = 111, Value = 5}
                                         ,new ResponseDataObject(){Index = 112, Value = 3}
                                         ,new ResponseDataObject(){Index = 113, Value = 1}
                                         ,new ResponseDataObject(){Index = 114, Value = 4}
                                         ,new ResponseDataObject(){Index = 115, Value = 4}

                                         ,new ResponseDataObject(){Index = 116, Value = 3}
                                         ,new ResponseDataObject(){Index = 117, Value = 2}
                                         ,new ResponseDataObject(){Index = 118, Value = 4}
                                         ,new ResponseDataObject(){Index = 119, Value = 3}
                                         ,new ResponseDataObject(){Index = 120, Value = 2}


                                         ,new ResponseDataObject(){Index = 121,Value = 5}
                                         ,new ResponseDataObject(){Index = 122, Value = 4}
                                         ,new ResponseDataObject(){Index=123, Value = 3}
                                         ,new ResponseDataObject(){Index = 124, Value = 4}
                                         ,new ResponseDataObject(){Index = 125, Value = 4}



                                         ,new ResponseDataObject (){Index = 126, Value = 3}
                                         ,new ResponseDataObject(){Index   = 127, Value = 2}
                                         ,new ResponseDataObject(){Index = 128, Value = 4}
                                         ,new ResponseDataObject(){Index = 129, Value = 3}
                                         ,new ResponseDataObject(){Index = 130, Value = 5}


                                         ,new ResponseDataObject(){Index   = 131, Value = 3}
                                         ,new ResponseDataObject(){Index = 132, Value = 5}


                                     };

            return contestaciones;
        }
    }


}