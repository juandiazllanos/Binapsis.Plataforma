using Binapsis.Plataforma.Serializacion.Lectura;
using Binapsis.Plataforma.Estructura;
using System.IO;

namespace Binapsis.Plataforma.Serializacion
{
	public class Deserializador
    {
		ISecuencia _secuencia;
		ILector _lector;
		IMetodoLectura _metodo;
        
		public Deserializador(ISecuencia secuencia, ILector lector)
        {
            _secuencia = secuencia;
            _lector = lector;
		}

		/// <summary>
		/// Deserializa la secuencia establecida en el Objeto de datos enviado como parametro. Usando el lector indicado el objeto de datos es representado desde la secuencia establecida.
		/// </summary>		
		public void Deserializar(ObjetoDatos od)
        {
            try
            {
                // inicializar secuencia
                Stream stream = _secuencia.Crear();
                // inicializar lector
                _lector.Abrir(stream);
                // inicilizar método de lectura
                _metodo = new ModeloLectura(_lector, od);
                // invocar método
                _metodo.Leer();
            }
            finally
            {
                _lector.Cerrar();
            }
		}

	}

}