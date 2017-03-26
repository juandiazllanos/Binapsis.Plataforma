﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Binapsis.Plataforma.Estructura;
using Binapsis.Plataforma.Estructura.Impl;
using Binapsis.Plataforma.Serializacion.Xml;
using Binapsis.Plataforma.Serializacion.Binario;

namespace Binapsis.Plataforma.Serializacion.Test
{
    /// <summary>
    /// Descripción resumida de SerializacionXmlEnFichero
    /// </summary>
    [TestClass]
    public class SerializacionEnFichero
    {
        IObjetoDatos _od;
        IObjetoDatos _odx;
        IObjetoDatos _od2;
        IObjetoDatos _odx2;
        IObjetoDatos _od3;
        IObjetoDatos _odx3;

        public SerializacionEnFichero()
        {
            _od = BuilderObjetoDatos.Construir();
            _odx = BuilderObjetoDatos.Construir(2, 5);

            _od2 = BuilderObjetoDatos.Construir2();
            _odx2 = BuilderObjetoDatos.Construir2(2, 5);

            _od3 = BuilderObjetoDatos.Construir3();
            _odx3 = BuilderObjetoDatos.Construir3(2, 5);
        }

        #region Atributos de prueba adicionales
        //
        // Puede usar los siguientes atributos adicionales conforme escribe las pruebas:
        //
        // Use ClassInitialize para ejecutar el código antes de ejecutar la primera prueba en la clase
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup para ejecutar el código una vez ejecutadas todas las pruebas en una clase
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Usar TestInitialize para ejecutar el código antes de ejecutar cada prueba 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup para ejecutar el código una vez ejecutadas todas las pruebas
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod, TestCategory("Serializacion Xml")]
        public void SerializarObjetoDatosEnXml()
        {
            ISecuencia fichero = new FicheroImpl("od.xml");
            IEscritor escritor = new EscritorXml();            
            ILector lector = new LectorXml();

            SerializarObjetoDatos(fichero, escritor, lector);
        }
        
        [TestMethod, TestCategory("Serializacion Xml")]
        public void SerializarObjetoDatosXEnXml()
        {
            ISecuencia fichero = new FicheroImpl("odx.xml");
            IEscritor escritor = new EscritorXml();            
            ILector lector = new LectorXml();

            SerializarObjetoDatosX(fichero, escritor, lector);
        }

        [TestMethod, TestCategory("Serializacion Xml")]
        public void SerializarObjetoDatos2EnXml()
        {
            ISecuencia fichero = new FicheroImpl("od2.xml");
            IEscritor escritor = new EscritorXml();
            ILector lector = new LectorXml();

            SerializarObjetoDatos2(fichero, escritor, lector);
        }

        [TestMethod, TestCategory("Serializacion Xml")]
        public void SerializarObjetoDatosX2EnXml()
        {
            ISecuencia fichero = new FicheroImpl("odx2.xml");
            IEscritor escritor = new EscritorXml();
            ILector lector = new LectorXml();

            SerializarObjetoDatosX2(fichero, escritor, lector);
        }

        [TestMethod, TestCategory("Serializacion Xml")]
        public void SerializarObjetoDatos3EnXml()
        {
            ISecuencia fichero = new FicheroImpl("od3.xml");
            IEscritor escritor = new EscritorXml();
            ILector lector = new LectorXml();

            SerializarObjetoDatos3(fichero, escritor, lector);
        }

        [TestMethod, TestCategory("Serializacion Xml")]
        public void SerializarObjetoDatosX3EnXml()
        {
            ISecuencia fichero = new FicheroImpl("odx3.xml");
            IEscritor escritor = new EscritorXml();
            ILector lector = new LectorXml();

            SerializarObjetoDatosX3(fichero, escritor, lector);
        }


        [TestMethod, TestCategory("Serializacion Binario")]
        public void SerializarObjetoDatosEnBinario()
        {
            ISecuencia fichero = new FicheroImpl("od.bin");
            IEscritor escritor = new EscritorBinario();
            ILector lector = new LectorBinario();

            SerializarObjetoDatos(fichero, escritor, lector);
        }

        [TestMethod, TestCategory("Serializacion Binario")]
        public void SerializarObjetoDatosXEnBinario()
        {
            ISecuencia fichero = new FicheroImpl("odx.bin");
            IEscritor escritor = new EscritorBinario();
            ILector lector = new LectorBinario();

            SerializarObjetoDatosX(fichero, escritor, lector);
        }

