using Binapsis.Plataforma.Estructura.Colecciones;
using System;
using System.Linq;

namespace Binapsis.Plataforma.Estructura.Helpers
{
    static class PathHelper
    {
        public static bool ComprobarRuta(ref string ruta)
        {
            return (ruta.IndexOfAny(new char[] { '/', '.', '[' }) > 0);
        }

        private static void Resolver(ObjetoDatos od, string ruta, out ObjetoDatos referencia, out IPropiedad propiedad)
        {
            string[] pasos = ruta.Split('/');
            int longitud = pasos.GetLength(0);

            // referencia inicial
            referencia = od;

            // resolver referencia
            for (int i = 0; i < (longitud - 1); i++)
            {
                referencia = ResolverReferencia(referencia, pasos[i]);
                if (referencia == null) break;
            }

            // resolver propiedad
            propiedad = (referencia != null ? referencia.Tipo.ObtenerPropiedad(pasos[longitud - 1]) : null);
        }

        private static ObjetoDatos ResolverReferencia(ObjetoDatos od, string ruta)
        {
            ObjetoDatos referencia = default(ObjetoDatos);
            IPropiedad propiedad = null;
            string[] pasos = ruta.Split(new char[] { '.', '[', ']' });
            int indice;

            propiedad = od.Tipo.ObtenerPropiedad(pasos[0]);

            if (pasos.Length == 1)
            {
                referencia = od.ObtenerObjetoDatos(propiedad);
            }
            else if (int.TryParse(pasos[1], out indice))
            {
                referencia = od.ObtenerColeccion(propiedad)[indice];
            }
            else
            {
                referencia = ResolverReferencia(od, propiedad, pasos[1]); 
            }
            
            return referencia;
        }

        private static ObjetoDatos ResolverReferencia(ObjetoDatos od, IPropiedad propiedad, string parametro)
        {
            ObjetoDatos referencia = null;
            string[] pasos = parametro.Split(new char[] { '=' });

            if (pasos.GetLength(0) > 1)
            {
                var filtro = from item in od.ObtenerColeccion(propiedad)
                             where referencia.Obtener(pasos[0]).ToString().Equals(pasos[1])
                             select item;

                referencia = filtro.FirstOrDefault();
            }            

            return referencia;
        }


        internal static ObjetoDatos CrearObjetoDatos(ObjetoDatos od, string ruta)
        {
            ObjetoDatos referencia;
            IPropiedad propiedad;

            Resolver(od, ruta, out referencia, out propiedad);

            if (referencia != null && propiedad != null)
            {
                return referencia.CrearObjetoDatos(propiedad);
            }
            else
            {
                return null;
            }
        }

        public static bool Establecido(ObjetoDatos od, string ruta)
        {
            ObjetoDatos referencia;
            IPropiedad propiedad;
            bool valor = default(bool);

            Resolver(od, ruta, out referencia, out propiedad);

            if (referencia != null && propiedad != null)
            {
                valor = referencia.Establecido(propiedad);
            }

            return valor;
        }

        public static void Establecer(ObjetoDatos od, string ruta, object valor)
        {
            ObjetoDatos referencia;
            IPropiedad propiedad;

            Resolver(od, ruta, out referencia, out propiedad);

            if (referencia != null && propiedad != null)
            {
                referencia.Establecer(propiedad, valor);
            }
        }

        public static void EstablecerBoolean(ObjetoDatos od, string ruta, bool valor)
        {
            ObjetoDatos referencia;
            IPropiedad propiedad;

            Resolver(od, ruta, out referencia, out propiedad);

            if (referencia != null && propiedad != null)
            {
                referencia.EstablecerBoolean(propiedad, valor);
            }
        }
        
        public static void EstablecerByte(ObjetoDatos od, string ruta, byte valor)
        {
            ObjetoDatos referencia;
            IPropiedad propiedad;

            Resolver(od, ruta, out referencia, out propiedad);

            if (referencia != null && propiedad != null)
            {
                referencia.EstablecerByte(propiedad, valor);
            }
        }
        
