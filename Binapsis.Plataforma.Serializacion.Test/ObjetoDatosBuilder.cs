using Binapsis.Plataforma.Estructura;
using Binapsis.Plataforma.Estructura.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binapsis.Plataforma.Serializacion.Test
{
    internal static class ObjetoDatosBuilder
    {
        static Dictionary<Type, Action<IObjetoDatos, IPropiedad>> _delegados;

        static ObjetoDatosBuilder()
        {
            _delegados = new Dictionary<Type, Action<IObjetoDatos, IPropiedad>>(16);

            _delegados[typeof(bool)] = (od, propiedad) => od.EstablecerBoolean(propiedad, true);
            _delegados[typeof(byte)] = (od, propiedad) => od.EstablecerByte(propiedad, byte.MaxValue);
            _delegados[typeof(char)] = (od, propiedad) => od.EstablecerChar(propiedad, char.MaxValue);
            _delegados[typeof(DateTime)] = (od, propiedad) => od.EstablecerDateTime(propiedad, DateTime.MaxValue);
            _delegados[typeof(decimal)] = (od, propiedad) => od.EstablecerDecimal(propiedad, decimal.MaxValue);
            _delegados[typeof(double)] = (od, propiedad) => od.EstablecerDouble(propiedad, double.MaxValue);
            _delegados[typeof(float)] = (od, propiedad) => od.EstablecerFloat(propiedad, float.MaxValue);
            _delegados[typeof(int)] = (od, propiedad) => od.EstablecerInteger(propiedad, int.MaxValue);
            _delegados[typeof(long)] = (od, propiedad) => od.EstablecerLong(propiedad, long.MaxValue);
            _delegados[typeof(sbyte)] = (od, propiedad) => od.EstablecerSByte(propiedad, sbyte.MaxValue);
            _delegados[typeof(short)] = (od, propiedad) => od.EstablecerShort(propiedad, short.MaxValue);
            _delegados[typeof(string)] = (od, propiedad) => od.EstablecerString(propiedad, "texto");
            _delegados[typeof(uint)] = (od, propiedad) => od.EstablecerUInteger(propiedad, uint.MaxValue);
            _delegados[typeof(ulong)] = (od, propiedad) => od.EstablecerULong(propiedad, ulong.MaxValue);
            _delegados[typeof(ushort)] = (od, propiedad) => od.EstablecerUShort(propiedad, ushort.MaxValue);
        }

        public static IObjetoDatos Construir(ITipo tipo)
        {
            return Construir(tipo, 0, 0);
        }

        public static IObjetoDatos Construir(ITipo tipo, int niveles, int items)
        {
            IObjetoDatos od = FabricaObjetoDatos.Crear(tipo);
            Construir(od, niveles, items);
            return od;
        }

        public static IObjetoDatos Construir2(ITipo tipo, int niveles, int items)
        {
            IObjetoDatos diagrama = FabricaObjetoDatos.Crear(tipo);
            IObjetoDatos resumen = FabricaObjetoDatos.Crear(tipo["Resumen"].Tipo);
            IObjetoDatos od = FabricaObjetoDatos.Crear(tipo["ObjetoDatos"].Tipo);

            // construir resumen 
            resumen.EstablecerInteger("creacion", 10);
            resumen.EstablecerInteger("eliminacion", 11);
            resumen.EstablecerInteger("modificacion", 12);

            // construir objeto de datos 
            Construir(od, niveles, items);

            // construir diagrama
            diagrama.EstablecerString("Uri", od.Tipo.Uri);
            diagrama.EstablecerString("Nombre", od.Tipo.Nombre);
            diagrama.EstablecerObjetoDatos("Resumen", resumen);
            diagrama.EstablecerObjetoDatos("ObjetoDatos", od);

            return diagrama;
        }

        private static void Construir(IObjetoDatos od, int niveles, int items)
        {
            Construir(od, od.Tipo.Propiedades, niveles, items);
        }

        private static void Construir(IObjetoDatos od, IEnumerable<IPropiedad> propiedades, int niveles, int items)
        {
            foreach (IPropiedad propiedad in propiedades)
            {
                Construir(od, propiedad, niveles, items);
            }
        }

        private static void Construir(IObjetoDatos od, IPropiedad propiedad, int niveles, int items)
        {
            if (propiedad.Tipo.EsTipoDeDato)
                ConstruirAtributo(od, propiedad);
            else if (propiedad.Cardinalidad >= Cardinalidad.Muchos)
                ConstruirColeccion(od, propiedad, niveles, items);
            else
                ConstruirReferencia(od, propiedad, niveles, items);
        }

        private static void ConstruirAtributo(IObjetoDatos od, IPropiedad propiedad)
        {
            _delegados[TipoHelper.ObtenerType(propiedad.Tipo)].Invoke(od, propiedad);
        }

        private static void ConstruirReferencia(IObjetoDatos od, IPropiedad propiedad, int niveles, int items)
        {
            if (niveles == 0) return;
            IObjetoDatos referencia = od.CrearObjetoDatos(propiedad);
            Construir(referencia, (niveles - 1), items);
        }

        private static void ConstruirColeccion(IObjetoDatos od, IPropiedad propiedad, int niveles, int items)
        {
            if (niveles == 0) return;

            for (int i = 1; i <= items; i++)
            {
                Construir(od.CrearObjetoDatos(propiedad), (niveles - 1), items);
            }
        }

        
    }
}