        [TestMethod, TestCategory("Serializacion Binario")]
        public void SerializarObjetoDatos2EnBinario()
        {
            ISecuencia fichero = new FicheroImpl("od2.bin");
            IEscritor escritor = new EscritorBinario();
            ILector lector = new LectorBinario();

            SerializarObjetoDatos2(fichero, escritor, lector);
        }

        [TestMethod, TestCategory("Serializacion Binario")]
        public void SerializarObjetoDatosX2EnBinario()
        {
            ISecuencia fichero = new FicheroImpl("odx2.bin");
            IEscritor escritor = new EscritorBinario();
            ILector lector = new LectorBinario();

            SerializarObjetoDatosX2(fichero, escritor, lector);
        }

        [TestMethod, TestCategory("Serializacion Binario")]
        public void SerializarObjetoDatos3EnBinario()
        {
            ISecuencia fichero = new FicheroImpl("od3.bin");
            IEscritor escritor = new EscritorBinario();
            ILector lector = new LectorBinario();

            SerializarObjetoDatos3(fichero, escritor, lector);
        }

        [TestMethod, TestCategory("Serializacion Binario")]
        public void SerializarObjetoDatosX3EnBinario()
        {
            ISecuencia fichero = new FicheroImpl("odx3.bin");
            IEscritor escritor = new EscritorBinario();
            ILector lector = new LectorBinario();

            SerializarObjetoDatosX3(fichero, escritor, lector);
        }

        [TestMethod]
        void SerializarObjetoDatos(ISecuencia secuencia, IEscritor escritor, ILector lector)
        {
            Serializar(secuencia, escritor, lector, _od);
        }

        [TestMethod]
        void SerializarObjetoDatos2(ISecuencia secuencia, IEscritor escritor, ILector lector)
        {
            Serializar(secuencia, escritor, lector, _od2);
        }

        [TestMethod]
        void SerializarObjetoDatos3(ISecuencia secuencia, IEscritor escritor, ILector lector)
        {
            Serializar(secuencia, escritor, lector, _od3);
        }

        [TestMethod]
        void SerializarObjetoDatosX(ISecuencia secuencia, IEscritor escritor, ILector lector)
        {
            Serializar(secuencia, escritor, lector, _odx);
        }

        [TestMethod]
        void SerializarObjetoDatosX2(ISecuencia secuencia, IEscritor escritor, ILector lector)
        {
            Serializar(secuencia, escritor, lector, _odx2);
        }

        [TestMethod]
        void SerializarObjetoDatosX3(ISecuencia secuencia, IEscritor escritor, ILector lector)
        {
            Serializar(secuencia, escritor, lector, _odx3);
        }

        [TestMethod]
        void Serializar(ISecuencia secuencia, IEscritor escritor, ILector lector, IObjetoDatos od)
        {
            Serializador serializador = new Serializador(secuencia, escritor);
            serializador.Serializar(od);

            IObjetoDatos od2 = Fabrica.Instancia.Crear(od.Tipo);
            Deserializador deserializador = new Deserializador(secuencia, lector);
            deserializador.Deserializar(od2);

            CompararObjetoDatos(od, od2);
        }


