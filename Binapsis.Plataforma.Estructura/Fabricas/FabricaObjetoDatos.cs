using Binapsis.Plataforma.Estructura.Implementaciones;

namespace Binapsis.Plataforma.Estructura
{
	public static class FabricaObjetoDatos
    {		
		public static IObjetoDatos Crear(ITipo tipo)
        {
            return Crear(new Implementacion(tipo));
		}

        internal static IObjetoDatos Crear(ITipo tipo, IObjetoDatos propietario)
        {
            return Crear(new Implementacion(tipo, propietario));
        }

        public static IObjetoDatos Crear(IImplementacion impl)
        {
            return new ObjetoDatos(impl);
        }
	}
}