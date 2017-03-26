using Binapsis.Plataforma.Estructura.Helpers;
using Binapsis.Plataforma.Estructura.Impl;
using System;

namespace Binapsis.Plataforma.Estructura.Test
{
    static class Helper
    {
        public static ITipo ConstruirTipo()
        {
            Tipo tipo = new Tipo { Nombre = "ObjetoDatos", Alias = "objetoDatos", Uri = "Binapsis.Plataforma.Estructura" };

            tipo.AgregarPropiedad(new Propiedad { Nombre = "atributoBoolean", Tipo = Primarios.Boolean });
            tipo.AgregarPropiedad(new Propiedad { Nombre = "atributoByte", Tipo = Primarios.Byte });
            tipo.AgregarPropiedad(new Propiedad { Nombre = "atributoChar", Tipo = Primarios.Char });
            tipo.AgregarPropiedad(new Propiedad { Nombre = "atributoDateTime", Tipo = Primarios.DateTime });
            tipo.AgregarPropiedad(new Propiedad { Nombre = "atributoDecimal", Tipo = Primarios.Decimal });
            tipo.AgregarPropiedad(new Propiedad { Nombre = "atributoDouble", Tipo = Primarios.Double });
            tipo.AgregarPropiedad(new Propiedad { Nombre = "atributoFloat", Tipo = Primarios.Float });
            tipo.AgregarPropiedad(new Propiedad { Nombre = "atributoInteger", Tipo = Primarios.Integer });
            tipo.AgregarPropiedad(new Propiedad { Nombre = "atributoLong", Tipo = Primarios.Long });
            tipo.AgregarPropiedad(new Propiedad { Nombre = "atributoSByte", Tipo = Primarios.SByte });
            tipo.AgregarPropiedad(new Propiedad { Nombre = "atributoShort", Tipo = Primarios.Short });
            tipo.AgregarPropiedad(new Propiedad { Nombre = "atributoString", Tipo = Primarios.String });
            tipo.AgregarPropiedad(new Propiedad { Nombre = "atributoUInteger", Tipo = Primarios.UInteger });
            tipo.AgregarPropiedad(new Propiedad { Nombre = "atributoULong", Tipo = Primarios.ULong });
            tipo.AgregarPropiedad(new Propiedad { Nombre = "atributoUShort", Tipo = Primarios.UShort });

            return tipo;
        }

        private static ITipo ConstruirTipoComplejo()
        {
            Tipo tipo = (Tipo)ConstruirTipo();

            tipo.AgregarPropiedad(new Propiedad { Nombre = "ReferenciaObjetoDatos", Tipo = tipo, Asociacion = Asociacion.Composicion, Cardinalidad = Cardinalidad.Uno });
            tipo.AgregarPropiedad(new Propiedad { Nombre = "ReferenciaObjetoDatosItem", Tipo = tipo, Asociacion = Asociacion.Composicion, Cardinalidad = Cardinalidad.Cero_Muchos });

            return tipo;
        }

        public static IObjetoDatos ConstruirObjetoDatos()
        {
            IObjetoDatos od = Fabrica.Instancia.Crear(ConstruirTipo());
            EstablecerValoresPorTipoPorIndice(od);            
            return od;
        }

        public static IObjetoDatos ConstruirObjetoDatosComplejo(int nivel = 0)
        {
            IObjetoDatos od = Fabrica.Instancia.Crear(ConstruirTipoComplejo());
            EstablecerValoresPorTipoPorIndice(od);

            ConstruirObjetoDatosComplejo(od, nivel);

            return od;
        }

        private static IObjetoDatos ConstruirObjetoDatosComplejo(IObjetoDatos od, int nivel)
        {
            IObjetoDatos refod = od.CrearObjetoDatos("ReferenciaObjetoDatos");
            EstablecerValoresPorTipoPorIndice(refod);
            
            if (nivel > 0) 
                ConstruirObjetoDatosComplejo(refod, nivel - 1);

            for (int i = 1; i <= 3; i++)
            {
                refod = od.CrearObjetoDatos("ReferenciaObjetoDatosItem");
                EstablecerValoresPorTipoPorIndice(refod);
                if (nivel > 0)
                    ConstruirObjetoDatosComplejo(refod, nivel - 1);
            }

            return od;
        }

        public static void EstablecerValoresPorIndice(IObjetoDatos od)
        {
            bool valorBoolean = true;
            byte valorByte = byte.MaxValue;
            char valorChar = char.MaxValue;
            DateTime valorDateTime = DateTime.MaxValue;
            decimal valorDecimal = decimal.MaxValue;
            double valorDouble = double.MaxValue;
            float valorFloat = float.MaxValue;
            int valorInteger = int.MaxValue;
            long valorLong = long.MaxValue;
            sbyte valorSByte = sbyte.MaxValue;
            short valorShort = short.MaxValue;
            string valorString = "abcdefghijklmnoprstuvwxyz";
            uint valorUInteger = uint.MaxValue;
            ulong valorULong = ulong.MaxValue;
            ushort valorUShort = ushort.MaxValue;

            od.Establecer(0, valorBoolean);
            od.Establecer(1, valorByte);
            od.Establecer(2, valorChar);
            od.Establecer(3, valorDateTime);
            od.Establecer(4, valorDecimal);
            od.Establecer(5, valorDouble);
            od.Establecer(6, valorFloat);
            od.Establecer(7, valorInteger);
            od.Establecer(8, valorLong);
            od.Establecer(9, valorSByte);
            od.Establecer(10, valorShort);
            od.Establecer(11, valorString);
            od.Establecer(12, valorUInteger);
            od.Establecer(13, valorULong);
            od.Establecer(14, valorUShort);
        }

