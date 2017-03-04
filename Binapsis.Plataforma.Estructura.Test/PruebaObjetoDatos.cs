using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Binapsis.Plataforma.Estructura.Helpers;
using static Binapsis.Plataforma.Estructura.Test.Helper;

namespace Binapsis.Plataforma.Estructura.Test
{
    [TestClass]
    public class PruebaObjetoDatos
    {
        [TestMethod]
        public void PruebaEstablecerPorIndice()
        {
            ObjetoDatos od = FabricaObjetoDatos.Crear(ConstruirTipo());
            Random rnd = new Random();

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

            Assert.AreEqual(od.Obtener(0), valorBoolean);
            Assert.AreEqual(od.Obtener(1), valorByte);
            Assert.AreEqual(od.Obtener(2), valorChar);
            Assert.AreEqual(od.Obtener(3), valorDateTime);
            Assert.AreEqual(od.Obtener(4), valorDecimal);
            Assert.AreEqual(od.Obtener(5), valorDouble);
            Assert.AreEqual(od.Obtener(6), valorFloat);
            Assert.AreEqual(od.Obtener(7), valorInteger);
            Assert.AreEqual(od.Obtener(8), valorLong);
            Assert.AreEqual(od.Obtener(9), valorSByte);
            Assert.AreEqual(od.Obtener(10), valorShort);
            Assert.AreEqual(od.Obtener(11), valorString);
            Assert.AreEqual(od.Obtener(12), valorUInteger);
            Assert.AreEqual(od.Obtener(13), valorULong);
            Assert.AreEqual(od.Obtener(14), valorUShort);

        }

        [TestMethod]
        public void PruebaEstablecerPorNombre()
        {
            ObjetoDatos od = FabricaObjetoDatos.Crear(ConstruirTipo());
            Random rnd = new Random();

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

            Assert.AreEqual(od.Obtener("atributoBoolean"), valorBoolean);
            Assert.AreEqual(od.Obtener("atributoByte"), valorByte);
            Assert.AreEqual(od.Obtener("atributoChar"), valorChar);
            Assert.AreEqual(od.Obtener("atributoDateTime"), valorDateTime);
            Assert.AreEqual(od.Obtener("atributoDecimal"), valorDecimal);
            Assert.AreEqual(od.Obtener("atributoDouble"), valorDouble);
            Assert.AreEqual(od.Obtener("atributoFloat"), valorFloat);
            Assert.AreEqual(od.Obtener("atributoInteger"), valorInteger);
            Assert.AreEqual(od.Obtener("atributoLong"), valorLong);
            Assert.AreEqual(od.Obtener("atributoSByte"), valorSByte);
            Assert.AreEqual(od.Obtener("atributoShort"), valorShort);
            Assert.AreEqual(od.Obtener("atributoString"), valorString);
            Assert.AreEqual(od.Obtener("atributoUInteger"), valorUInteger);
            Assert.AreEqual(od.Obtener("atributoULong"), valorULong);
            Assert.AreEqual(od.Obtener("atributoUShort"), valorUShort);

        }

        [TestMethod]
        public void PruebaEstablecerPorTipoPorIndice()
        {
            ObjetoDatos od = FabricaObjetoDatos.Crear(ConstruirTipo());
            Random rnd = new Random();

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

            Assert.AreEqual(od.ObtenerBoolean(0), valorBoolean);
            Assert.AreEqual(od.ObtenerByte(1), valorByte);
            Assert.AreEqual(od.ObtenerChar(2), valorChar);
            Assert.AreEqual(od.ObtenerDateTime(3), valorDateTime);
            Assert.AreEqual(od.ObtenerDecimal(4), valorDecimal);
            Assert.AreEqual(od.ObtenerDouble(5), valorDouble);
            Assert.AreEqual(od.ObtenerFloat(6), valorFloat);
            Assert.AreEqual(od.ObtenerInteger(7), valorInteger);
            Assert.AreEqual(od.ObtenerLong(8), valorLong);
            Assert.AreEqual(od.ObtenerSByte(9), valorSByte);
            Assert.AreEqual(od.ObtenerShort(10), valorShort);
            Assert.AreEqual(od.ObtenerString(11), valorString);
            Assert.AreEqual(od.ObtenerUInteger(12), valorUInteger);
            Assert.AreEqual(od.ObtenerULong(13), valorULong);
            Assert.AreEqual(od.ObtenerUShort(14), valorUShort);

        }
        [TestMethod]
        public void PruebaEstablecerPorTipoPorNombre()
        {
            ObjetoDatos od = FabricaObjetoDatos.Crear(ConstruirTipo());
            Random rnd = new Random();

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

            Assert.AreEqual(od.ObtenerBoolean("atributoBoolean"), valorBoolean);
            Assert.AreEqual(od.ObtenerByte("atributoByte"), valorByte);
            Assert.AreEqual(od.ObtenerChar("atributoChar"), valorChar);
            Assert.AreEqual(od.ObtenerDateTime("atributoDateTime"), valorDateTime);
            Assert.AreEqual(od.ObtenerDecimal("atributoDecimal"), valorDecimal);
            Assert.AreEqual(od.ObtenerDouble("atributoDouble"), valorDouble);
            Assert.AreEqual(od.ObtenerFloat("atributoFloat"), valorFloat);
            Assert.AreEqual(od.ObtenerInteger("atributoInteger"), valorInteger);
            Assert.AreEqual(od.ObtenerLong("atributoLong"), valorLong);
            Assert.AreEqual(od.ObtenerSByte("atributoSByte"), valorSByte);
            Assert.AreEqual(od.ObtenerShort("atributoShort"), valorShort);
            Assert.AreEqual(od.ObtenerString("atributoString"), valorString);
            Assert.AreEqual(od.ObtenerUInteger("atributoUInteger"), valorUInteger);
            Assert.AreEqual(od.ObtenerULong("atributoULong"), valorULong);
            Assert.AreEqual(od.ObtenerUShort("atributoUShort"), valorUShort);

        }


