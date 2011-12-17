using System.Collections.Generic;
using BigFive.Server.Core.Common;
using BigFive.Server.Core.Dimensiones;
using BigFive.Server.Core.Entities;


namespace BigFive.Server.Core.Process
{
    public class EvaluaExamenBfq
    {
        private CalculaPuntajeDimension _calculador;

        public PuntajeBigFive Calcular(List<AnsweredQuiz> examenContestado, Genero genero)
        {

            var evaluacion = new PuntajeBigFive();

            _calculador = new CalculaPuntajeDimension();

            //ENERGIA
            var dinamismo = new Dinamismo();
            var dominacia = new Dominacia();

            _calculador.Procesar(examenContestado, dinamismo);
            _calculador.Procesar(examenContestado, dominacia);

            // Converi Puntuacion Directa a puntuacion Tranforamda
             //dinamismo.GlobalScore;
            //dominacia.GlobalScore;

            evaluacion.Dinamismo = dinamismo.GlobalScore;
            evaluacion.Dominancia = dominacia.GlobalScore;
            evaluacion.Energia = dominacia.GlobalScore + dinamismo.GlobalScore;

            //AFABILIDAD
            var cooperacion = new Cooperacion();
            var cordialiadad = new Cordialidad();

            _calculador.Procesar(examenContestado, cordialiadad);
            _calculador.Procesar(examenContestado, cooperacion);
            evaluacion.Cordialidad = cordialiadad.GlobalScore;
            evaluacion.Cooperacion = cooperacion.GlobalScore;
            evaluacion.Afabilidad = cordialiadad.GlobalScore + cooperacion.GlobalScore;

            //TESON
            var escrupulosidad = new Escrupulasidad();
            var perseverancia = new Perseverancia();
            _calculador.Procesar(examenContestado, escrupulosidad);
            _calculador.Procesar(examenContestado, perseverancia);

            evaluacion.Perseverancia = perseverancia.GlobalScore;
            evaluacion.Escrupolosidad = escrupulosidad.GlobalScore;
            evaluacion.Teson = perseverancia.GlobalScore + escrupulosidad.GlobalScore;


            //Escatabilidad emocional
            var controlEmocional = new ControlEmociones();
            var controlImpulsos = new ControlImpulsos();
            _calculador.Procesar(examenContestado, controlEmocional);
            _calculador.Procesar(examenContestado, controlImpulsos);

            evaluacion.ControlEmociones = controlEmocional.GlobalScore;
            evaluacion.ControlImpulsos = controlImpulsos.GlobalScore;
            evaluacion.EstabilidadEmocional = controlImpulsos.GlobalScore + controlEmocional.GlobalScore;

            //APERTURA MENTAL

            var aperturaCultura = new AperturaCultura();
            var aperturaExperincia = new AperturaExperiencia();
            _calculador.Procesar(examenContestado, aperturaExperincia);
            _calculador.Procesar(examenContestado, aperturaCultura);

            evaluacion.AperturaCultura = aperturaCultura.GlobalScore;
            evaluacion.AperturaExperiencia = aperturaExperincia.GlobalScore;
            evaluacion.AperturaMental = aperturaExperincia.GlobalScore + aperturaCultura.GlobalScore;

            //Distorcion 
            var distorcion = new Distorsion();
            _calculador.Procesar(examenContestado, distorcion);

            evaluacion.Distorsion = distorcion.GlobalScore;


            return evaluacion;
        }

    }
}