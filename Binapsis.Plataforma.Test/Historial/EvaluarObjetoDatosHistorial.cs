using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Binapsis.Plataforma.Estructura;
using Binapsis.Plataforma.Historial;

namespace Binapsis.Plataforma.Test.Historial
{
    [TestClass]
    public class PruebaDecoradorHistorial
    {
        [TestMethod, TestCategory("Recuperacion de estado")]
        public void DeshacerCambiosEnObjetoDatos()
        {
            // arrange
            Log controlador = new Log();
            //FabricaHistorial fabrica = new FabricaHistorial();
            IFabrica fabrica = new FabricaHistorial(controlador);
            IObjetoDatos od = fabrica.Crear(HelperTipo.ObtenerTipo());

            // act 
            bool valorBoolean = od.ObtenerBoolean(0);
            byte valorByte = od.ObtenerByte(1);
            char valorChar = od.ObtenerChar(2);
            DateTime valorDateTime = od.ObtenerDateTime(3);
            var valorDecimal = od.ObtenerDecimal(4);
            var valorDouble = od.ObtenerDouble(5);
            var valorFloat = od.ObtenerFloat(6);
            var valorInteger = od.ObtenerInteger(7);
            var valorLong = od.ObtenerLong(8);
            var valorSByte = od.ObtenerSByte(9);
            var valorShort = od.ObtenerShort(10);
            var valorString = od.ObtenerString(11);
            var valorUInteger = od.ObtenerUInteger(12);
            var valorULong = od.ObtenerULong(13);
            var valorUShort = od.ObtenerUShort(14);

            // establecer valores
            //EstablecerValoresPorIndice(od);
            Helper.Construir(od);

            // deshacer cambios 
            controlador.Deshacer();

            //// establecer valores
            ////EstablecerValoresPorTipoPorIndice(od);
            //Helper.Construir(od);

            //// deshacer cambios 
            //controlador.Deshacer();

            // assert 
            Assert.AreEqual(od.ObtenerBoolean(0), valorBoolean, $"Se esperaba {valorBoolean}");
            Assert.AreEqual(od.ObtenerByte(1), valorByte, $"Se esperaba {valorByte}");
            Assert.AreEqual(od.ObtenerChar(2), valorChar, $"Se esperaba {valorChar}");
            Assert.AreEqual(od.ObtenerDateTime(3), valorDateTime, $"Se esperaba {valorDateTime}");
            Assert.AreEqual(od.ObtenerDecimal(4), valorDecimal, $"Se esperaba {valorDecimal}");
            Assert.AreEqual(od.ObtenerDouble(5), valorDouble, $"Se esperaba {valorDouble}");
            Assert.AreEqual(od.ObtenerFloat(6), valorFloat, $"Se esperaba {valorFloat}");
            Assert.AreEqual(od.ObtenerInteger(7), valorInteger, $"Se esperaba {valorInteger}");
            Assert.AreEqual(od.ObtenerLong(8), valorInteger, $"Se esperaba {valorInteger}");
            Assert.AreEqual(od.ObtenerSByte(9), valorSByte, $"Se esperaba {valorSByte}");
            Assert.AreEqual(od.ObtenerShort(10), valorShort, $"Se esperaba {valorShort}");
            Assert.AreEqual(od.ObtenerString(11), valorString, $"Se esperaba {valorString ?? ""}");
            Assert.AreEqual(od.ObtenerUInteger(12), valorUInteger, $"Se esperaba {valorUInteger}");
            Assert.AreEqual(od.ObtenerULong(13), valorULong, $"Se esperaba {valorULong}");
            Assert.AreEqual(od.ObtenerUShort(14), valorUShort, $"Se esperaba {valorUShort}");

        }

        [TestMethod, TestCategory("Recuperacion de estado")]
        public void DeshacerCambiosEnObjetoDatosX()
        {
            // arrange
            Log controlador = new Log();
            //FabricaHistorial fabrica = new FabricaHistorial();
            IFabrica fabrica = new FabricaHistorial(controlador);
            IObjetoDatos od = fabrica.Crear(HelperTipo.ObtenerTipo2());

            // act
            //ConstruirObjetoDatosComplejo(od, 2);
            //od.CrearObjetoDatos("ReferenciaObjetoDatos");
            //od.CrearObjetoDatos("ReferenciaObjetoDatosItem");
            Helper.Construir(od, 1);

            // deshacer 
            controlador.Deshacer();

            Assert.IsNull(od.ObtenerObjetoDatos("ReferenciaObjetoDatos"), "Se esperaba null");
            Assert.AreEqual(od.ObtenerColeccion("ReferenciaObjetoDatosItem").Longitud, 0, "Se esperaba cero.");
        }

