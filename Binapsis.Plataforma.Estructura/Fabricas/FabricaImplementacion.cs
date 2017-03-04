using Binapsis.Plataforma.Estructura.Implementaciones;

namespace Binapsis.Plataforma.Estructura
{
    public abstract class FabricaImplementacion
    {
        public virtual IImplementacion Crear(ITipo tipo)
        {
            return new Implementacion(tipo);
        }

        public abstract IImplementacion Crear(IImplementacion impl);

        public virtual IImplementacion Crear(ITipo tipo, params object[] arg)
        {
            return null;
        }

        public virtual IImplementacion Crear(IImplementacion impl, params object[] arg)
        {
            return null;
        }
    }
}
