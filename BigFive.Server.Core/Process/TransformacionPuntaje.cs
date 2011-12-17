using System.Collections.Generic;
using BigFive.Server.Core.Baremos;
using BigFive.Server.Core.Entities;

namespace BigFive.Server.Core.Process
{
    public class TransformacionPuntaje
    {
        private static int Procesar(int puntajeDirecto, IEnumerable<Valor> valores)
        {
            var  puntajeTransofrmado = 0;
            var encontrado = false;

            foreach (var valor in valores)
            {
                if (valor.PuntuacionDirectaHasta >= puntajeDirecto)
                {                   
                    if(encontrado !=true)
                        puntajeTransofrmado = valor.PuntuacionT;
                    encontrado = true;
                }
            }
            return puntajeTransofrmado;
        }
        //ToDo: Code Smell mybe a Dependecy Injection to solve
        private IBaremo _baremo;
        public int Energia(int puntajeDirecto, Genero genero)
        {
            _baremo = genero == Genero.Femenino ? (IBaremo)new MujeresE() : new VaronesE();
            return Procesar(puntajeDirecto, _baremo.GetValores());
        }
        public int Afabilidad(int puntajeDirecto, Genero genero)
        {
            _baremo = genero == Genero.Femenino ? (IBaremo)new MujeresA() : new VaronesA();
            return Procesar(puntajeDirecto, _baremo.GetValores());
        }
        public int Teson(int puntajeDirecto, Genero genero)
        {
            _baremo = genero == Genero.Femenino ? (IBaremo)new MujeresT() : new VaronesT();
            return Procesar(puntajeDirecto, _baremo.GetValores());
        }
        public int EstabilidadEmocional(int puntajeDirecto, Genero genero)
        {
            _baremo = genero == Genero.Femenino ? (IBaremo)new MujeresEE() : new VaronesEE();
            return Procesar(puntajeDirecto, _baremo.GetValores());
        }
        public int AperturaMentall(int puntajeDirecto, Genero genero)
        {
            _baremo = genero == Genero.Femenino ? (IBaremo)new MujeresAM() : new VaronesAM();
            return Procesar(puntajeDirecto, _baremo.GetValores());
        }
        public int Distorcion(int puntajeDirecto, Genero genero)
        {
            _baremo = genero == Genero.Femenino ? (IBaremo)new MujeresD() : new VaronesD();
            return Procesar(puntajeDirecto, _baremo.GetValores());
        }

        public int Dominacia(int puntajeDirecto, Genero genero)
        {
            _baremo = genero == Genero.Femenino ? (IBaremo)new MujeresDo() : new VaronesDo();
            return Procesar(puntajeDirecto, _baremo.GetValores());
        }
        public int Dinamismo(int puntajeDirecto, Genero genero)
        {
            _baremo = genero == Genero.Femenino ? (IBaremo)new MujeresDi() : new VaronesDi();
            return Procesar(puntajeDirecto, _baremo.GetValores());
        }
        public int Cooperacion(int puntajeDirecto, Genero genero)
        {
            _baremo = genero == Genero.Femenino ? (IBaremo)new MujeresCp() : new VaronesCp();
            return Procesar(puntajeDirecto, _baremo.GetValores());
        }
        public int Cordialidad(int puntajeDirecto, Genero genero)
        {
            _baremo = genero == Genero.Femenino ? (IBaremo)new MujeresCo() : new VaronesCo();
            return Procesar(puntajeDirecto, _baremo.GetValores());
        }
        public int Escrupulosidad(int puntajeDirecto, Genero genero)
        {
            _baremo = genero == Genero.Femenino ? (IBaremo)new MujeresEs() : new VaronesEs();
            return Procesar(puntajeDirecto, _baremo.GetValores());
        }
        public int Perseverncia(int puntajeDirecto, Genero genero)
        {
            _baremo = genero == Genero.Femenino ? (IBaremo)new MujeresPe() : new VaronesPe();
            return Procesar(puntajeDirecto, _baremo.GetValores());
        }
        public int ControlEmociones(int puntajeDirecto, Genero genero)
        {
            _baremo = genero == Genero.Femenino ? (IBaremo)new MujeresCe() : new VaronesCe();
            return Procesar(puntajeDirecto, _baremo.GetValores());
        }
        public int ControlImpulsos(int puntajeDirecto, Genero genero)
        {
            _baremo = genero == Genero.Femenino ? (IBaremo)new MujeresCi() : new VaronesCi();
            return Procesar(puntajeDirecto, _baremo.GetValores());
        }
        public int AperturaCultura(int puntajeDirecto, Genero genero)
        {
            _baremo = genero == Genero.Femenino ? (IBaremo)new MujeresAc() : new VaronesAc();
            return Procesar(puntajeDirecto, _baremo.GetValores());
        }
        public int AperturaExperiensa(int puntajeDirecto, Genero genero)
        {
            _baremo = genero == Genero.Femenino ? (IBaremo)new MujeresAe() : new VaronesAe();
            return Procesar(puntajeDirecto, _baremo.GetValores());
        }
    }
}