        [TestMethod]
        [TestCategory("ObjetoDatosComplejo")]
        public void PruebaObjetoDatosComplejoItemsIgualATres()
        {
            ObjetoDatos od = ConstruirObjetoDatosComplejo();

            Assert.AreEqual(od.ObtenerColeccion("ReferenciaObjetoDatosItem").Longitud, 3);
        }

        [TestMethod]
        [TestCategory("ObjetoDatosComplejo")]
        public void PruebaObjetoDatosComplejoReferenciaItemsIgualACero()
        {
            ObjetoDatos od = ConstruirObjetoDatosComplejo();

            Assert.AreEqual(od.ObtenerObjetoDatos("ReferenciaObjetoDatos").ObtenerColeccion("ReferenciaObjetoDatosItem").Longitud, 0);
        }

        [TestMethod]
        [TestCategory("ObjetoDatosComplejo")]
        public void PruebaObjetoDatosComplejoRemoverUnItem()
        {
            ObjetoDatos od = ConstruirObjetoDatosComplejo();
            od.RemoverObjetoDatos("ReferenciaObjetoDatosItem", od.ObtenerColeccion("ReferenciaObjetoDatosItem")[0]);
            Assert.AreEqual(od.ObtenerColeccion("ReferenciaObjetoDatosItem").Longitud, 2);
        }

        [TestMethod]
        [TestCategory("ObjetoDatosComplejo")]
        public void PruebaObjetoDatosComplejoRemoverDosItems()
        {
            ObjetoDatos od = ConstruirObjetoDatosComplejo();
            ObjetoDatos primerItem = od.ObtenerColeccion("ReferenciaObjetoDatosItem")[0];
            ObjetoDatos segundoItem = od.ObtenerColeccion("ReferenciaObjetoDatosItem")[1];

            od.RemoverObjetoDatos("ReferenciaObjetoDatosItem", primerItem);
            od.RemoverObjetoDatos("ReferenciaObjetoDatosItem", segundoItem);

            Assert.AreEqual(od.ObtenerColeccion("ReferenciaObjetoDatosItem").Longitud, 1);
        }

        [TestMethod]
        [TestCategory("ObjetoDatosComplejo")]
        public void PruebaObjetoDatosComplejoRemoverTresItems()
        {
            ObjetoDatos od = ConstruirObjetoDatosComplejo();
            ObjetoDatos primerItem = od.ObtenerColeccion("ReferenciaObjetoDatosItem")[0];
            ObjetoDatos segundoItem = od.ObtenerColeccion("ReferenciaObjetoDatosItem")[1];
            ObjetoDatos tercerItem = od.ObtenerColeccion("ReferenciaObjetoDatosItem")[2];

            od.RemoverObjetoDatos("ReferenciaObjetoDatosItem", primerItem);
            od.RemoverObjetoDatos("ReferenciaObjetoDatosItem", segundoItem);
            od.RemoverObjetoDatos("ReferenciaObjetoDatosItem", tercerItem);

            Assert.AreEqual(od.ObtenerColeccion("ReferenciaObjetoDatosItem").Longitud, 0);
        }

