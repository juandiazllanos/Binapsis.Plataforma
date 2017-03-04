using Binapsis.Plataforma.Estructura;

namespace Binapsis.Plataforma.Configuracion.Modelo
{
    public class Propiedad : IPropiedad
    {
        IObjetoDatos _od;
        ITipo _tipo;
        ITipo _propietario;

        public Propiedad(ITipo propietario, IObjetoDatos od)
        {
            _propietario = propietario;
        }

        public string Alias
        {
            get
            {
                return _od.ObtenerString("alias");
            }
            set
            {
                _od.EstablecerString("alias", value);
            }
        }

        public Asociacion Asociacion
        {
            get
            {
                return (Asociacion)_od.ObtenerByte("asociacion");
            }
            set
            {
                _od.EstablecerByte("asociacion", (byte)value);
            }
        }

        public Cardinalidad Cardinalidad
        {
            get
            {
                return (Cardinalidad)_od.ObtenerByte("cardinalidad");
            }
            set
            {
                _od.EstablecerByte("cardinalidad", (byte)value);
            }
        }

        public int Indice
        {
            get
            {
                return _od.ObtenerInteger("indice");
            }
            set
            {
                _od.EstablecerInteger("indice", value);
            }
        }

        public string Nombre
        {
            get
            {
                return _od.ObtenerString("nombre");
            }
            set
            {
                _od.EstablecerString("nombre", value);
            }
        }

        public ITipo Tipo
        {
            get
            {
                return _tipo;
            }
        }

        public object ValorInicial
        {
            get
            {
                return _od.ObtenerString("valorInicial"); 
            }
            set
            {
                _od.EstablecerString("valorInicial", value.ToString());
            }
        }
    }
}
