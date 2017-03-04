using System.Collections;
using System.Collections.Generic;
using Binapsis.Plataforma.Estructura.Colecciones;

namespace Binapsis.Plataforma.Estructura.Interno
{
    internal class CaracteristicaColeccion : Caracteristica, IColeccion 
    {
        List<IObjetoDatos> _items;

		public CaracteristicaColeccion(IPropiedad propiedad)
            : this(propiedad, 0)
        {
            
		}

        public CaracteristicaColeccion(IPropiedad propiedad, int longitud)
            : base(propiedad)
        {
            _items = new List<IObjetoDatos>(longitud);
        }

        public override bool Establecido()
        {
            return (_items.Count > 0);
        }

        public override void AgregarObjetoDatos(IObjetoDatos item)
        {
            //_items.Add(item);
            AgregarObjetoDatos(item, _items.Count);
        }

        public override void EstablecerObjetoDatos(int indice, IObjetoDatos item)
        {
            _items[indice] = item;
        }

        public override IObjetoDatos ObtenerObjetoDatos(int indice)
        {
            return _items[indice];
        }

        public override void RemoverObjetoDatos(IObjetoDatos item)
        {
            _items.Remove(item);
        }
        
        private void AgregarObjetoDatos(IObjetoDatos item, int indice)
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
        IObjetoDatos IColeccion.this[int indice]
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
        
        bool IColeccion.Contiene(IObjetoDatos item)
        {
            return _items.Contains(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        IEnumerator<IObjetoDatos> IEnumerable<IObjetoDatos>.GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        int IColeccion.Indice(IObjetoDatos item)
        {
            return _items.IndexOf(item);
        }        
        #endregion

    }
}