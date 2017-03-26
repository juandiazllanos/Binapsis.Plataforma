using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Binapsis.Plataforma.Estructura;
using Binapsis.Plataforma.Serializacion.Interno;
using Binapsis.Plataforma.Serializacion.Interno;
using Binapsis.Plataforma.Estructura.Impl;

namespace Binapsis.Plataforma.Serializacion.Test
{
    [TestClass]
    public class ConstruirDiagrama
    {
        //[TestMethod]
        //public void CrearHeap()
        //{
        //    IObjetoDatos od = Helper.ConstruirObjetoDatosComplejo(1);
        //    HelperHeap helper = new HelperHeap();
        //    Heap heap = helper.Crear(od);

        //    IObjetoDatos od1 = od.ObtenerObjetoDatos("ReferenciaObjetoDatos");
        //    IObjetoDatos item1 = od.ObtenerObjetoDatos("ReferenciaObjetoDatosItem[0]");
        //    IObjetoDatos item2 = od.ObtenerObjetoDatos("ReferenciaObjetoDatosItem[1]");
        //    IObjetoDatos item3 = od.ObtenerObjetoDatos("ReferenciaObjetoDatosItem[2]");


        //    ObjetoMap omap = heap.Obtener(od);

        //    Assert.IsNotNull(omap);
        //    Assert.AreEqual(od, omap.ObjetoDatos);
        //    Assert.AreEqual("", omap.Propietario);
        //    Assert.AreEqual(1, omap.Id);

        //    omap = heap.Obtener(od1);

        //    Assert.IsNotNull(omap);
        //    Assert.AreEqual(od1, omap.ObjetoDatos);
        //    Assert.AreEqual("/ReferenciaObjetoDatos", omap.Propietario);
        //    Assert.AreNotEqual(1, omap.Id);

        //    omap = heap.Obtener(item1);

        //    Assert.IsNotNull(omap);
        //    Assert.AreEqual(item1, omap.ObjetoDatos);
        //    Assert.AreEqual("/ReferenciaObjetoDatosItem[0]", omap.Propietario);
        //    Assert.AreNotEqual(1, omap.Id);

        //    omap = heap.Obtener(item2);

        //    Assert.IsNotNull(omap);
        //    Assert.AreEqual(item2, omap.ObjetoDatos);
        //    Assert.AreEqual("/ReferenciaObjetoDatosItem[1]", omap.Propietario);
        //    Assert.AreNotEqual(1, omap.Id);

        //    omap = heap.Obtener(item3);

        //    Assert.IsNotNull(omap);
        //    Assert.AreEqual(item3, omap.ObjetoDatos);
        //    Assert.AreEqual("/ReferenciaObjetoDatosItem[2]", omap.Propietario);
        //    Assert.AreNotEqual(1, omap.Id);
        //}