        [TestMethod]
        [TestCategory("ObjetoDatosPath")]
        public void PruebaObjetoDatosPathReferenciaDiferenteNulo()
        {
            string ruta1 = "ReferenciaObjetoDatos";
            string ruta2 = "ReferenciaObjetoDatos/ReferenciaObjetoDatos";
            string ruta3 = "ReferenciaObjetoDatos/ReferenciaObjetoDatos/ReferenciaObjetoDatos";
            string ruta4 = "ReferenciaObjetoDatos";
            string ruta5 = "ReferenciaObjetoDatos/ReferenciaObjetoDatosItem[1]";
            string ruta6 = "ReferenciaObjetoDatos/ReferenciaObjetoDatosItem[1]/ReferenciaObjetoDatos[1]";
            string ruta7 = "ReferenciaObjetoDatosItem[0]";
            string ruta8 = "ReferenciaObjetoDatosItem[1]/ReferenciaObjetoDatosItem[2]";
            string ruta9 = "ReferenciaObjetoDatosItem[2]/ReferenciaObjetoDatosItem[2]/ReferenciaObjetoDatos[2]";

            ObjetoDatos od = ConstruirObjetoDatosComplejo(2);
            ObjetoDatos item1 = od.ObtenerObjetoDatos(ruta1);
            ObjetoDatos item2 = od.ObtenerObjetoDatos(ruta2);
            ObjetoDatos item3 = od.ObtenerObjetoDatos(ruta3);
            ObjetoDatos item4 = od.ObtenerObjetoDatos(ruta4);
            ObjetoDatos item5 = od.ObtenerObjetoDatos(ruta5);
            ObjetoDatos item6 = od.ObtenerObjetoDatos(ruta6);
            ObjetoDatos item7 = od.ObtenerObjetoDatos(ruta7);
            ObjetoDatos item8 = od.ObtenerObjetoDatos(ruta8);
            ObjetoDatos item9 = od.ObtenerObjetoDatos(ruta9);

            Assert.IsNotNull(item1, $"Se esperaba un valor. ruta={ruta1}");
            Assert.IsNotNull(item2, $"Se esperaba un valor. ruta={ruta2}");
            Assert.IsNotNull(item3, $"Se esperaba un valor. ruta={ruta3}");
            Assert.IsNotNull(item4, $"Se esperaba un valor. ruta={ruta4}");
            Assert.IsNotNull(item5, $"Se esperaba un valor. ruta={ruta5}");
            Assert.IsNotNull(item6, $"Se esperaba un valor. ruta={ruta6}");
            Assert.IsNotNull(item7, $"Se esperaba un valor. ruta={ruta7}");
            Assert.IsNotNull(item8, $"Se esperaba un valor. ruta={ruta8}");
            Assert.IsNotNull(item9, $"Se esperaba un valor. ruta={ruta9}");

        }

        [TestMethod]
        [TestCategory("ObjetoDatosPath")]
        public void PruebaObjetoDatosPathObtener()
        {
            
            ObjetoDatos od = ConstruirObjetoDatosComplejo(2);

            string ruta = "ReferenciaObjetoDatos";

            bool valorBoolean = Convert.ToBoolean(od.Obtener($"{ruta}/atributoBoolean"));
            byte valorByte = Convert.ToByte(od.Obtener($"{ruta}/atributoByte"));
            char valorChar = Convert.ToChar(od.Obtener($"{ruta}/atributoChar"));
            DateTime valorDateTime = Convert.ToDateTime(od.Obtener($"{ruta}/atributoDateTime"));
            decimal valorDecimal = Convert.ToDecimal(od.Obtener($"{ruta}/atributoDecimal"));
            double valorDouble = Convert.ToDouble(od.Obtener($"{ruta}/atributoDouble"));
            float valorFloat = Convert.ToSingle(od.Obtener($"{ruta}/atributoFloat"));
            int valorInteger = Convert.ToInt32(od.Obtener($"{ruta}/atributoInteger"));
            long valorLong = Convert.ToInt64(od.Obtener($"{ruta}/atributoLong"));
            sbyte valorSByte = Convert.ToSByte(od.Obtener($"{ruta}/atributoSByte"));
            short valorShort = Convert.ToInt16(od.Obtener($"{ruta}/atributoShort"));
            string valorString = Convert.ToString(od.Obtener($"{ruta}/atributoString"));
            uint valorUInteger = Convert.ToUInt32(od.Obtener($"{ruta}/atributoUInteger"));
            ulong valorULong = Convert.ToUInt64(od.Obtener($"{ruta}/atributoULong"));
            ushort valorUShort = Convert.ToUInt16(od.Obtener($"{ruta}/atributoUShort"));
                        

            Assert.AreEqual(valorBoolean, true, "Se esperaba el valor true.");
            Assert.AreEqual(valorByte, byte.MaxValue, $"Se esperaba el valor '{byte.MaxValue}'");
            Assert.AreEqual(valorChar, char.MaxValue, $"Se esperaba el valor '{char.MaxValue}'");
            Assert.AreEqual(valorDateTime, DateTime.MaxValue, $"Se esperaba el valor '{DateTime.MaxValue}'");
            Assert.AreEqual(valorDecimal, decimal.MaxValue, $"Se esperaba el valor '{decimal.MaxValue}'");
            Assert.AreEqual(valorDouble, double.MaxValue, $"Se esperaba el valor '{double.MaxValue}'");
            Assert.AreEqual(valorFloat, float.MaxValue, $"Se esperaba el valor '{float.MaxValue}'");
            Assert.AreEqual(valorInteger, int.MaxValue, $"Se esperaba el valor '{int.MaxValue}'");
            Assert.AreEqual(valorLong, long.MaxValue, $"Se esperaba el valor '{long.MaxValue}'");
            Assert.AreEqual(valorSByte, sbyte.MaxValue, $"Se esperaba el valor '{sbyte.MaxValue}'");
            Assert.AreEqual(valorShort, short.MaxValue, $"Se esperaba el valor '{short.MaxValue}'");
            Assert.AreEqual(valorString, "abcdefghijklmnopqrstuvwxyz", $"Se esperaba el valor 'abcdefghijklmnopqrstuvwxyz'");
            Assert.AreEqual(valorUInteger, uint.MaxValue, $"Se esperaba el valor '{uint.MaxValue}'");
            Assert.AreEqual(valorULong, ulong.MaxValue, $"Se esperaba el valor '{ulong.MaxValue}'");
            Assert.AreEqual(valorUShort, ushort.MaxValue, $"Se esperaba el valor '{ushort.MaxValue}'");

        }

