using System;
using System.IO;
using Binapsis.Plataforma.Estructura;

namespace Binapsis.Plataforma.Serializacion
{
	public interface IEscritor
    {

		/// <summary>
		/// Inicializa el escritor en un formato especificado por la implementación.
		/// </summary>
		void Abrir(Stream stream);

		/// <summary>
		/// Libera el buffer de escritura y los recursos consumidos por la implementación.
		/// </summary>
		void Cerrar();

		/// <summary>
		/// Escribe el valor de la propiedad del tipo Boolean en la secuencia subyacente.
		/// </summary>
		void EscribirAtributoBoolean(IPropiedad propiedad, bool valor);

		/// <summary>
		/// Escribe el valor de la propiedad del tipo Byte en la secuencia subyacente.
		/// </summary>
		void EscribirAtributoByte(IPropiedad propiedad, byte valor);

		/// <summary>
		/// Escribe el valor de la propiedad del tipo Char en la secuencia subyacente.
		/// </summary>
		void EscribirAtributoChar(IPropiedad propiedad, char valor);

		/// <summary>
		/// Escribe el valor de la propiedad del tipo DateTime en la secuencia subyacente.
		/// </summary>
		void EscribirAtributoDateTime(IPropiedad propiedad, DateTime valor);

		/// <summary>
		/// Escribe el valor de la propiedad del tipo Decimal en la secuencia subyacente.
		/// </summary>
		void EscribirAtributoDecimal(IPropiedad propiedad, decimal valor);

		/// <summary>
		/// Escribe el valor de la propiedad del tipo Double en la secuencia subyacente.
		/// </summary>
		void EscribirAtributoDouble(IPropiedad propiedad, double valor);

		/// <summary>
		/// Escribe el valor de la propiedad del tipo Float en la secuencia subyacente.
		/// </summary>
		void EscribirAtributoFloat(IPropiedad propiedad, float valor);

		/// <summary>
		/// Escribe el valor de la propiedad del tipo Integer en la secuencia subyacente.
		/// </summary>
		void EscribirAtributoInteger(IPropiedad propiedad, int valor);

		/// <summary>
		/// Escribe el valor de la propiedad del tipo Long en la secuencia subyacente.
		/// </summary>
		void EscribirAtributoLong(IPropiedad propiedad, long valor);

		/// <summary>
		/// Escribe el valor de la propiedad del tipo Object en la secuencia subyacente.
		/// </summary>
		void EscribirAtributoObject(IPropiedad propiedad, object valor);

		/// <summary>
		/// Escribe el valor de la propiedad del tipo SByte en la secuencia subyacente.
		/// </summary>
		void EscribirAtributoSByte(IPropiedad propiedad, sbyte valor);

		/// <summary>
		/// Escribe el valor de la propiedad del tipo Short en la secuencia subyacente.
		/// </summary>
		void EscribirAtributoShort(IPropiedad propiedad, short valor);

		/// <summary>
		/// Escribe el valor de la propiedad del tipo String en la secuencia subyacente.
		/// </summary>
		void EscribirAtributoString(IPropiedad propiedad, string valor);

		/// <summary>
		/// Escribe el valor de la propiedad del tipo UInteger en la secuencia subyacente.
		/// </summary>
		void EscribirAtributoUInteger(IPropiedad propiedad, uint valor);

		/// <summary>
		/// Escribe el valor de la propiedad del tipo UShort en la secuencia subyacente.
		/// </summary>
		void EscribirAtributoUShort(IPropiedad propiedad, ushort valor);

		/// <summary>
		/// Escribe el valor de la propiedad del tipo ULong en la secuencia subyacente.
		/// </summary>
		void EscribirAtributoULong(IPropiedad propiedad, ulong valor);
        
        /// <summary>
        /// Escribe el método.
        /// </summary>
        void EscribirMetodo(byte metodo);

        /// <summary>
        /// Escribe el valor del atributo id del método.
        /// </summary>
        void EscribirMetodoIdentidad(int refid);

        /// <summary>
        /// Escribe el valor del atributo longitud del método.
        /// </summary>
        void EscribirMetodoLongitud(int longitud);

        /// <summary>
        /// Escribe el valor del atributo propietario del método.
        /// </summary>
        void EscribirMetodoPropietario(int propietario);

        /// <summary>
        /// Escribe el valor del atributo propiedad del método.
        /// </summary>
        void EscribirMetodoPropiedad(int propiedad);

        /// <summary>
        /// Escribe el valor del atributo uri del método.
        /// </summary>
        void EscribirMetodoUri(string uri);

        /// <summary>
        /// Escribe el valor del atributo tipo del método.
        /// </summary>
        void EscribirMetodoTipo(string nombre);

        /// <summary>
        /// Escribe el cierre de un metodo
        /// </summary>
        void EscribirMetodoCierre();
        
	}

}