        [TestMethod]
        public void CrearDiagramaComposicion()
        {            
            IObjetoDatos od = Helper.ConstruirObjetoDatosComplejo(1);
            
            // establecer referencia2
            od.EstablecerObjetoDatos("ReferenciaObjetoDatosItem2", od.ObtenerColeccion("ReferenciaObjetoDatosItem")[0]);

            BuilderDiagrama helper = new BuilderDiagrama();
            Diagrama diag = helper.Crear(od);
            
            IPropiedad prop1 = od.Tipo.ObtenerPropiedad("ReferenciaObjetoDatos");
            IPropiedad prop2 = od.Tipo.ObtenerPropiedad("ReferenciaObjetoDatosItem2");
            IPropiedad prop3 = od.Tipo.ObtenerPropiedad("ReferenciaObjetoDatosItem");

            IObjetoDatos od1 = od.ObtenerObjetoDatos(prop1);
            IObjetoDatos od2 = od.ObtenerObjetoDatos(prop2);
            IObjetoDatos item1 = od.ObtenerColeccion(prop3)[0];
            IObjetoDatos item2 = od.ObtenerColeccion(prop3)[1];
            IObjetoDatos item3 = od.ObtenerColeccion(prop3)[2];           
            

            NodoReferencia nodoprop1 = (NodoReferencia)diag.Root.Nodos[0];
            NodoReferencia nodoprop2 = (NodoReferencia)diag.Root.Nodos[2];
            NodoReferencia nodoprop3 = (NodoReferencia)diag.Root.Nodos[3];
            NodoObjeto nodoobj1 = (NodoObjeto)nodoprop1.Nodos[0];
            NodoObjeto nodoobj2 = (NodoObjeto)nodoprop2.Nodos[0];
            NodoObjeto nodoitem1 = (NodoObjeto)nodoprop3.Nodos[0];
            NodoObjeto nodoitem2 = (NodoObjeto)nodoprop3.Nodos[1];
            NodoObjeto nodoitem3 = (NodoObjeto)nodoprop3.Nodos[2];
            

            Assert.IsNotNull(diag.Root);
            Assert.AreEqual(od, diag.Root.Objeto.ObjetoDatos);

            Assert.IsNotNull(nodoprop1);
            Assert.IsNotNull(prop1);
            Assert.AreEqual(prop1, nodoprop1.Propiedad);

            Assert.IsNotNull(nodoobj1);
            Assert.IsNotNull(od1);
            Assert.AreEqual(od1, nodoobj1.Objeto.ObjetoDatos);
            Assert.AreEqual("/ReferenciaObjetoDatos", nodoobj1.Objeto.Propietario);

            Assert.IsNotNull(prop3);
            Assert.IsNotNull(nodoprop3);
            Assert.AreEqual(prop3, nodoprop3.Propiedad);

            Assert.IsNotNull(nodoitem1);
            Assert.IsNotNull(item1);
            Assert.AreEqual(item1, nodoitem1.Objeto.ObjetoDatos);
            Assert.AreEqual("/ReferenciaObjetoDatosItem[0]", nodoitem1.Objeto.Propietario);

            Assert.IsNotNull(nodoitem2);
            Assert.IsNotNull(item2);
            Assert.AreEqual(item2, nodoitem2.Objeto.ObjetoDatos);
            Assert.AreEqual("/ReferenciaObjetoDatosItem[1]", nodoitem2.Objeto.Propietario);

            Assert.IsNotNull(nodoitem3);
            Assert.IsNotNull(item3);
            Assert.AreEqual(item3, nodoitem3.Objeto.ObjetoDatos);
            Assert.AreEqual("/ReferenciaObjetoDatosItem[2]", nodoitem3.Objeto.Propietario);

            // comprobar referencia agregacion 
            Assert.IsNotNull(prop2);
            Assert.IsNotNull(nodoprop2);
            Assert.AreEqual(prop2, nodoprop2.Propiedad);

            Assert.AreEqual(od2, item1);
            Assert.IsNotNull(nodoobj2);
            Assert.AreEqual(item1, nodoobj2.Objeto.ObjetoDatos);
            Assert.AreEqual("/ReferenciaObjetoDatosItem[0]", nodoobj2.Objeto.Propietario);
            
        }