        public static void EstablecerValoresPorNombre(IObjetoDatos od)
        {
            bool valorBoolean = true;
            byte valorByte = byte.MaxValue;
            char valorChar = char.MaxValue;
            DateTime valorDateTime = DateTime.MaxValue;
            decimal valorDecimal = decimal.MaxValue;
            double valorDouble = double.MaxValue;
            float valorFloat = float.MaxValue;
            int valorInteger = int.MaxValue;
            long valorLong = long.MaxValue;
            sbyte valorSByte = sbyte.MaxValue;
            short valorShort = short.MaxValue;
            string valorString = "abcdefghijklmnoprstuvwxyz";
            uint valorUInteger = uint.MaxValue;
            ulong valorULong = ulong.MaxValue;
            ushort valorUShort = ushort.MaxValue;

            od.Establecer("atributoBoolean", valorBoolean);
            od.Establecer("atributoByte", valorByte);
            od.Establecer("atributoChar", valorChar);
            od.Establecer("atributoDateTime", valorDateTime);
            od.Establecer("atributoDecimal", valorDecimal);
            od.Establecer("atributoDouble", valorDouble);
            od.Establecer("atributoFloat", valorFloat);
            od.Establecer("atributoInteger", valorInteger);
            od.Establecer("atributoLong", valorLong);
            od.Establecer("atributoSByte", valorSByte);
            od.Establecer("atributoShort", valorShort);
            od.Establecer("atributoString", valorString);
            od.Establecer("atributoUInteger", valorUInteger);
            od.Establecer("atributoULong", valorULong);
            od.Establecer("atributoUShort", valorUShort);
        }

        public static void EstablecerValoresPorTipoPorIndice(IObjetoDatos od)
        {
            bool valorBoolean = true;
            byte valorByte = byte.MaxValue;
            char valorChar = char.MaxValue;
            DateTime valorDateTime = DateTime.MaxValue;
            decimal valorDecimal = decimal.MaxValue;
            double valorDouble = double.MaxValue;
            float valorFloat = float.MaxValue;
            int valorInteger = int.MaxValue;
            long valorLong = long.MaxValue;
            sbyte valorSByte = sbyte.MaxValue;
            short valorShort = short.MaxValue;
            string valorString = "abcdefghijklmnopqrstuvwxyz";
            uint valorUInteger = uint.MaxValue;
            ulong valorULong = ulong.MaxValue;
            ushort valorUShort = ushort.MaxValue;

            od.EstablecerBoolean(0, valorBoolean);
            od.EstablecerByte(1, valorByte);
            od.EstablecerChar(2, valorChar);
            od.EstablecerDateTime(3, valorDateTime);
            od.EstablecerDecimal(4, valorDecimal);
            od.EstablecerDouble(5, valorDouble);
            od.EstablecerFloat(6, valorFloat);
            od.EstablecerInteger(7, valorInteger);
            od.EstablecerLong(8, valorLong);
            od.EstablecerSByte(9, valorSByte);
            od.EstablecerShort(10, valorShort);
            od.EstablecerString(11, valorString);
            od.EstablecerUInteger(12, valorUInteger);
            od.EstablecerULong(13, valorULong);
            od.EstablecerUShort(14, valorUShort);
            
        }

        public static void EstablecerValoresPorTipoPorNombre(IObjetoDatos od)
        {
            bool valorBoolean = true;
            byte valorByte = byte.MaxValue;
            char valorChar = char.MaxValue;
            DateTime valorDateTime = DateTime.MaxValue;
            decimal valorDecimal = decimal.MaxValue;
            double valorDouble = double.MaxValue;
            float valorFloat = float.MaxValue;
            int valorInteger = int.MaxValue;
            long valorLong = long.MaxValue;
            sbyte valorSByte = sbyte.MaxValue;
            short valorShort = short.MaxValue;
            string valorString = "abcdefghijklmnoprstuvwxyz";
            uint valorUInteger = uint.MaxValue;
            ulong valorULong = ulong.MaxValue;
            ushort valorUShort = ushort.MaxValue;

            od.EstablecerBoolean("atributoBoolean", valorBoolean);
            od.EstablecerByte("atributoByte", valorByte);
            od.EstablecerChar("atributoChar", valorChar);
            od.EstablecerDateTime("atributoDateTime", valorDateTime);
            od.EstablecerDecimal("atributoDecimal", valorDecimal);
            od.EstablecerDouble("atributoDouble", valorDouble);
            od.EstablecerFloat("atributoFloat", valorFloat);
            od.EstablecerInteger("atributoInteger", valorInteger);
            od.EstablecerLong("atributoLong", valorLong);
            od.EstablecerSByte("atributoSByte", valorSByte);
            od.EstablecerShort("atributoShort", valorShort);
            od.EstablecerString("atributoString", valorString);
            od.EstablecerUInteger("atributoUInteger", valorUInteger);
            od.EstablecerULong("atributoULong", valorULong);
            od.EstablecerUShort("atributoUShort", valorUShort);

        }
    }
}
