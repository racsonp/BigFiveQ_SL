
using System.Collections.Generic;


namespace BigFive.Server.Core.Entities
{
    public class Persona : Entity
    {
        public Persona()
        {
            EvaluacionesBigFive = new List<EvaluacionBigFive>();
        }

        public virtual string Nombres { get; set; }
        public virtual string Apellidos { get; set; }
        public virtual int Edad { get; set; }
        public virtual string Telefono { get; set; }
        public virtual string Institucion { get; set; }
        public virtual string Email { get; set;}
        public virtual string Password { get; set; }
        public virtual string NombreUsuario { get; set; }

        /// <summary>
        /// Por  acuerdo ( mio ) genero sera un entero donde =>
        /// 1 == Masculino
        /// 2 == Femenino
        /// </summary>
        /// 
        public virtual int Genero { get; set; }
        public virtual ICollection<EvaluacionBigFive> EvaluacionesBigFive { get; set; }
    }
}