        public static void EstablecerChar(ObjetoDatos od, string ruta, char valor)
        {
            ObjetoDatos referencia;
            IPropiedad propiedad;

            Resolver(od, ruta, out referencia, out propiedad);

            if (referencia != null && propiedad != null)
            {
                referencia.EstablecerChar(propiedad, valor);
            }
        }

        public static void EstablecerDateTime(ObjetoDatos od, string ruta, DateTime valor)
        {
            ObjetoDatos referencia;
            IPropiedad propiedad;

            Resolver(od, ruta, out referencia, out propiedad);

            if (referencia != null && propiedad != null)
            {
                referencia.EstablecerDateTime(propiedad, valor);
            }
        }

        public static void EstablecerDecimal(ObjetoDatos od, string ruta, decimal valor)
        {
            ObjetoDatos referencia;
            IPropiedad propiedad;

            Resolver(od, ruta, out referencia, out propiedad);

            if (referencia != null && propiedad != null)
            {
                referencia.EstablecerDecimal(propiedad, valor);
            }
        }

        public static void EstablecerDouble(ObjetoDatos od, string ruta, double valor)
        {
            ObjetoDatos referencia;
            IPropiedad propiedad;

            Resolver(od, ruta, out referencia, out propiedad);

            if (referencia != null && propiedad != null)
            {
                referencia.EstablecerDouble(propiedad, valor);
            }
        }

        public static void EstablecerFloat(ObjetoDatos od, string ruta, float valor)
        {
            ObjetoDatos referencia;
            IPropiedad propiedad;

            Resolver(od, ruta, out referencia, out propiedad);

            if (referencia != null && propiedad != null)
            {
                referencia.EstablecerFloat(propiedad, valor);
            }
        }

        public static void EstablecerInteger(ObjetoDatos od, string ruta, int valor)
        {
            ObjetoDatos referencia;
            IPropiedad propiedad;

            Resolver(od, ruta, out referencia, out propiedad);

            if (referencia != null && propiedad != null)
            {
                referencia.EstablecerInteger(propiedad, valor);
            }
        }

        public static void EstablecerLong(ObjetoDatos od, string ruta, long valor)
        {
            ObjetoDatos referencia;
            IPropiedad propiedad;

            Resolver(od, ruta, out referencia, out propiedad);

            if (referencia != null && propiedad != null)
            {
                referencia.EstablecerLong(propiedad, valor);
            }
        }

        public static void EstablecerObject(ObjetoDatos od, string ruta, object valor)
        {
            ObjetoDatos referencia;
            IPropiedad propiedad;

            Resolver(od, ruta, out referencia, out propiedad);

            if (referencia != null && propiedad != null)
            {
                referencia.EstablecerObject(propiedad, valor);
            }
        }

        public static void EstablecerObjetoDatos(ObjetoDatos od, string ruta, ObjetoDatos valor)
        {
            ObjetoDatos referencia;
            IPropiedad propiedad;

            Resolver(od, ruta, out referencia, out propiedad);

            if (referencia != null && propiedad != null)
            {
                referencia.EstablecerObjetoDatos(propiedad, valor);
            }
        }

        public static void EstablecerObjetoDatos(ObjetoDatos od, string ruta, int indice, ObjetoDatos item)
        {

        }

        public static void EstablecerSByte(ObjetoDatos od, string ruta, sbyte valor)
        {
            ObjetoDatos referencia;
            IPropiedad propiedad;

            Resolver(od, ruta, out referencia, out propiedad);

            if (referencia != null && propiedad != null)
            {
                referencia.EstablecerSByte(propiedad, valor);
            }
        }

        public static void EstablecerShort(ObjetoDatos od, string ruta, short valor)
        {
            ObjetoDatos referencia;
            IPropiedad propiedad;

            Resolver(od, ruta, out referencia, out propiedad);

            if (referencia != null && propiedad != null)
            {
                referencia.EstablecerShort(propiedad, valor);
            }
        }

        public static void EstablecerString(ObjetoDatos od, string ruta, string valor)
        {
            ObjetoDatos referencia;
            IPropiedad propiedad;

            Resolver(od, ruta, out referencia, out propiedad);

            if (referencia != null && propiedad != null)
            {
                referencia.EstablecerString(propiedad, valor);
            }
        }

