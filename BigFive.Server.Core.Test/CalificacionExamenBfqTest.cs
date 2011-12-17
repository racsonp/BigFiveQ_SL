
using BigFive.Server.Core.Data;
using BigFive.Server.Core.Entities;
using BigFive.Server.Core.Process;
using NUnit.Framework;

namespace BigFive.Server.Core.Test
{
    [TestFixture]
    public class CalificacionExamenBfqTest
    {
        [Test]
        public void EvaluaExamenDemo()
        {
           var examenContestado = new ExamenBuilder().GetCompletedQuiz();
            
            var evaluador= new EvaluaExamenBfq();

            var calificacion = evaluador.Calcular(examenContestado, Genero.Femenino);




            Assert.AreEqual(33, calificacion.Dinamismo);
            Assert.AreEqual(35, calificacion.Dominancia);
            Assert.AreEqual(68, calificacion.Energia);



            //Revisar puntajes de Coperacion LA HOJA DE DOCUMETACION EJEMPLO TIENE 32
            //posible error en documentacion
            Assert.AreEqual(33, calificacion.Cooperacion);
            Assert.AreEqual(35, calificacion.Cordialidad);
            Assert.AreEqual(68, calificacion.Afabilidad);

            Assert.AreEqual(33, calificacion.Escrupolosidad);
            Assert.AreEqual(34, calificacion.Perseverancia);
            Assert.AreEqual(67, calificacion.Teson);

            Assert.AreEqual(41, calificacion.ControlEmociones);
            Assert.AreEqual(39, calificacion.ControlImpulsos);
            Assert.AreEqual(80, calificacion.EstabilidadEmocional);


            Assert.AreEqual(35, calificacion.AperturaCultura);
            Assert.AreEqual(33, calificacion.AperturaExperiencia);
            Assert.AreEqual(68, calificacion.AperturaMental);

            Assert.AreEqual(23, calificacion.Distorsion);

            
        }
        
    }
}