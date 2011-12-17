using System.Linq;
using BigFive.Server.Core.Common;
using BigFive.Server.Core.Data;
using BigFive.Server.Core.Data.PreguntaRespuesta;
using BigFive.Server.Core.Dimensiones.PlantillaDeCorreccion;
using BigFive.Server.Core.Process;
using NUnit.Framework;

using System.Collections.Generic;


namespace BigFive.Server.Core.Test
{
    [TestFixture]
    public class CalculatePointsTest
    {

        public List<IRespuestaDePlantilla> GeneraPlantillaCorrecion()
        {
            var respuestaDePlantillas = new List<IRespuestaDePlantilla>
                                         {
                                             new RespuestaDePlantilla {Number = 3, ScoreType = TipoPuntaje.Negative}
                                             ,
                                             new RespuestaDePlantilla {Number =   9, ScoreType = TipoPuntaje.Positive}
                                             ,new RespuestaDePlantilla {Number = 27, ScoreType = TipoPuntaje.Positive}
                                             ,new RespuestaDePlantilla {Number = 33, ScoreType = TipoPuntaje.Negative}
                                             ,new RespuestaDePlantilla {Number = 50,ScoreType = TipoPuntaje.Positive}
                                             ,new RespuestaDePlantilla {Number = 62,ScoreType = TipoPuntaje.Negative}
                                             ,new RespuestaDePlantilla {Number = 69, ScoreType = TipoPuntaje.Negative}
                                             ,new RespuestaDePlantilla {Number = 81, ScoreType = TipoPuntaje.Positive}
                                             ,new RespuestaDePlantilla {Number = 89,ScoreType = TipoPuntaje.Positive}
                                             ,new RespuestaDePlantilla {Number = 98, ScoreType = TipoPuntaje.Negative}
                                             ,new RespuestaDePlantilla {Number = 120, ScoreType = TipoPuntaje.Negative}
                                             ,new RespuestaDePlantilla {Number = 122, ScoreType = TipoPuntaje.Positive}
                                         };

            return respuestaDePlantillas;
        }

        [Test]
        public void TomaNumerosdPreguntasSumaranPutajePositivo()
        {
            var indicePregunta = new List<int> { 9, 27, 50, 81, 89, 122 }; //numero de preguntas negativas (indice)
            var platillaCorreccion = GeneraPlantillaCorrecion();
            const TipoPuntaje tipo = TipoPuntaje.Positive;

            var calculo = new ProcesarPuntos();
            //devuelve numero de preguntas negativas (indice) segun plantilla de correscion
            List<int> resultado = calculo.GetPlatillaCorrecion(platillaCorreccion, tipo);

            CollectionAssert.AreEqual(indicePregunta, resultado);

        }

        [Test]
        public void TomaNumerosdPreguntasSumaranPutajeNegativo()
        {
            var indicePregunta = new List<int> { 3, 33, 62, 69, 98, 120 };
            var platillaCorreccion = GeneraPlantillaCorrecion();
            const TipoPuntaje tipo = TipoPuntaje.Negative;

            var calculo = new ProcesarPuntos();

            List<int> resultado = calculo.GetPlatillaCorrecion(platillaCorreccion, tipo);

            CollectionAssert.AreEqual(indicePregunta, resultado);
        }

        [Test]
        public void TomaRespuestasQueEstanEnPlatilla()
        {
            //Crea un examen contestado
            var examenContestado = new ExamenBuilder().GetCompletedQuiz();
            //Numero de preguntas que se traeran de ese examen
            var indicePreguntas = new List<int> { 9, 27 };


            var cal = new ProcesarPuntos();
            //Metodo que trae Numero de respeustas del examen
            var respuestasLengh = cal.GetRespuestasByPlantillaCorrecion(indicePreguntas, examenContestado);

            Assert.AreEqual(2, respuestasLengh.Count);


        }

        [Test]
        public void SumaPuntosSegunRespuesta()
        {
            var responseServ = new ResponseDataService();
            var query = from respuesta in responseServ.GetAllResponse()
                        where respuesta.Value == 5 || respuesta.Value == 2
                        select respuesta;

            var calculo = new ProcesarPuntos();
            var resultado = calculo.SumaPuntos(query);

            Assert.AreEqual(7, resultado);

        }
    

    }

}
