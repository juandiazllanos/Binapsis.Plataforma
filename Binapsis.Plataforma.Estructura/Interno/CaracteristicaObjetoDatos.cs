namespace Binapsis.Plataforma.Estructura.Interno
{
	internal class CaracteristicaObjetoDatos : Caracteristica
    {
        ObjetoDatos _valor;

		public CaracteristicaObjetoDatos(IPropiedad propiedad)
            : base(propiedad)
        {

		}

        public override void Establecer(object valor)
        {
            EstablecerObjetoDatos((ObjetoDatos)valor);
        }

        public override void EstablecerObjetoDatos(ObjetoDatos valor)
        {
            _valor = valor;
		}

        public override object Obtener()
        {
            return ObtenerObjetoDatos();
        }

        public override ObjetoDatos ObtenerObjetoDatos()
        {
			return _valor;
		}

        public override bool Establecido()
        {
            return (_valor != null);
        }
    }
}