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


        //Recordar  que hay puntuacion Directa y 
        //puntuacion Transformada por los baremos ( usada para interpretar ( graficar ) )
            

        public virtual int EnergiaT  { get; set; }
        public virtual int TesonT { get; set; }
        public virtual int AfabilidadT { get; set; }
        public virtual int EstabilidadEmocionalT { get; set; }
        public virtual int AperturaMentalT { get; set; }

        public virtual int DistorsionT { get; set; }

        public virtual int DinamismoT { get; set; }
        public virtual int DominanciaT { get; set; }
        public virtual int CooperacionT { get; set; }
        public virtual int CordialidadT { get; set; }
        public virtual int EscrupolosidadT { get; set; }
        public virtual int PerseveranciaT { get; set; }
        public virtual int ControlEmocionesT { get; set; }
        public virtual int ControlImpulsosT { get; set; }
        public virtual int AperturaCulturaT { get; set; }
        public virtual int AperturaExperienciaT { get; set; }

    

    }
}