        [TestMethod, TestCategory("Recuperacion de estado")]
        public void RecuperarInstantaneaEnObjetoDatos()
        {
            // arrange
            Log log = new Log();
            //FabricaHistorial fabrica = new FabricaHistorial();
            IFabrica fabrica = new FabricaHistorial(log);
            IObjetoDatos od = fabrica.Crear(HelperTipo.ObtenerTipo());

            // act 
            bool valorBoolean = od.ObtenerBoolean(0);
            byte valorByte = od.ObtenerByte(1);
            char valorChar = od.ObtenerChar(2);
            DateTime valorDateTime = od.ObtenerDateTime(3);
            var valorDecimal = od.ObtenerDecimal(4);
            var valorDouble = od.ObtenerDouble(5);
            var valorFloat = od.ObtenerFloat(6);
            var valorInteger = od.ObtenerInteger(7);
            var valorLong = od.ObtenerLong(8);
            var valorSByte = od.ObtenerSByte(9);
            var valorShort = od.ObtenerShort(10);
            var valorString = od.ObtenerString(11);
            var valorUInteger = od.ObtenerUInteger(12);
            var valorULong = od.ObtenerULong(13);
            var valorUShort = od.ObtenerUShort(14);

            // establecer valores
            var instantanea1 = log.CrearInstantanea();
            od.EstablecerBoolean("atributoBoolean", true);

            var instantanea2 = log.CrearInstantanea();
            od.EstablecerByte("atributoByte", byte.MaxValue);

            var instantanea3 = log.CrearInstantanea();
            od.EstablecerChar("atributoChar", char.MaxValue);

            var instantanea4 = log.CrearInstantanea();
            od.EstablecerDateTime("atributoDateTime", DateTime.MaxValue);

            // recuperar
            log.Recuperar(instantanea3);
            
            // assert 
            Assert.AreEqual(od.ObtenerBoolean(0), true, $"Se esperaba {valorBoolean}");
            Assert.AreEqual(od.ObtenerByte(1), byte.MaxValue, $"Se esperaba {valorByte}");
            Assert.AreEqual(od.ObtenerChar(2), valorChar, $"Se esperaba {valorChar}");
            Assert.AreEqual(od.ObtenerDateTime(3), valorDateTime, $"Se esperaba {valorDateTime}");

            // recuperar
            log.Recuperar(instantanea1);

            // assert 
            Assert.AreEqual(od.ObtenerBoolean(0), valorBoolean, $"Se esperaba {valorBoolean}");
            Assert.AreEqual(od.ObtenerByte(1), valorByte, $"Se esperaba {valorByte}");
            Assert.AreEqual(od.ObtenerChar(2), valorChar, $"Se esperaba {valorChar}");
            Assert.AreEqual(od.ObtenerDateTime(3), valorDateTime, $"Se esperaba {valorDateTime}");

        }

        [TestMethod, TestCategory("Recuperacion de estado")]
        public void RecuperarInstantaneaEnObjetoDatosX()
        {
            // arrange
            Log log = new Log();            
            IFabrica fabrica = new FabricaHistorial(log);
            IObjetoDatos od = fabrica.Crear(HelperTipo.ObtenerTipo2());

            // act
            var instantanea1 = log.CrearInstantanea();
            od.CrearObjetoDatos("ReferenciaObjetoDatos");

            var instantanea2 = log.CrearInstantanea();
            od.CrearObjetoDatos("ReferenciaObjetoDatosItem");

            var instantanea3 = log.CrearInstantanea();
            od.CrearObjetoDatos("ReferenciaObjetoDatosItem");

            var instantanea4 = log.CrearInstantanea();
            od.CrearObjetoDatos("ReferenciaObjetoDatosItem[0]/ReferenciaObjetoDatos");

            var instantanea5 = log.CrearInstantanea();
            od.CrearObjetoDatos("ReferenciaObjetoDatosItem[1]/ReferenciaObjetoDatos");

            var valorBoolean = od.Obtener("atributoBoolean");
            var valorByte = od.Obtener("atributoByte");

            var instantanea6 = log.CrearInstantanea();
            od.EstablecerBoolean("ReferenciaObjetoDatosItem[1]/ReferenciaObjetoDatos/atributoBoolean", true);
            od.EstablecerByte("ReferenciaObjetoDatosItem[1]/ReferenciaObjetoDatos/atributoByte", byte.MaxValue);

            Assert.AreEqual(od.ObtenerBoolean("ReferenciaObjetoDatosItem[1]/ReferenciaObjetoDatos/atributoBoolean"), true);
            Assert.AreEqual(od.ObtenerByte("ReferenciaObjetoDatosItem[1]/ReferenciaObjetoDatos/atributoByte"), byte.MaxValue);

            // recuperar
            log.Recuperar(instantanea6);

            Assert.AreEqual(od.ObtenerBoolean("ReferenciaObjetoDatosItem[1]/ReferenciaObjetoDatos/atributoBoolean"), valorBoolean);
            Assert.AreEqual(od.ObtenerByte("ReferenciaObjetoDatosItem[1]/ReferenciaObjetoDatos/atributoByte"), valorByte);


            // recuperar
            log.Recuperar(instantanea5);
            
            Assert.IsNull(od.Obtener("ReferenciaObjetoDatosItem[1]/ReferenciaObjetoDatos"));

            // recuperar
            log.Recuperar(instantanea4);

            Assert.IsNull(od.Obtener("ReferenciaObjetoDatosItem[0]/ReferenciaObjetoDatos"));

            // recuperar
            log.Recuperar(instantanea3);

            Assert.AreEqual(od.ObtenerColeccion("ReferenciaObjetoDatosItem").Longitud, 1);

            // recuperar
            log.Recuperar(instantanea2);

            Assert.AreEqual(od.ObtenerColeccion("ReferenciaObjetoDatosItem").Longitud, 0);

            // recuperar
            log.Recuperar(instantanea1);

            Assert.IsNull(od.Obtener("ReferenciaObjetoDatos"));

        }
    }

}