        [TestMethod]
        public void CrearDiagramaAgregacion()
        {
            IObjetoDatos od = Helper.ConstruirObjetoDatosComplejo(1);
            ITipo tipoagr = od.Tipo.ObtenerPropiedad("ReferenciaObjetoDatos2").Tipo;

            IObjetoDatos odagr = Fabrica.Instancia.Crear(tipoagr);
            IObjetoDatos odagr2 = Fabrica.Instancia.Crear(tipoagr);

            odagr.CrearObjetoDatos("ReferenciaObjetoDatos");
            odagr.EstablecerObjetoDatos("ReferenciaObjetoDatos2", odagr2);
            odagr2.EstablecerObjetoDatos("ReferenciaObjetoDatos2", odagr); // establecer referencia agregacion apuntando al contenedor (odgr)

            od.EstablecerObjetoDatos("ReferenciaObjetoDatos2", odagr);

            BuilderDiagrama helper = new BuilderDiagrama();
            Diagrama diag = helper.Crear(od);

            NodoReferencia nodoprop1 = (NodoReferencia)diag.Root.Nodos[0];
            NodoReferencia nodoprop2 = (NodoReferencia)diag.Root.Nodos[1];
            NodoObjeto nodoobj1 = (NodoObjeto)nodoprop1.Nodos[0];
            NodoObjeto nodoobj2 = (NodoObjeto)nodoprop2.Nodos[0];

            IPropiedad prop1 = od.Tipo.ObtenerPropiedad("ReferenciaObjetoDatos");
            IPropiedad prop2 = od.Tipo.ObtenerPropiedad("ReferenciaObjetoDatos2");
            IObjetoDatos obj1 = od.ObtenerObjetoDatos(prop1);
            IObjetoDatos obj2 = od.ObtenerObjetoDatos(prop2);

            Assert.IsNotNull(nodoprop1);
            Assert.IsNotNull(nodoprop2);
            Assert.IsNotNull(prop1);
            Assert.IsNotNull(prop2);
            Assert.IsNotNull(obj1);
            Assert.IsNotNull(obj2);
            
            Assert.AreEqual(prop1, nodoprop1.Propiedad);
            Assert.AreEqual(prop2, nodoprop2.Propiedad);
            Assert.AreEqual(obj1, nodoobj1.Objeto.ObjetoDatos);
            Assert.AreEqual(obj2, nodoobj2.Objeto.ObjetoDatos);

            Assert.AreEqual("/ReferenciaObjetoDatos", nodoobj1.Objeto.Propietario);
            Assert.AreEqual("/ReferenciaObjetoDatos2", nodoobj2.Objeto.Propietario);


            nodoprop1 = (NodoReferencia)nodoobj2.Nodos[0];
            nodoprop2 = (NodoReferencia)nodoobj2.Nodos[1];
            nodoobj1 = (NodoObjeto)nodoprop1.Nodos[0];
            nodoobj2 = (NodoObjeto)nodoprop2.Nodos[0];

            prop1 = odagr.Tipo.ObtenerPropiedad("ReferenciaObjetoDatos");
            prop2 = odagr.Tipo.ObtenerPropiedad("ReferenciaObjetoDatos2");
            obj1 = odagr.ObtenerObjetoDatos(prop1);
            obj2 = odagr.ObtenerObjetoDatos(prop2);

            Assert.IsNotNull(nodoprop1);
            Assert.IsNotNull(nodoprop2);
            Assert.IsNotNull(prop1);
            Assert.IsNotNull(prop2);
            Assert.IsNotNull(obj1);
            Assert.IsNotNull(obj2);
            
            Assert.AreEqual(prop1, nodoprop1.Propiedad);
            Assert.AreEqual(prop2, nodoprop2.Propiedad);
            Assert.AreEqual(obj1, nodoobj1.Objeto.ObjetoDatos);
            Assert.AreEqual(odagr2, nodoobj2.Objeto.ObjetoDatos);

            Assert.AreEqual("/ReferenciaObjetoDatos2/ReferenciaObjetoDatos", nodoobj1.Objeto.Propietario);
            Assert.AreEqual("/ReferenciaObjetoDatos2/ReferenciaObjetoDatos2", nodoobj2.Objeto.Propietario);

            // verificar la referencia odgr2.ReferenciaObjetoDatos2 => odagr
            nodoprop1 = (NodoReferencia)nodoobj2.Nodos[1];
            nodoobj1 = (NodoObjeto)nodoprop1.Nodos[0];
            obj1 = odagr2.ObtenerObjetoDatos("ReferenciaObjetoDatos2");

            Assert.AreEqual(odagr, obj1);

            Assert.AreEqual("/ReferenciaObjetoDatos2", nodoobj1.Objeto.Propietario);
        }
    }
}
