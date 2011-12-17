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
            var transformaPuntos = new TransformacionPuntaje();

            //ENERGIA
            var dinamismo = new Dinamismo();
            var dominacia = new Dominacia();

            _calculador.Procesar(examenContestado, dinamismo);
            _calculador.Procesar(examenContestado, dominacia);

            evaluacion.Dinamismo = dinamismo.GlobalScore;
            evaluacion.Dominancia = dominacia.GlobalScore;
            evaluacion.Energia = dominacia.GlobalScore + dinamismo.GlobalScore;
            evaluacion.DinamismoT = transformaPuntos.Dinamismo(dinamismo.GlobalScore, genero);
            evaluacion.DominanciaT = transformaPuntos.Dominacia(dominacia.GlobalScore, genero);
            evaluacion.EnergiaT = transformaPuntos.Energia((dominacia.GlobalScore + dinamismo.GlobalScore), genero);
            
            
            //AFABILIDAD
            var cooperacion = new Cooperacion();
            var cordialiadad = new Cordialidad();

            _calculador.Procesar(examenContestado, cordialiadad);
            _calculador.Procesar(examenContestado, cooperacion);
            evaluacion.Cordialidad = cordialiadad.GlobalScore;
            evaluacion.Cooperacion = cooperacion.GlobalScore;
            evaluacion.Afabilidad = cordialiadad.GlobalScore + cooperacion.GlobalScore;
            evaluacion.CordialidadT = transformaPuntos.Cordialidad(cordialiadad.GlobalScore, genero);
            evaluacion.CooperacionT = transformaPuntos.Cooperacion(cooperacion.GlobalScore, genero);
            evaluacion.AfabilidadT = transformaPuntos.Afabilidad((cordialiadad.GlobalScore + cooperacion.GlobalScore), genero);

            //TESON
            var escrupulosidad = new Escrupulasidad();
            var perseverancia = new Perseverancia();
            _calculador.Procesar(examenContestado, escrupulosidad);
            _calculador.Procesar(examenContestado, perseverancia);

            evaluacion.Perseverancia = perseverancia.GlobalScore;
            evaluacion.Escrupolosidad = escrupulosidad.GlobalScore;
            evaluacion.Teson = perseverancia.GlobalScore + escrupulosidad.GlobalScore;

            evaluacion.PerseveranciaT = transformaPuntos.Perseverncia(perseverancia.GlobalScore, genero);
            evaluacion.EscrupolosidadT = transformaPuntos.Escrupulosidad(escrupulosidad.GlobalScore, genero);
            evaluacion.TesonT = transformaPuntos.Teson((perseverancia.GlobalScore + escrupulosidad.GlobalScore), genero);


            //Escatabilidad emocional
            var controlEmocional = new ControlEmociones();
            var controlImpulsos = new ControlImpulsos();
            _calculador.Procesar(examenContestado, controlEmocional);
            _calculador.Procesar(examenContestado, controlImpulsos);

            evaluacion.ControlEmociones = controlEmocional.GlobalScore;
            evaluacion.ControlImpulsos = controlImpulsos.GlobalScore;
            evaluacion.EstabilidadEmocional = controlImpulsos.GlobalScore + controlEmocional.GlobalScore;

            evaluacion.ControlEmocionesT = transformaPuntos.ControlEmociones(controlEmocional.GlobalScore, genero);
            evaluacion.ControlImpulsosT = transformaPuntos.ControlImpulsos(controlImpulsos.GlobalScore, genero);
            evaluacion.EstabilidadEmocionalT =transformaPuntos.EstabilidadEmocional((controlImpulsos.GlobalScore + controlEmocional.GlobalScore), genero);


            //APERTURA MENTAL

            var aperturaCultura = new AperturaCultura();
            var aperturaExperincia = new AperturaExperiencia();
            _calculador.Procesar(examenContestado, aperturaExperincia);
            _calculador.Procesar(examenContestado, aperturaCultura);

            evaluacion.AperturaCultura = aperturaCultura.GlobalScore;
            evaluacion.AperturaExperiencia = aperturaExperincia.GlobalScore;
            evaluacion.AperturaMental = aperturaExperincia.GlobalScore + aperturaCultura.GlobalScore;

            evaluacion.AperturaCulturaT = transformaPuntos.AperturaCultura(aperturaCultura.GlobalScore, genero);
            evaluacion.AperturaExperienciaT = transformaPuntos.AperturaExperiensa(aperturaExperincia.GlobalScore, genero);
            evaluacion.AperturaMentalT =
                transformaPuntos.AperturaMentall((aperturaExperincia.GlobalScore + aperturaCultura.GlobalScore), genero);


            //Distorcion 
            var distorcion = new Distorsion();
            _calculador.Procesar(examenContestado, distorcion);

            evaluacion.Distorsion = distorcion.GlobalScore;

            evaluacion.DistorsionT = transformaPuntos.Distorcion(distorcion.GlobalScore, genero);

            return evaluacion;
        }

    }
}