using Binapsis.Plataforma.Estructura;
using Binapsis.Plataforma.Serializacion.Escritura;
using System.IO;

namespace Binapsis.Plataforma.Serializacion
{
	public class Serializador
    {
		private ISecuencia _secuencia;
		private IEscritor _escritor;
		private IMetodoEscritura _metodo;
        
		public Serializador(ISecuencia secuencia, IEscritor escritor)
        {
            _secuencia = secuencia;
            _escritor = escritor;
		}

		/// <summary>
		/// Serializa el Objeto de datos enviado como parametro. Usando el escritor indicado el objeto de datos es representado en la secuencia establecida.
		/// </summary>		
		public void Serializar(IObjetoDatos od)
        {
            try
            {
                Stream stream = _secuencia.Crear();
                // inicializar la secuencia
                stream.SetLength(0);
                // inicializar escritor con la secuencia especificada
                _escritor.Abrir(stream);
                // inicializar el método de escritura
                _metodo = new ModeloEscritura(_escritor, od);
                // invocar método
                _metodo.Escribir();
            }
            finally
            {
                // liberar recursos del escritor
                _escritor.Cerrar();
            }
		}

	}

}