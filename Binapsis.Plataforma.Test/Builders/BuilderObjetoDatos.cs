using Binapsis.Plataforma.Estructura;
using Binapsis.Plataforma.Estructura.Helpers;
using Binapsis.Plataforma.Estructura.Impl;
using System;
using System.Collections.Generic;

namespace Binapsis.Plataforma.Test.Builders
{
    internal static class BuilderObjetoDatos
    {
        static Dictionary<Type, Action<IObjetoDatos, IPropiedad>> _delegados;
        static Random _rnd;
        static int _id;

        static IObjetoDatos _od;
        static ITipo _tipo;

        static BuilderObjetoDatos()
        {
            _rnd = new Random();
            _delegados = new Dictionary<Type, Action<IObjetoDatos, IPropiedad>>(16);

            _delegados[typeof(bool)] = (od, propiedad) => od.EstablecerBoolean(propiedad, true);
            _delegados[typeof(byte)] = (od, propiedad) => od.EstablecerByte(propiedad, byte.MaxValue);
            _delegados[typeof(char)] = (od, propiedad) => od.EstablecerChar(propiedad, char.MaxValue);
            _delegados[typeof(DateTime)] = (od, propiedad) => od.EstablecerDateTime(propiedad, DateTime.Now);//DateTime.MaxValue);
            _delegados[typeof(decimal)] = (od, propiedad) => od.EstablecerDecimal(propiedad, (decimal)_rnd.NextDouble() * _rnd.Next()); //decimal.MaxValue);
            _delegados[typeof(double)] = (od, propiedad) => od.EstablecerDouble(propiedad, _rnd.NextDouble() * _rnd.Next()); //double.MaxValue);
            _delegados[typeof(float)] = (od, propiedad) => od.EstablecerFloat(propiedad, float.MaxValue);
            _delegados[typeof(int)] = (od, propiedad) => od.EstablecerInteger(propiedad, int.MaxValue);
            _delegados[typeof(long)] = (od, propiedad) => od.EstablecerLong(propiedad, long.MaxValue);
            _delegados[typeof(sbyte)] = (od, propiedad) => od.EstablecerSByte(propiedad, sbyte.MaxValue);
            _delegados[typeof(short)] = (od, propiedad) => od.EstablecerShort(propiedad, short.MaxValue);
            _delegados[typeof(string)] = (od, propiedad) => od.EstablecerString(propiedad, "texto");
            _delegados[typeof(uint)] = (od, propiedad) => od.EstablecerUInteger(propiedad, uint.MaxValue);
            _delegados[typeof(ulong)] = (od, propiedad) => od.EstablecerULong(propiedad, ulong.MaxValue);
            _delegados[typeof(ushort)] = (od, propiedad) => od.EstablecerUShort(propiedad, ushort.MaxValue);

            _tipo = HelperTipo.ObtenerTipo(); // BuilderTipo.Construir();
            
            _od = Construir(_tipo, 1, 6);
            _od.EstablecerInteger("atributoId", 0);
            _od.EstablecerString("atributoString", "Objeto agregado");
        }
        
        public static IObjetoDatos Construir(ITipo tipo, int niveles, int items)
        {
            IObjetoDatos od = Fabrica.Instancia.Crear(tipo);            
            Construir(od, niveles, items);            
            return od;
        }
        
        public static void Construir(IObjetoDatos od, int niveles, int items)
        {
            if (od.Tipo.ContienePropiedad("atributoId"))
                od.EstablecerInteger("atributoId", ++_id);

            Construir(od, od.Tipo.Propiedades, niveles, items);

            if (od.Tipo["ReferenciaObjetoDatos2"] != null)
                od.EstablecerObjetoDatos("ReferenciaObjetoDatos2", _od);

            if (od.Tipo["ReferenciaObjetoDatosItem2"] != null && od.ObtenerColeccion("ReferenciaObjetoDatosItem").Longitud > 0)
                od.EstablecerObjetoDatos("ReferenciaObjetoDatosItem2", od.ObtenerColeccion("ReferenciaObjetoDatosItem")[0]);

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
            if (propiedad.Nombre == "atributoId") return;

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

            if (propiedad.Asociacion == Asociacion.Composicion)
            {
                IObjetoDatos referencia = od.CrearObjetoDatos(propiedad);
                Construir(referencia, (niveles - 1), items);
            }            
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
