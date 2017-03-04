using System;
using System.Collections;
using System.Collections.Generic;

namespace Binapsis.Plataforma.Estructura.Colecciones
{
    public class Coleccion : IColeccion
    {
        public Coleccion()
        {

        }

        public Coleccion(int longitud)
        {

        }

        public IObjetoDatos this[int indice]
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        IObjetoDatos IColeccion.this[int indice]
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int Longitud
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IObjetoDatos Agregar(IObjetoDatos item)
        {
            throw new NotImplementedException();
        }

        public bool Contiene(IObjetoDatos item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<IObjetoDatos> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int Indice(IObjetoDatos item)
        {
            throw new NotImplementedException();
        }

        public IObjetoDatos Insertar(IObjetoDatos item, int indice)
        {
            throw new NotImplementedException();
        }

        public void Remover(int indice)
        {
            throw new NotImplementedException();
        }

        public void Remover(IObjetoDatos item)
        {
            throw new NotImplementedException();
        }

        public void RemoverTodo()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
