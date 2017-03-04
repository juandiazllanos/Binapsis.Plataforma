using Binapsis.Plataforma.Estructura.Implementaciones;

namespace Binapsis.Plataforma.Estructura
{
	public static class FabricaObjetoDatos
    {		
		public static ObjetoDatos Crear(ITipo tipo)
        {
            return Crear(new Implementacion(tipo));
		}

        internal static ObjetoDatos Crear(ITipo tipo, ObjetoDatos propietario)
        {
            return Crear(new Implementacion(tipo, propietario));
        }

        public static ObjetoDatos Crear(IImplementacion impl)
        {
            return new ObjetoDatos(impl);
        }
	}
}