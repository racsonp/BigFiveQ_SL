using BigFive.Server.Core.Common;
using BigFive.Server.Core.Data;
using BigFive.Server.Core.Dimensiones;
using BigFive.Server.Core.Process;
using NUnit.Framework;

namespace BigFive.Server.Core.Test
{
    [TestFixture]
    public class CalculoPuntajesDimensionesTest
    {
        

        [Test]
        public  void  CalculoDemencionCe()
        {
            var examenContestado = new ExamenBuilder().GetCompletedQuiz();
            var dimencion = new ControlEmociones();

            var calculador = new CalculaPuntajeDimension();
           var result = calculador.Procesar(examenContestado, dimencion);
            dimencion.GlobalScore = result.GlobalScore;
            dimencion.NegativeScore = result.NegativeScore;
            dimencion.PositiveScore = result.PositiveScore;


            Assert.AreEqual(16,dimencion.NegativeScore);
            Assert.AreEqual(21, dimencion.PositiveScore);
            Assert.AreEqual(41, dimencion.GlobalScore);

            Assert.AreEqual("Ce=36+21-16=41", dimencion.Resultado);

        }

    [Test]
        public void  CalculoDiemncionCi()
    {
        var examenContestado = new ExamenBuilder().GetCompletedQuiz();
        var dimencion = new ControlImpulsos();

        var calculador = new CalculaPuntajeDimension();
        var result = calculador.Procesar(examenContestado, dimencion);
        dimencion.GlobalScore = result.GlobalScore;
        dimencion.NegativeScore = result.NegativeScore;
        dimencion.PositiveScore = result.PositiveScore;


        Assert.AreEqual(15, dimencion.NegativeScore);
        Assert.AreEqual(18, dimencion.PositiveScore);
        Assert.AreEqual(39, dimencion.GlobalScore);
    }
        

        [Test]
        public  void CalculaDimencionEstabilidadEmocional()
        {
            var calculador = new CalculaPuntajeDimension();
            var examenContestado = new ExamenBuilder().GetCompletedQuiz();
            var evaluacion = new PuntajeBigFive();

            //Estabilidad emocional
            var controlEmocional = new ControlEmociones();
            var controlImpulsos = new ControlImpulsos();
            calculador.Procesar(examenContestado, controlEmocional);
            calculador.Procesar(examenContestado, controlImpulsos);

            evaluacion.ControlEmociones = controlEmocional.GlobalScore;
            evaluacion.ControlImpulsos = controlImpulsos.GlobalScore;
            evaluacion.EstabilidadEmocional = controlImpulsos.GlobalScore + controlEmocional.GlobalScore;

            Assert.AreEqual(41, evaluacion.ControlEmociones);
            Assert.AreEqual(39, evaluacion.ControlImpulsos);
            Assert.AreEqual(80, evaluacion.EstabilidadEmocional);
        }
    }
}