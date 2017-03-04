using Binapsis.Plataforma.Estructura.Colecciones;
using Binapsis.Plataforma.Estructura.Helpers;
using Binapsis.Plataforma.Estructura.Interno;
using System;
using System.Collections.Generic;

namespace Binapsis.Plataforma.Estructura
{
	internal static class FabricaCaracteristica
    {
        static Dictionary<Type,Func<IPropiedad, Caracteristica>> _fabrica;

		static FabricaCaracteristica()
        {
            _fabrica = new Dictionary<Type, Func<IPropiedad, Caracteristica>>(18);
            InicializarFabrica();
		}
        
        private static void InicializarFabrica()
        {
            _fabrica[typeof(bool)] = (propiedad) => new CaracteristicaBoolean(propiedad);
            _fabrica[typeof(byte)] = (propiedad) => new CaracteristicaByte(propiedad);
            _fabrica[typeof(char)] = (propiedad) => new CaracteristicaChar(propiedad);
            _fabrica[typeof(Coleccion)] = (propiedad) => new CaracteristicaColeccion(propiedad);
            _fabrica[typeof(DateTime)] = (propiedad) => new CaracteristicaDateTime(propiedad);
            _fabrica[typeof(decimal)] = (propiedad) => new CaracteristicaDecimal(propiedad);
            _fabrica[typeof(double)] = (propiedad) => new CaracteristicaDouble(propiedad);
            _fabrica[typeof(float)] = (propiedad) => new CaracteristicaFloat(propiedad);
            _fabrica[typeof(int)] = (propiedad) => new CaracteristicaInteger(propiedad);
            _fabrica[typeof(long)] = (propiedad) => new CaracteristicaLong(propiedad);
            _fabrica[typeof(object)] = (propiedad) => new CaracteristicaObject(propiedad);
            _fabrica[typeof(IObjetoDatos)] = (propiedad) => new CaracteristicaObjetoDatos(propiedad);
            _fabrica[typeof(sbyte)] = (propiedad) => new CaracteristicaSByte(propiedad);
            _fabrica[typeof(short)] = (propiedad) => new CaracteristicaShort(propiedad);
            _fabrica[typeof(string)] = (propiedad) => new CaracteristicaString(propiedad);
            _fabrica[typeof(uint)] = (propiedad) => new CaracteristicaUInteger(propiedad);
            _fabrica[typeof(ulong)] = (propiedad) => new CaracteristicaULong(propiedad);
            _fabrica[typeof(ushort)] = (propiedad) => new CaracteristicaUShort(propiedad);
        }

		public static Caracteristica Crear(IPropiedad propiedad)
        {
            Caracteristica caracteristica; 

            if (propiedad.Cardinalidad >= Cardinalidad.Cero_Muchos)
            {
                caracteristica = _fabrica[typeof(Coleccion)].Invoke(propiedad);
            }
            else if (propiedad.Tipo.EsTipoDeDato)
            {
                caracteristica = _fabrica[TipoHelper.ObtenerType(propiedad.Tipo)].Invoke(propiedad);
            }
            else
            {
                caracteristica = _fabrica[typeof(IObjetoDatos)].Invoke(propiedad);
            }

            return caracteristica;
        }

	}
}