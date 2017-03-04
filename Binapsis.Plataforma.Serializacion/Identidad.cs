using Binapsis.Plataforma.Estructura;
using System.Collections.Generic;

namespace Binapsis.Plataforma.Serializacion
{
	internal class Identidad
    {
		private List<ObjetoDatos> _identidades;

		public Identidad()
        {
            _identidades = new List<ObjetoDatos>();
		}
        
        /// <summary>
        /// Agrega un objeto de datos y se le asigna un identificador
        /// </summary>
		public void Agregar(ObjetoDatos od, int refid)
        {
            if (!_identidades.Contains(od))
                _identidades.Insert(refid, od);
		}

		/// <summary>
        /// Obtiene el identificador a partir del objeto de datos.
        /// </summary>
		public int Obtener(ObjetoDatos od)
        {
            if (!_identidades.Contains(od))
                _identidades.Add(od);

			return _identidades.IndexOf(od);
		}

		/// <summary>
        /// Obtiene un objeto de datos a partir del identificador
        /// </summary>
		public ObjetoDatos Obtener(int refid)
        {
            return _identidades[refid];
		}

        public ObjetoDatos this[int refid] { get { return Obtener(refid); } }        

	}

}