using BigFive.Server.Core.Entities;
using BigFive.Server.Core.Process;
using NUnit.Framework;

namespace BigFive.Server.Core.Test
{
    [TestFixture]
    public class PuntuacionDirectaToPuntuacionTransformada
    {
        [Test]
        public void TransformaDimencionEnergiaMasculino()
        {
            const Genero genero = Genero.Masculino;            
            const int puntajeDirecto = 76;
            var transformar = new TransformacionPuntaje();
            Assert.AreEqual(50, transformar.Energia(puntajeDirecto, genero));
        }
         
        [Test]
        public void TransformaDimencionEnergiaFemenino()
        {
            const Genero genero = Genero.Femenino;
            const int puntajeDirecto = 75;
            var transformar = new TransformacionPuntaje();
            Assert.AreEqual(50, transformar.Energia(puntajeDirecto, genero));
        }
         [Test]
        public void TransformaDimencionTesonMasculino()
        {
            const Genero genero = Genero.Masculino;
            const int puntajeDirecto = 69;
            var transformar = new TransformacionPuntaje();
            Assert.AreEqual(40, transformar.Teson(puntajeDirecto, genero));
        }
         [Test]
        public void TransformaDimencionTesonFemenino()
        {
            const Genero genero = Genero.Femenino;
            const int puntajeDirecto = 71;
            var transformar = new TransformacionPuntaje();
            Assert.AreEqual(40, transformar.Teson(puntajeDirecto, genero));
        }
         

        [Test]
        public void TransformaSubDimencionDinamismoMasculino()
        {
            const Genero genero = Genero.Masculino;
            const int puntajeDirecto = 36;
            var transformar = new TransformacionPuntaje();
            Assert.AreEqual(43, transformar.Dinamismo(puntajeDirecto, genero));
        }
        [Test]
        public void TransformaSubDimencionDinamismoFemenino()
        {
            const Genero genero = Genero.Femenino;
            const int puntajeDirecto = 26;
            var transformar = new TransformacionPuntaje();
            Assert.AreEqual(29, transformar.Dinamismo(puntajeDirecto, genero));
        }
         [Test]
        public void TransformaSubDimencionCeMasculino()
        {
            const Genero genero = Genero.Masculino;
            const int puntajeDirecto = 46;
            var transformar = new TransformacionPuntaje();
            Assert.AreEqual(66, transformar.ControlEmociones(puntajeDirecto, genero));
        }
         [Test]
        public void TransformaSubDimencionCeFemenino()
        {
            const Genero genero = Genero.Femenino;
            const int puntajeDirecto = 44;
            var transformar = new TransformacionPuntaje();
            Assert.AreEqual(66, transformar.ControlEmociones(puntajeDirecto, genero));
        }
    }
}