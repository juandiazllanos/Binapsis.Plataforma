using Binapsis.Plataforma.Estructura;
using Binapsis.Plataforma.Estructura.Implementaciones;
using Binapsis.Plataforma.Historial.Impl;

namespace Binapsis.Plataforma.Historial
{
    public class FabricaHistorial : FabricaImplementacion
    {
        public override IImplementacion Crear(ITipo tipo) =>  Crear(base.Crear(tipo));
        
        public override IImplementacion Crear(IImplementacion impl) =>  new HistorialImpl(impl);

        public override IImplementacion Crear(ITipo tipo, params object[] arg)
        {
            if (arg.Length == 1 && (arg[0] is Log))
                return Crear(tipo, (Log)arg[0]);
            else
                return null;            
        }

        public override IImplementacion Crear(IImplementacion impl, params object[] arg)
        {
            if (arg.Length == 1 && (arg[0] is Log))
                return Crear(impl, (Log)arg[0]);
            else
                return null;
        }

        public IImplementacion Crear(ITipo tipo, Log controlador) => Crear(base.Crear(tipo), controlador);

        public IImplementacion Crear(IImplementacion impl, Log controlador) => new HistorialImpl(impl, controlador);
    }
}
