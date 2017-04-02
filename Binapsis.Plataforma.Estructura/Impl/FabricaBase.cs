namespace Binapsis.Plataforma.Estructura.Impl
{
    public abstract class FabricaBase : IFabrica
    {
        private IFabrica _fabrica;

        public FabricaBase()
        {
            _fabrica = new Fabrica();
        }

        public FabricaBase(IFabrica fabrica)
        {
            _fabrica = fabrica;
        }

        public IObjetoDatos Crear(ITipo tipo)
        {
            return Crear(_fabrica.Crear(tipo));
        }

        public IObjetoDatos Crear(ITipo tipo, IObjetoDatos propietario)
        {
            return Crear(_fabrica.Crear(tipo, propietario));
        }

        public IObjetoDatos Crear(IImplementacion impl)
        {
            return Crear(_fabrica.Crear(impl));            
        }

        public abstract IObjetoDatos Crear(IObjetoDatos od);
        
        
        protected IFabrica Fabrica
        {
            get
            {
                return _fabrica;
            }
        }
    }
}