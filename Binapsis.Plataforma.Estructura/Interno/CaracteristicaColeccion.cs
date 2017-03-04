using System.Collections;
using System.Collections.Generic;
using Binapsis.Plataforma.Estructura.Colecciones;

namespace Binapsis.Plataforma.Estructura.Interno
{
    internal class CaracteristicaColeccion : Caracteristica, IColeccion 
    {
        List<ObjetoDatos> _items;

		public CaracteristicaColeccion(IPropiedad propiedad)
            : this(propiedad, 0)
        {
            
		}

        public CaracteristicaColeccion(IPropiedad propiedad, int longitud)
            : base(propiedad)
        {
            _items = new List<ObjetoDatos>(longitud);
        }

        public override bool Establecido()
        {
            return (_items.Count > 0);
        }

        public override void AgregarObjetoDatos(ObjetoDatos item)
        {
            //_items.Add(item);
            AgregarObjetoDatos(item, _items.Count);
        }

        public override void EstablecerObjetoDatos(int indice, ObjetoDatos item)
        {
            _items[indice] = item;
        }

        public override ObjetoDatos ObtenerObjetoDatos(int indice)
        {
            return _items[indice];
        }

        public override void RemoverObjetoDatos(ObjetoDatos item)
        {
            _items.Remove(item);
        }
        
        private void AgregarObjetoDatos(ObjetoDatos item, int indice)
        {
            if (indice < _items.Count)
            {
                _items.Insert(indice, item);
            }
            else
            {
                _items.Add(item);
            }
        }

        #region IColeccion
        ObjetoDatos IColeccion.this[int indice]
        {
            get
            {
                return ObtenerObjetoDatos(indice);
            }
        }
        
        int IColeccion.Longitud
        {
            get
            {
                return _items.Count;
            }
        }
        
        bool IColeccion.Contiene(ObjetoDatos item)
        {
            return _items.Contains(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        IEnumerator<ObjetoDatos> IEnumerable<ObjetoDatos>.GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        int IColeccion.Indice(ObjetoDatos item)
        {
            return _items.IndexOf(item);
        }        
        #endregion

    }
}