        [TestMethod]
        void CompararObjetoDatos(IObjetoDatos od1, IObjetoDatos od2)
        {
            Assert.AreEqual(od1.ObtenerInteger("atributoId"), od2.ObtenerInteger("atributoId"));
            Assert.AreEqual(od1.ObtenerByte("atributoBoolean"), od2.ObtenerByte("atributoBoolean"));
            Assert.AreEqual(od1.ObtenerByte("atributoByte"), od2.ObtenerByte("atributoByte"));
            Assert.AreEqual(od1.ObtenerChar("atributoChar"), od2.ObtenerChar("atributoChar"));
            Assert.AreEqual(od1.ObtenerDateTime("atributoDateTime").Date, od2.ObtenerDateTime("atributoDateTime").Date);
            Assert.AreEqual(od1.ObtenerDateTime("atributoDateTime").Hour, od2.ObtenerDateTime("atributoDateTime").Hour);
            Assert.AreEqual(od1.ObtenerDateTime("atributoDateTime").Minute, od2.ObtenerDateTime("atributoDateTime").Minute);
            Assert.AreEqual(od1.ObtenerDateTime("atributoDateTime").Second, od2.ObtenerDateTime("atributoDateTime").Second);
            Assert.AreEqual(od1.ObtenerDecimal("atributoDecimal"), od2.ObtenerDecimal("atributoDecimal"));
            Assert.AreEqual(od1.ObtenerDouble("atributoDouble"), od2.ObtenerDouble("atributoDouble"));
            Assert.AreEqual(od1.ObtenerFloat("atributoFloat"), od2.ObtenerFloat("atributoFloat"));
            Assert.AreEqual(od1.ObtenerInteger("atributoInteger"), od2.ObtenerInteger("atributoInteger"));
            Assert.AreEqual(od1.ObtenerLong("atributoLong"), od2.ObtenerLong("atributoLong"));
            Assert.AreEqual(od1.ObtenerSByte("atributoSByte"), od2.ObtenerSByte("atributoSByte"));
            Assert.AreEqual(od1.ObtenerShort("atributoShort"), od2.ObtenerShort("atributoShort"));
            Assert.AreEqual(od1.ObtenerString("atributoString"), od2.ObtenerString("atributoString"));
            Assert.AreEqual(od1.ObtenerUShort("atributoUShort"), od2.ObtenerUShort("atributoUShort"));
            Assert.AreEqual(od1.ObtenerUInteger("atributoUInteger"), od2.ObtenerUInteger("atributoUInteger"));
            Assert.AreEqual(od1.ObtenerULong("atributoULong"), od2.ObtenerULong("atributoULong"));

            Assert.AreEqual(od1.ObtenerObjetoDatos("ReferenciaObjetoDatos") != null, od2.ObtenerObjetoDatos("ReferenciaObjetoDatos") != null);
            Assert.AreEqual(od1.ObtenerColeccion("ReferenciaObjetoDatosItem").Longitud, od2.ObtenerColeccion("ReferenciaObjetoDatosItem").Longitud);

            if (od1.ObtenerObjetoDatos("ReferenciaObjetoDatos") != null && od2.ObtenerObjetoDatos("ReferenciaObjetoDatos") != null)
                CompararObjetoDatos(od1.ObtenerObjetoDatos("ReferenciaObjetoDatos"), od2.ObtenerObjetoDatos("ReferenciaObjetoDatos"));

            for( int i = 0; i < od1.ObtenerColeccion("ReferenciaObjetoDatosItem").Longitud; i++ )
            {
                CompararObjetoDatos(od1.ObtenerColeccion("ReferenciaObjetoDatosItem")[i], od2.ObtenerColeccion("ReferenciaObjetoDatosItem")[i]);
            }



            // compracion tipo2
            if (od1.Tipo.ObtenerPropiedad("ReferenciaObjetoDatos2") == null) return;

            Assert.AreEqual(od1.ObtenerObjetoDatos("ReferenciaObjetoDatos2") != null, od2.ObtenerObjetoDatos("ReferenciaObjetoDatos2") != null);

            if (od1.ObtenerObjetoDatos("ReferenciaObjetoDatos2") != null && od2.ObtenerObjetoDatos("ReferenciaObjetoDatos2") != null)
                CompararObjetoDatos(od1.ObtenerObjetoDatos("ReferenciaObjetoDatos2"), od2.ObtenerObjetoDatos("ReferenciaObjetoDatos2"));



            // comparacion tipo 3
            if (od1.Tipo.ObtenerPropiedad("ReferenciaObjetoDatosItem2") == null) return;

            Assert.AreEqual(od1.ObtenerObjetoDatos("ReferenciaObjetoDatosItem2") != null, od2.ObtenerObjetoDatos("ReferenciaObjetoDatosItem2") != null);
            
            if (od1.ObtenerObjetoDatos("ReferenciaObjetoDatosItem2") != null)
            {
                Assert.AreEqual(od1.ObtenerObjetoDatos("ReferenciaObjetoDatosItem2"), od1.ObtenerObjetoDatos("ReferenciaObjetoDatosItem[0]"));
                Assert.AreEqual(od2.ObtenerObjetoDatos("ReferenciaObjetoDatosItem2"), od2.ObtenerObjetoDatos("ReferenciaObjetoDatosItem[0]"));
            }
        }        
    }
}
