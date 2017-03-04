using System;
using System.IO;
using Binapsis.Plataforma.Estructura;

namespace Binapsis.Plataforma.Serializacion
{
	public interface ILector
    {
		/// <summary>
		/// Inicializa el lector en un formato especificado por la implementación.
		/// </summary>
		void Abrir(Stream stream);

		/// <summary>
		/// Libera el buffer de lectura y los recursos consumidos por la implementación.
		/// </summary>
		void Cerrar();

		/// <summary>
		/// Lee la propiedad de la secuencia en el formato especificado por la implementación.
		/// </summary>
		IPropiedad Leer(ITipo contexto);

		/// <summary>
		/// Lee el valor de la propiedad del tipo Boolean en la secuencia subyacente.
		/// </summary>		
		bool LeerAtributoBoolean(IPropiedad propiedad);

		/// <summary>
		/// Lee el valor de la propiedad del tipo Byte en la secuencia subyacente.
		/// </summary>		
		byte LeerAtributoByte(IPropiedad propiedad);

		/// <summary>
		/// Lee el valor de la propiedad del tipo Char en la secuencia subyacente.
		/// </summary>		
		char LeerAtributoChar(IPropiedad propiedad);

		/// <summary>
		/// Lee el valor de la propiedad del tipo DateTime en la secuencia subyacente.
		/// </summary>		
		DateTime LeerAtributoDateTime(IPropiedad propiedad);

		/// <summary>
		/// Lee el valor de la propiedad del tipo Decimal en la secuencia subyacente.
		/// </summary>
		decimal LeerAtributoDecimal(IPropiedad propiedad);

		/// <summary>
		/// Lee el valor de la propiedad del tipo Double en la secuencia subyacente.
		/// </summary>
		double LeerAtributoDouble(IPropiedad propiedad);

		/// <summary>
		/// Lee el valor de la propiedad del tipo Float en la secuencia subyacente.
		/// </summary>
		float LeerAtributoFloat(IPropiedad propiedad);

		/// <summary>
		/// Lee el valor de la propiedad del tipo Integer en la secuencia subyacente.
		/// </summary>
		int LeerAtributoInteger(IPropiedad propiedad);

		/// <summary>
		/// Lee el valor de la propiedad del tipo Object en la secuencia subyacente.
		/// </summary>
		object LeerAtributoObject(IPropiedad propiedad);

		/// <summary>
		/// Lee el valor de la propiedad del tipo SByte en la secuencia subyacente.
		/// </summary>
		sbyte LeerAtributoSByte(IPropiedad propiedad);

		/// <summary>
		/// Lee el valor de la propiedad del tipo Short en la secuencia subyacente.
		/// </summary>
		short LeerAtributoShort(IPropiedad propiedad);

		/// <summary>
		/// Lee el valor de la propiedad del tipo String en la secuencia subyacente.
		/// </summary>
		string LeerAtributoString(IPropiedad propiedad);

		/// <summary>
		/// Lee el valor de la propiedad del tipo UInteger en la secuencia subyacente.
		/// </summary>
		uint LeerAtributoUInteger(IPropiedad propiedad);

		/// <summary>
		/// Lee el valor de la propiedad del tipo ULong en la secuencia subyacente.
		/// </summary>
		ulong LeerAtributoULong(IPropiedad propiedad);

		/// <summary>
		/// Lee el valor de la propiedad del tipo UShort en la secuencia subyacente.
		/// </summary>
		ushort LeerAtributoUShort(IPropiedad propiedad);

		/// <summary>
		/// Lee el valor de la propiedad del tipo ULong en la secuencia subyacente.
		/// </summary>
		long LeerAtributoLong(IPropiedad propiedad);

		/// <summary>
		/// Lee el codigo de un método.
		/// </summary>
		byte LeerMetodo();

		/// <summary>
		/// Lee la identidad en un método.
		/// </summary>
		int LeerMetodoIdentidad();

		/// <summary>
		/// Lee la longitud en un método.
		/// </summary>
		int LeerMetodoLongitud();

		/// <summary>
		/// Lee el id del propietario en un método.
		/// </summary>
		int LeerMetodoPropietario();

        /// <summary>
		/// Lee la propiedad en un método.
		/// </summary>
		int LeerMetodoPropiedad();

        /// <summary>
        /// Lee el valor del atributo uri del método.
        /// </summary>
        string LeerMetodoUri();

        /// <summary>
        /// Lee el valor del atributo tipo del método.
        /// </summary>
        string LeerMetodoTipo();
    }

}