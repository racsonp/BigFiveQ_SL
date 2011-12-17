using System;
using System.Collections.Generic;
using System.Linq;
using BigFive.Server.Core.Common;
using BigFive.Server.Core.Entities;
using BigFive.Server.Core.Process;

namespace BigFive.Server.Core
{
    public class ProcesaExamen
    {
        public EvaluacionBigFive Evaluacion;
        public ProcesaExamen()
        {
            Evaluacion = new EvaluacionBigFive();
        }
        public bool ValidadNuemroContestaciones(List<AnsweredQuiz> examen)
        {
            var setentaPorciento = (Convert.ToDouble(examen.Count)*0.1);
            var numeroMinimo = examen.Count- Math.Floor(setentaPorciento);
            var numeroNulos = examen.Count(contetacion => contetacion.Response.Value == 0);
            return numeroNulos <= numeroMinimo;
        }

        public PuntajeBigFive ProcesarExamen(List<AnsweredQuiz> examen, Genero genero)
        {
            examen = CambiarNulos(examen);            
            var calificacion = new EvaluaExamenBfq().Calcular(examen, genero);
            return calificacion;
        }

        public List<AnsweredQuiz> CambiarNulos(List<AnsweredQuiz> examen)
        {
            foreach (var r in examen)
            {
                if (r.Response.Value == 0)
                {
                    r.Response.Value = 3;
                }
            }
            return examen;
        }
    }
}
