//using System;
//using BigFive.Server.Core.Entities;
//using NHibernate;
//using System.Collections.Generic;

namespace BigFive.Server.Core.Data
{
    public class PersonaRepositoryNh
    {
        //private ISessionFactory sf;
        //public PersonaRepositoryNh(ISessionFactory sessionFactoy)
        //{
        //    sf = sessionFactoy;
        //}

        //public void Create(Persona persona)
        //{
        //    using (var s = sf.OpenSession())
        //    using (var t = s.BeginTransaction())
        //    {
        //        s.Save(persona);
        //        t.Commit();
        //    }
        //}

        //public Persona GetById(Guid id)
        //{

        //    using (var s = sf.OpenSession())
        //    using (var t = s.BeginTransaction())
        //    {
        //       // var result = s.QueryOver<Persona>().Where(x => x.Id == id).SingleOrDefault();
        //        t.Commit();
        //       // return result;
        //        return null;
        //    }


        //}

        //public IEnumerable<Persona> GetAll()
        //{
        //    using (var s = sf.OpenSession())
        //    using (var t = s.BeginTransaction())
        //    {
        //        var result = s.QueryOver<Persona>().OrderBy(p => p.Nombres).Asc.List();
        //        t.Commit();
        //        return result;
        //    }

        //}

        //public void Update(Persona persona)
        //{
        //    using (var s = sf.OpenSession())
        //    using (var t = s.BeginTransaction())
        //    {
        //        var p = s.QueryOver<Persona>().Where(x => x.Id == persona.Id).SingleOrDefault();
        //        p.Apellidos = persona.Apellidos;
        //        p.Edad = persona.Edad;
        //        p.Nombres = persona.Nombres;
        //        t.Commit();

        //    }

        //}

        //public void Delete(Guid id)
        //{
        //    using (var s = sf.OpenSession())
        //    using (var t = s.BeginTransaction())
        //    {
        //        //var p = s.QueryOver<Persona>().Where(x => x.Id == id).SingleOrDefault();
        //        //s.Delete(p);
        //        //t.Commit();

        //    }

        //}
    }
}