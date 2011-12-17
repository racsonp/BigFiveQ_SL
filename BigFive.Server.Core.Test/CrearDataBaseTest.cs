using BigFive.Server.Core.Entities;
using System.Linq;
using NHibernate;
using NUnit.Framework;
using System;


using BigFive.Server.Core.Common;
using BigFiveQAdmin.Web.PersitensiaNh;


using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace BigFive.Server.Core.Test
{
    [TestFixture]
    public class BaseDeDatosTest
    {
       // [Test]
        public void CrearDataBase()
        {
            var result = CrearDb();
            Assert.AreEqual("done", result);
        }

        public string CrearDb()
        {
            string msg;
            try
            {
                var nhConfig = new Configuration().Configure();
                var sessionFactory = nhConfig.BuildSessionFactory();
                Console.WriteLine("NHibernate Configured!");
                var schemaExport = new SchemaExport(nhConfig);
                //Scrip false Drop = true or false
                schemaExport.Create(false, true);
                //  schemaExport.Create(false, false);
                Console.WriteLine("Done DB");
                AddSampleData(sessionFactory);

                Console.WriteLine("Listo!!!");
                msg = "done";
                // Console.ReadKey();
            }
            catch (Exception e)
            {
                msg = e.Message;
            }

            return msg;
        }

        public static void AddSampleData(ISessionFactory sf)
        {
            var persona = new Persona
                              {
                                  Nombres = "Oscar Nathanael", 
                                  Apellidos = "Rivera", 
                                  Edad = 25, 
                                  Telefono = "+503 70543123", 
                                  Email = "asoftware@live.com", 
                                  Genero = 1,
                                  NombreUsuario= "racsonp", 
                                  Password = "racsonp.bfq",
                                  Institucion = "UTEC"
                              };
            using (var s = sf.OpenSession())
            using (var t = s.BeginTransaction())
            {
                s.Save(persona);
                t.Commit();
            }
            Console.WriteLine("Done Insert Persona demo");


            var eval = new EvaluacionBigFive
                           {
                               NombreExamen = "BigFiveQ"
                               ,
                               Afabilidad = 70
                               ,
                               AperturaCultura = 50
                               ,
                               AperturaExperiencia = 45
                               ,
                               AperturaMental = 47
                               ,
                               ControlEmociones = 47
                               ,
                               Energia = 53
                               ,
                               ControlImpulsos = 46
                               ,
                               Cooperacion = 66
                               ,
                               Cordialidad = 68
                               ,
                               Dinamismo = 58
                               ,
                               Distorsion = 54
                               ,
                               Dominancia = 45
                               ,
                               EstabilidadEmocional = 47
                               ,
                               Escrupolosidad = 48
                               ,
                               Perseverancia = 50
                               ,
                               Teson = 48
                               ,
                               FechaRealizacion = DateTime.Now
                           };
            using (var s = sf.OpenSession())
            using (var t = s.BeginTransaction())
            {
                s.Save(eval);
                t.Commit();
            }
          Console.WriteLine("Done Insert  Evaluacion Demo");
            //////////////////////////////////////////////////////////
            AddEvaluacion(sf);
        }

        private static void AddEvaluacion(ISessionFactory sf)
        {
            using (var s = sf.OpenSession())
            using (var t = s.BeginTransaction())
            {
                var c1 = s.QueryOver<Persona>().Where(x => x.NombreUsuario == "racsonp").SingleOrDefault();
                var m1 = s.QueryOver<EvaluacionBigFive>().List();
                c1.EvaluacionesBigFive.Add(m1.First());
                t.Commit();
            }
            Console.WriteLine("Evaluacion added!!");
        }

      //  [Test]
        //PersisteEvaluacionTest
        public void GuardaEvalacion()
        {
            var puntos = new PuntajeBigFive
            {
                Afabilidad = 67
                ,
                AperturaCultura = 35
                ,
                AperturaExperiencia = 33
                ,
                AperturaMental = 68
                ,
                ControlEmociones = 41
                ,
                ControlImpulsos = 39
                ,
                Cooperacion = 32
                ,
                Cordialidad = 35
                ,
                Dinamismo = 33
                ,
                Distorsion = 23
                ,
                Dominancia = 35
                ,
                Energia = 68
                ,
                Escrupolosidad = 33
                ,
                EstabilidadEmocional = 80

                ,
                Perseverancia = 34
                ,
                Teson = 67
            };


            var p = new PersisteEvaluacion();
            var result = p.Persistir(puntos, "racsonp");
            Assert.AreEqual("Evaluacion enviada", result);

        }
   
    }
}