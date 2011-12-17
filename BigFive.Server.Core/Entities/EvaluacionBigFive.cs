using System;


namespace BigFive.Server.Core.Entities
{
    public class EvaluacionBigFive : Entity
    {

        public virtual string NombreExamen { get; set; } 
        public virtual DateTime FechaRealizacion { get; set; }
 

        public virtual int Energia{ get; set; }
        public virtual int Teson{ get; set; }
        public virtual int Afabilidad { get; set; }
        public virtual int EstabilidadEmocional { get; set; }
        public virtual int AperturaMental { get; set; }

        public virtual int Distorsion { get; set; }

        public virtual int Dinamismo { get; set; }
        public virtual int Dominancia { get; set; }
        public virtual int Cooperacion { get; set; }
        public virtual int Cordialidad { get; set; }
        public virtual int Escrupolosidad { get; set; }
        public virtual int Perseverancia { get; set; }
        public virtual int ControlEmociones { get; set; }
        public virtual int ControlImpulsos { get; set; }
        public virtual int AperturaCultura { get; set; }
        public virtual int AperturaExperiencia{ get; set; }

    

    }
}