        public static void EstablecerUInteger(ObjetoDatos od, string ruta, uint valor)
        {
            ObjetoDatos referencia;
            IPropiedad propiedad;

            Resolver(od, ruta, out referencia, out propiedad);

            if (referencia != null && propiedad != null)
            {
                referencia.EstablecerUInteger(propiedad, valor);
            }
        }

        public static void EstablecerULong(ObjetoDatos od, string ruta, ulong valor)
        {
            ObjetoDatos referencia;
            IPropiedad propiedad;

            Resolver(od, ruta, out referencia, out propiedad);

            if (referencia != null && propiedad != null)
            {
                referencia.EstablecerULong(propiedad, valor);
            }
        }

        public static void EstablecerUShort(ObjetoDatos od, string ruta, ushort valor)
        {
            ObjetoDatos referencia;
            IPropiedad propiedad;

            Resolver(od, ruta, out referencia, out propiedad);

            if (referencia != null && propiedad != null)
            {
                referencia.EstablecerUShort(propiedad, valor);
            }
        }

        public static object Obtener(ObjetoDatos od, string ruta)
        {
            ObjetoDatos referencia;
            IPropiedad propiedad;
            object valor = default(object);

            Resolver(od, ruta, out referencia, out propiedad);

            if (referencia != null && propiedad != null)
            {
                valor =  referencia.Obtener(propiedad);
            }

            return valor;
        }

        public static bool ObtenerBoolean(ObjetoDatos od, string ruta)
        {
            ObjetoDatos referencia;
            IPropiedad propiedad;
            bool valor = default(bool);

            Resolver(od, ruta, out referencia, out propiedad);

            if (referencia != null && propiedad != null)
            {
                valor = referencia.ObtenerBoolean(propiedad);
            }

            return valor;
        }

        public static byte ObtenerByte(ObjetoDatos od, string ruta)
        {
            ObjetoDatos referencia;
            IPropiedad propiedad;
            byte valor = default(byte);

            Resolver(od, ruta, out referencia, out propiedad);

            if (referencia != null && propiedad != null)
            {
                valor = referencia.ObtenerByte(propiedad);
            }

            return valor;
        }

        public static char ObtenerChar(ObjetoDatos od, string ruta)
        {
            ObjetoDatos referencia;
            IPropiedad propiedad;
            char valor = default(char);

            Resolver(od, ruta, out referencia, out propiedad);

            if (referencia != null && propiedad != null)
            {
                valor = referencia.ObtenerChar(propiedad);
            }

            return valor;
        }

        public static IColeccion ObtenerColeccion(ObjetoDatos od, string ruta)
        {
            ObjetoDatos referencia;
            IPropiedad propiedad;
            IColeccion valor = null;

            Resolver(od, ruta, out referencia, out propiedad);

            if (referencia != null && propiedad != null)
            {
                valor = referencia.ObtenerColeccion(propiedad);
            }

            return valor;
        }

        public static DateTime ObtenerDateTime(ObjetoDatos od, string ruta)
        {
            ObjetoDatos referencia;
            IPropiedad propiedad;
            DateTime valor = default(DateTime);

            Resolver(od, ruta, out referencia, out propiedad);

            if (referencia != null && propiedad != null)
            {
                valor = referencia.ObtenerDateTime(propiedad);
            }

            return valor;
        }

        public static decimal ObtenerDecimal(ObjetoDatos od, string ruta)
        {
            ObjetoDatos referencia;
            IPropiedad propiedad;
            decimal valor = default(decimal);

            Resolver(od, ruta, out referencia, out propiedad);

            if (referencia != null && propiedad != null)
            {
                valor = referencia.ObtenerDecimal(propiedad);
            }

            return valor;
        }

        public static double ObtenerDouble(ObjetoDatos od, string ruta)
        {
            ObjetoDatos referencia;
            IPropiedad propiedad;
            double valor = default(double);

            Resolver(od, ruta, out referencia, out propiedad);

            if (referencia != null && propiedad != null)
            {
                valor = referencia.ObtenerDouble(propiedad);
            }

            return valor;
        }

