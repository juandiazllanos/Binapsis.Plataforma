using Binapsis.Plataforma.Estructura;
using System.Collections.Generic;
using System.Linq;

namespace Binapsis.Plataforma.Configuracion.Modelo
{
    public class Tipo : ITipo
    {
        IObjetoDatos _od;
        List<IPropiedad> _propiedades;
        ITipo _base;

        public Tipo(IObjetoDatos od)
        {
            _od = od;
        }

        public IPropiedad this[string nombre]
        {
            get
            {
                return ObtenerPropiedad(nombre);
            }
        }

        public IPropiedad this[int indice]
        {
            get
            {
                return ObtenerPropiedad(indice);
            }
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

        public ITipo Base
        {
            get
            {
                return _base;
            }
        }

        public bool EsTipoDeDato
        {
            get
            {
                return _od.ObtenerBoolean("esTipoDeDato");
            }
            set
            {
                _od.EstablecerBoolean("esTipoDeDatos", value);
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

        public IReadOnlyList<IPropiedad> Propiedades
        {
            get
            {
                return _propiedades;
            }
        }

        public string Uri
        {
            get
            {
                return _od.ObtenerString("uri");
            }
            set
            {
                _od.EstablecerString("uri", value);
            }
        }

        public IPropiedad ObtenerPropiedad(int indice)
        {
            return _propiedades[indice];
        }

        public IPropiedad ObtenerPropiedad(string nombre)
        {
            return _propiedades.Where((propiedad) => propiedad.Nombre == nombre).FirstOrDefault();
        }
    }
}
