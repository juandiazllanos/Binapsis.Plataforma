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

        public ObjetoDatos this[int indice]
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

        ObjetoDatos IColeccion.this[int indice]
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

        public ObjetoDatos Agregar(ObjetoDatos item)
        {
            throw new NotImplementedException();
        }

        public bool Contiene(ObjetoDatos item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<ObjetoDatos> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int Indice(ObjetoDatos item)
        {
            throw new NotImplementedException();
        }

        public ObjetoDatos Insertar(ObjetoDatos item, int indice)
        {
            throw new NotImplementedException();
        }

        public void Remover(int indice)
        {
            throw new NotImplementedException();
        }

        public void Remover(ObjetoDatos item)
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
