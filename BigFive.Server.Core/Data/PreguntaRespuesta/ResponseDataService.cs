using System.Collections.Generic;
using System.Linq;
using BigFive.Server.Core.Common;

namespace BigFive.Server.Core.Data.PreguntaRespuesta
{
    public class ResponseDataService : IResponseRepository
    {

     
        public  IResponse GetResponseById(int id)
        {
            var query = from respuesta in ResposeDataObjectService.GetAllResponses()
                        where respuesta.Value == id
                        select respuesta;
            return (IResponse) query.First();

        }

       public  IEnumerable<IResponse> GetAllResponse()
       {
           var query = from respuestas in ResposeDataObjectService.GetAllResponses()
                       select respuestas;
           return query;

       }

        }


    class ResposeDataObjectService
    {
        public static List<IResponse> GetAllResponses()
        {
            var responses = new List<IResponse>
                                {
                                    new Response {Statement = "Completamente falso para mí.", Value = 1}
                                    ,
                                    new Response {Statement = "Bastante falso para mí." ,Value = 2}
                                    ,
                                    new Response {Statement = "Ni verdadero ni falso para mí.", Value = 3}
                                    ,
                                    new Response {Statement = "Bastante verdadero para mí.", Value = 4}
                                    ,
                                    new Response {Statement = "Completamente verdadero para mí.", Value = 5}
                                };

            return responses;

        }
    }
}