        public static float ObtenerFloat(ObjetoDatos od, string ruta)
        {
            ObjetoDatos referencia;
            IPropiedad propiedad;
            float valor = default(float);

            Resolver(od, ruta, out referencia, out propiedad);

            if (referencia != null && propiedad != null)
            {
                valor = referencia.ObtenerFloat(propiedad);
            }

            return valor;
        }

        public static int ObtenerInteger(ObjetoDatos od, string ruta)
        {
            ObjetoDatos referencia;
            IPropiedad propiedad;
            int valor = default(int);

            Resolver(od, ruta, out referencia, out propiedad);

            if (referencia != null && propiedad != null)
            {
                valor = referencia.ObtenerInteger(propiedad);
            }

            return valor;
        }

        public static long ObtenerLong(ObjetoDatos od, string ruta)
        {
            ObjetoDatos referencia;
            IPropiedad propiedad;
            long valor = default(long);

            Resolver(od, ruta, out referencia, out propiedad);

            if (referencia != null && propiedad != null)
            {
                valor = referencia.ObtenerLong(propiedad);
            }

            return valor;
        }

        public static object ObtenerObject(ObjetoDatos od, string ruta)
        {
            ObjetoDatos referencia;
            IPropiedad propiedad;
            object valor = default(object);

            Resolver(od, ruta, out referencia, out propiedad);

            if (referencia != null && propiedad != null)
            {
                valor = referencia.ObtenerObject(propiedad);
            }

            return valor;
        }

        public static ObjetoDatos ObtenerObjetoDatos(ObjetoDatos od, string ruta)
        {
            ObjetoDatos referencia;
            IPropiedad propiedad;
            //ObjetoDatos valor = default(ObjetoDatos);

            Resolver(od, ruta, out referencia, out propiedad);

            if (referencia != null && propiedad != null)
            {
                referencia = referencia.ObtenerObjetoDatos(propiedad);
            }

            return referencia;
        }

        public static ObjetoDatos ObtenerObjetoDatos(ObjetoDatos od, string ruta, int indice)
        {
            return null;
        }

        public static sbyte ObtenerSByte(ObjetoDatos od, string ruta)
        {
            ObjetoDatos referencia;
            IPropiedad propiedad;
            sbyte valor = default(sbyte);

            Resolver(od, ruta, out referencia, out propiedad);

            if (referencia != null && propiedad != null)
            {
                valor = referencia.ObtenerSByte(propiedad);
            }

            return valor;
        }

        public static short ObtenerShort(ObjetoDatos od, string ruta)
        {
            ObjetoDatos referencia;
            IPropiedad propiedad;
            short valor = default(short);

            Resolver(od, ruta, out referencia, out propiedad);

            if (referencia != null && propiedad != null)
            {
                valor = referencia.ObtenerShort(propiedad);
            }

            return valor;
        }

        public static string ObtenerString(ObjetoDatos od, string ruta)
        {
            ObjetoDatos referencia;
            IPropiedad propiedad;
            
            Resolver(od, ruta, out referencia, out propiedad);

            return (referencia != null && propiedad != null ? referencia.ObtenerString(propiedad) : default(string));
        }

        public static uint ObtenerUInteger(ObjetoDatos od, string ruta)
        {
            ObjetoDatos referencia;
            IPropiedad propiedad;
            uint valor = default(uint);

            Resolver(od, ruta, out referencia, out propiedad);

            if (referencia != null && propiedad != null)
            {
                valor = referencia.ObtenerUInteger(propiedad);
            }

            return valor;
        }

        public static ulong ObtenerULong(ObjetoDatos od, string ruta)
        {
            ObjetoDatos referencia;
            IPropiedad propiedad;
            ulong valor = default(ulong);

            Resolver(od, ruta, out referencia, out propiedad);

            if (referencia != null && propiedad != null)
            {
                valor = referencia.ObtenerULong(propiedad);
            }

            return valor;
        }

        public static ushort ObtenerUShort(ObjetoDatos od, string ruta)
        {
            ObjetoDatos referencia;
            IPropiedad propiedad;
            ushort valor = default(ushort);

            Resolver(od, ruta, out referencia, out propiedad);

            if (referencia != null && propiedad != null)
            {
                valor = referencia.ObtenerUShort(propiedad);
            }

            return valor;
        }
    }
}