        [TestMethod]
        [TestCategory("ObjetoDatosPath")]
        public void PruebaObjetoDatosPathObtenerPorTipo()
        {

            ObjetoDatos od = ConstruirObjetoDatosComplejo(2);

            string ruta = "ReferenciaObjetoDatos";

            bool valorBoolean = od.ObtenerBoolean($"{ruta}/atributoBoolean");
            byte valorByte = od.ObtenerByte($"{ruta}/atributoByte");
            char valorChar = od.ObtenerChar($"{ruta}/atributoChar");
            DateTime valorDateTime = od.ObtenerDateTime($"{ruta}/atributoDateTime");
            decimal valorDecimal = od.ObtenerDecimal($"{ruta}/atributoDecimal");
            double valorDouble = od.ObtenerDouble($"{ruta}/atributoDouble");
            float valorFloat = od.ObtenerFloat($"{ruta}/atributoFloat");
            int valorInteger = od.ObtenerInteger($"{ruta}/atributoInteger");
            long valorLong = od.ObtenerLong($"{ruta}/atributoLong");
            sbyte valorSByte = od.ObtenerSByte($"{ruta}/atributoSByte");
            short valorShort = od.ObtenerShort($"{ruta}/atributoShort");
            string valorString = od.ObtenerString($"{ruta}/atributoString");
            uint valorUInteger = od.ObtenerUInteger($"{ruta}/atributoUInteger");
            ulong valorULong = od.ObtenerULong($"{ruta}/atributoULong");
            ushort valorUShort = od.ObtenerUShort($"{ruta}/atributoUShort");


            Assert.AreEqual(valorBoolean, true, "Se esperaba el valor true.");
            Assert.AreEqual(valorByte, byte.MaxValue, $"Se esperaba el valor '{byte.MaxValue}'");
            Assert.AreEqual(valorChar, char.MaxValue, $"Se esperaba el valor '{char.MaxValue}'");
            Assert.AreEqual(valorDateTime, DateTime.MaxValue, $"Se esperaba el valor '{DateTime.MaxValue}'");
            Assert.AreEqual(valorDecimal, decimal.MaxValue, $"Se esperaba el valor '{decimal.MaxValue}'");
            Assert.AreEqual(valorDouble, double.MaxValue, $"Se esperaba el valor '{double.MaxValue}'");
            Assert.AreEqual(valorFloat, float.MaxValue, $"Se esperaba el valor '{float.MaxValue}'");
            Assert.AreEqual(valorInteger, int.MaxValue, $"Se esperaba el valor '{int.MaxValue}'");
            Assert.AreEqual(valorLong, long.MaxValue, $"Se esperaba el valor '{long.MaxValue}'");
            Assert.AreEqual(valorSByte, sbyte.MaxValue, $"Se esperaba el valor '{sbyte.MaxValue}'");
            Assert.AreEqual(valorShort, short.MaxValue, $"Se esperaba el valor '{short.MaxValue}'");
            Assert.AreEqual(valorString, "abcdefghijklmnopqrstuvwxyz", $"Se esperaba el valor 'abcdefghijklmnopqrstuvwxyz'");
            Assert.AreEqual(valorUInteger, uint.MaxValue, $"Se esperaba el valor '{uint.MaxValue}'");
            Assert.AreEqual(valorULong, ulong.MaxValue, $"Se esperaba el valor '{ulong.MaxValue}'");
            Assert.AreEqual(valorUShort, ushort.MaxValue, $"Se esperaba el valor '{ushort.MaxValue}'");

        }
    }
}
