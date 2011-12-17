using System;
using System.Collections.Generic;
using BigFive.Server.Core.Common;
using BigFive.Server.Core.Process;
using NUnit.Framework;

namespace BigFive.Server.Core.Test
{
    [TestFixture]
    public class ProcesaExamenFromWebTest
    {

        [Test]
        public void RespuestaConZeroOrNulasSet3()
        {
            var proceso = new ProcesaExamen();
            var examen = new List<AnsweredQuiz>();

                var numeroPregunta1 = new Question { Index = 1, Statement = null };
                var respuestaSeleccionada1 = new Response { Statement = null, Value = 0 };
                var examenContestado1 = new AnsweredQuiz(numeroPregunta1, respuestaSeleccionada1);

                var numeroPregunta2 = new Question { Index = 2, Statement = null };
                var respuestaSeleccionada2 = new Response { Statement = null, Value = 5 };
                var examenContestado2 = new AnsweredQuiz(numeroPregunta2, respuestaSeleccionada2);


                examen.Add(examenContestado1);
                examen.Add(examenContestado2);

          var examenCambiado =  proceso.CambiarNulos(examen);

            Assert.AreEqual(3,examenCambiado[0].Response.Value);
            Assert.AreEqual(5, examenCambiado[1].Response.Value);



        }
    }
}
