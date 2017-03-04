using Microsoft.VisualStudio.TestTools.UnitTesting;
using Binapsis.Plataforma.Estructura;
using Binapsis.Plataforma.Serializacion.Binario;

namespace Binapsis.Plataforma.Serializacion.Test
{
    /// <summary>
    /// Descripción resumida de PruebaSerializacionBinariaEnFichero
    /// </summary>
    [TestClass]
    public class SerializacionBinariaEnFichero
    {
        IObjetoDatos _od;
        IObjetoDatos _odx;
        IObjetoDatos _odx2;

        public SerializacionBinariaEnFichero()
        {
            ITipo tipo = TipoBuilder.Construir();
            ITipo tipo2 = TipoBuilder.Construir2();

            _od = ObjetoDatosBuilder.Construir(tipo);
            _odx = ObjetoDatosBuilder.Construir(tipo, 2, 100);
            _odx2 = ObjetoDatosBuilder.Construir2(tipo2, 2, 100);
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Obtiene o establece el contexto de las pruebas que proporciona
        ///información y funcionalidad para la serie de pruebas actual.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
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
        
        [TestMethod]
        [TestCategory("Serializacion Binaria")]
        public void SerializarObjetoDatos()
        {
            ISecuencia fichero = new FicheroImpl("od");
            IEscritor escritor = new EscritorBinario();
            Serializador serializador = new Serializador(fichero, escritor);

            serializador.Serializar(_od);

            fichero = new FicheroImpl("odx");
            serializador = new Serializador(fichero, escritor);

            serializador.Serializar(_odx);

            fichero = new FicheroImpl("odx2");
            serializador = new Serializador(fichero, escritor);

            serializador.Serializar(_odx2);

            Assert.AreEqual(_od.ObtenerBoolean(0), true);
        }

        [TestMethod]
        [TestCategory("Serializacion Binaria")]
        public void DeserializarObjetoDatos()
        {
            ISecuencia fichero = new FicheroImpl("od");
            ILector lector = new LectorBinario();
            Deserializador deserializador = new Deserializador(fichero, lector);
            IObjetoDatos od = FabricaObjetoDatos.Crear(TipoBuilder.Construir());

            deserializador.Deserializar(od);


            fichero = new FicheroImpl("odx");
            deserializador = new Deserializador(fichero, lector);
            IObjetoDatos odx = FabricaObjetoDatos.Crear(TipoBuilder.Construir());

            deserializador.Deserializar(odx);

            fichero = new FicheroImpl("odx2.xml");
            deserializador = new Deserializador(fichero, lector);
            IObjetoDatos odx2 = FabricaObjetoDatos.Crear(TipoBuilder.Construir2());

            deserializador.Deserializar(odx2);

            Assert.AreEqual(od.Obtener(0), _od.Obtener(0));
            Assert.AreEqual(od.Obtener(1), _od.Obtener(1));
            Assert.AreEqual(od.Obtener(2), _od.Obtener(2));
            Assert.AreEqual(od.Obtener(3), _od.Obtener(3));
            Assert.AreEqual(od.Obtener(4), _od.Obtener(4));
            Assert.AreEqual(od.Obtener(5), _od.Obtener(5));
            Assert.AreEqual(od.Obtener(6), _od.Obtener(6));
            Assert.AreEqual(od.Obtener(7), _od.Obtener(7));
            Assert.AreEqual(od.Obtener(8), _od.Obtener(8));
            Assert.AreEqual(od.Obtener(9), _od.Obtener(9));
            Assert.AreEqual(od.Obtener(10), _od.Obtener(10));
            Assert.AreEqual(od.Obtener(11), _od.Obtener(11));
            Assert.AreEqual(od.Obtener(12), _od.Obtener(12));
            Assert.AreEqual(od.Obtener(13), _od.Obtener(13));
            Assert.AreEqual(od.Obtener(14), _od.Obtener(14));

            Assert.AreEqual(odx.Obtener(0), _odx.Obtener(0));
            Assert.AreEqual(odx.Obtener(1), _odx.Obtener(1));
            Assert.AreEqual(odx.Obtener(2), _odx.Obtener(2));
            Assert.AreEqual(odx.Obtener(3), _odx.Obtener(3));
            Assert.AreEqual(odx.Obtener(4), _odx.Obtener(4));
            Assert.AreEqual(odx.Obtener(5), _odx.Obtener(5));
            Assert.AreEqual(odx.Obtener(6), _odx.Obtener(6));
            Assert.AreEqual(odx.Obtener(7), _odx.Obtener(7));
            Assert.AreEqual(odx.Obtener(8), _odx.Obtener(8));
            Assert.AreEqual(odx.Obtener(9), _odx.Obtener(9));
            Assert.AreEqual(odx.Obtener(10), _odx.Obtener(10));
            Assert.AreEqual(odx.Obtener(11), _odx.Obtener(11));
            Assert.AreEqual(odx.Obtener(12), _odx.Obtener(12));
            Assert.AreEqual(odx.Obtener(13), _odx.Obtener(13));
            Assert.AreEqual(odx.Obtener(14), _odx.Obtener(14));

            Assert.AreEqual(odx.ObtenerColeccion("ReferenciaObjetoDatosItem").Longitud, _odx.ObtenerColeccion("ReferenciaObjetoDatosItem").Longitud);
            Assert.AreEqual(odx.Obtener("ReferenciaObjetoDatosItem[1]/atributoBoolean"), _odx.Obtener("ReferenciaObjetoDatosItem[1]/atributoBoolean"));
            Assert.AreEqual(odx.Obtener("ReferenciaObjetoDatosItem[1]/atributoString"), _odx.Obtener("ReferenciaObjetoDatosItem[1]/atributoString"));
            Assert.AreEqual(odx.Obtener("ReferenciaObjetoDatosItem[1]/ReferenciaObjetoDatosItem[1]/atributoString"), _odx.Obtener("ReferenciaObjetoDatosItem[1]/ReferenciaObjetoDatosItem[1]/atributoString"));

            Assert.AreEqual(_odx2.Obtener("ObjetoDatos/atributoBoolean"), odx2.Obtener("ObjetoDatos/atributoBoolean"));
            Assert.AreEqual(_odx2.Obtener("Resumen/creacion"), odx2.Obtener("Resumen/creacion"));

        }
    }
}
