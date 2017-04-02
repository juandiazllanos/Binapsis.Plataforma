using System;

namespace Binapsis.Plataforma.Estructura.Impl
{
	public class Fabrica : IFabrica
    {
        static Fabrica()
        {
            Instancia = new Fabrica();
        }

        public static IFabrica Instancia { get; } 

        public IObjetoDatos Crear(ITipo tipo)
        {
            return Crear(FabricaImplementacion.Instancia.Crear(tipo));
        }

        public IObjetoDatos Crear(ITipo tipo, IObjetoDatos propietario)
        {
            return Crear(FabricaImplementacion.Instancia.Crear(tipo, propietario));
        }

        public IObjetoDatos Crear(IImplementacion impl)
        {
            return new ObjetoDatos(impl);
        }
        
        // La implementacion de composicion de ObjetoDatos no se aplica en este contexto.
        public IObjetoDatos Crear(IObjetoDatos od)
        {
            throw new NotImplementedException();
        }
        
    }
}