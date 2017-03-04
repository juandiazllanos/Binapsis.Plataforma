using System;
using Binapsis.Plataforma.Estructura.Colecciones;
using helper = Binapsis.Plataforma.Estructura.Helpers.PathHelper;

namespace Binapsis.Plataforma.Estructura
{
    public class ObjetoDatos : IObjetoDatos
    {        
        private IImplementacion _impl;
        
        internal ObjetoDatos(IImplementacion impl)
        {
            _impl = impl;
		}
        
        public ObjetoDatos CrearObjetoDatos(IPropiedad propiedad)
        {
            ObjetoDatos od = FabricaObjetoDatos.Crear(_impl.Crear(propiedad.Tipo, this));  //_impl.CrearObjetoDatos(propiedad, this);

            if (propiedad.Cardinalidad >= Cardinalidad.Muchos)
                _impl.AgregarObjetoDatos(propiedad, od);
            else
                _impl.EstablecerObjetoDatos(propiedad, od);

            return od;
        }

        public ObjetoDatos CrearObjetoDatos(int indice)
        {
            return CrearObjetoDatos(Tipo.ObtenerPropiedad(indice));
        }

        public ObjetoDatos CrearObjetoDatos(string ruta)
        {
            if (helper.ComprobarRuta(ref ruta))
                return helper.CrearObjetoDatos(this, ruta);
            else
                return CrearObjetoDatos(Tipo[ruta]);
        }
        
        public void Eliminar()
        {
            _impl.Eliminar();
        }

        public bool Establecido(IPropiedad propiedad)
        {
            return _impl.Establecido(propiedad);
        }

        public bool Establecido(int indice)
        {
            return Establecido(Tipo[indice]);
        }

        public bool Establecido(string ruta)
        {
            if (helper.ComprobarRuta(ref ruta))
                return helper.Establecido(this, ruta);
            else
                return Establecido(Tipo[ruta]); 
        }

        public void Establecer(IPropiedad propiedad, object valor)
        {
            _impl.Establecer(propiedad, valor);
        }

        public void Establecer(int indice, object valor)
        {
            _impl.Establecer(Tipo.ObtenerPropiedad(indice), valor);
        }

        public void Establecer(string ruta, object valor)
        {
            if (helper.ComprobarRuta(ref ruta))
                helper.Establecer(this, ruta, valor);
            else
                _impl.Establecer(Tipo.ObtenerPropiedad(ruta), valor);
		}

        public void EstablecerBoolean(IPropiedad propiedad, bool valor)
        {
            _impl.EstablecerBoolean(propiedad, valor);
        }

        public void EstablecerBoolean(int indice, bool valor)
        {
            _impl.EstablecerBoolean(Tipo.ObtenerPropiedad(indice), valor);
        }

        public void EstablecerBoolean(string ruta, bool valor)
        {
            if (helper.ComprobarRuta(ref ruta))
                helper.EstablecerBoolean(this, ruta, valor);
            else
                _impl.EstablecerBoolean(Tipo.ObtenerPropiedad(ruta), valor);
        }

        public void EstablecerByte(IPropiedad propiedad, byte valor)
        {
            _impl.EstablecerByte(propiedad, valor);
        }

        public void EstablecerByte(int indice, byte valor)
        {
            _impl.EstablecerByte(Tipo.ObtenerPropiedad(indice), valor);
        }

        public void EstablecerByte(string ruta, byte valor)
        {
            if (helper.ComprobarRuta(ref ruta))
                helper.EstablecerByte(this, ruta, valor);
            else
                _impl.EstablecerByte(Tipo.ObtenerPropiedad(ruta), valor);
		}

        public void EstablecerChar(IPropiedad propiedad, char valor)
        {
            _impl.EstablecerChar(propiedad, valor);
        }

        public void EstablecerChar(int indice, char valor)
        {
            _impl.EstablecerChar(Tipo.ObtenerPropiedad(indice), valor);
        }

        public void EstablecerChar(string ruta, char valor)
        {
            if (helper.ComprobarRuta(ref ruta))
                helper.EstablecerChar(this, ruta, valor);
            else
                _impl.EstablecerChar(Tipo.ObtenerPropiedad(ruta), valor);            
        }

        public void EstablecerDateTime(IPropiedad propiedad, DateTime valor)
        {
            _impl.EstablecerDateTime(propiedad, valor);
        }

        public void EstablecerDateTime(int indice, DateTime valor)
        {
            _impl.EstablecerDateTime(Tipo.ObtenerPropiedad(indice), valor);
        }

        public void EstablecerDateTime(string ruta, DateTime valor)
        {
            if (helper.ComprobarRuta(ref ruta))
                helper.EstablecerDateTime(this, ruta, valor);
            else
                _impl.EstablecerDateTime(Tipo.ObtenerPropiedad(ruta), valor);
        }

        public void EstablecerDecimal(IPropiedad propiedad, decimal valor)
        {
            _impl.EstablecerDecimal(propiedad, valor);
        }

        public void EstablecerDecimal(int indice, decimal valor)
        {
            _impl.EstablecerDecimal(Tipo.ObtenerPropiedad(indice), valor);
        }

        public void EstablecerDecimal(string ruta, decimal valor)
        {
            if (helper.ComprobarRuta(ref ruta))
                helper.EstablecerDecimal(this, ruta, valor);
            else
                _impl.EstablecerDecimal(Tipo.ObtenerPropiedad(ruta), valor);
        }

        public void EstablecerDouble(IPropiedad propiedad, double valor)
        {
            _impl.EstablecerDouble(propiedad, valor);
        }

        public void EstablecerDouble(int indice, double valor)
        {
            _impl.EstablecerDouble(Tipo.ObtenerPropiedad(indice), valor);
        }

        public void EstablecerDouble(string ruta, double valor)
        {
            if (helper.ComprobarRuta(ref ruta))
                helper.EstablecerDouble(this, ruta, valor);
            else
                _impl.EstablecerDouble(Tipo.ObtenerPropiedad(ruta), valor);
        }

        public void EstablecerFloat(IPropiedad propiedad, float valor)
        {
            _impl.EstablecerFloat(propiedad, valor);
        }

        public void EstablecerFloat(int indice, float valor)
        {
            _impl.EstablecerFloat(Tipo.ObtenerPropiedad(indice), valor);
        }

        public void EstablecerFloat(string ruta, float valor)
        {
            if (helper.ComprobarRuta(ref ruta))
                helper.EstablecerFloat(this, ruta, valor);
            else
                _impl.EstablecerFloat(Tipo.ObtenerPropiedad(ruta), valor); 
        }

        public void EstablecerInteger(IPropiedad propiedad, int valor)
        {
            _impl.EstablecerInteger(propiedad, valor);
        }

        public void EstablecerInteger(int indice, int valor)
        {
            _impl.EstablecerInteger(Tipo.ObtenerPropiedad(indice), valor);
        }

        public void EstablecerInteger(string ruta, int valor)
        {
            if (helper.ComprobarRuta(ref ruta))
                helper.EstablecerInteger(this, ruta, valor);
            else
                _impl.EstablecerInteger(Tipo.ObtenerPropiedad(ruta), valor); 
        }
        
        public void EstablecerLong(IPropiedad propiedad, long valor)
        {
            _impl.EstablecerLong(propiedad, valor);
        }

        public void EstablecerLong(int indice, long valor)
        {
            _impl.EstablecerLong(Tipo.ObtenerPropiedad(indice), valor);
        }

        public void EstablecerLong(string ruta, long valor)
        {
            if (helper.ComprobarRuta(ref ruta))
                helper.EstablecerLong(this, ruta, valor);
            else
                _impl.EstablecerLong(Tipo.ObtenerPropiedad(ruta), valor); 
        }

        public void EstablecerObject(IPropiedad propiedad, object valor)
        {
            _impl.EstablecerObject(propiedad, valor);
        }

        public void EstablecerObject(int indice, object valor)
        {
            _impl.EstablecerObject(Tipo.ObtenerPropiedad(indice), valor);
        }

        public void EstablecerObject(string ruta, object valor)
        {
            if (helper.ComprobarRuta(ref ruta))
                helper.EstablecerObject(this, ruta, valor);
            else
                _impl.EstablecerObject(Tipo.ObtenerPropiedad(ruta), valor); 
        }

        public void EstablecerObjetoDatos(IPropiedad propiedad, ObjetoDatos valor)
        {
            _impl.EstablecerObjetoDatos(propiedad, valor);
        }

        public void EstablecerObjetoDatos(int indice, ObjetoDatos valor)
        {
            _impl.EstablecerObjetoDatos(Tipo.ObtenerPropiedad(indice), valor);
        }

        public void EstablecerObjetoDatos(string ruta, ObjetoDatos valor)
        {
            if (helper.ComprobarRuta(ref ruta))
                helper.EstablecerObjetoDatos(this, ruta, valor);
            else
                _impl.EstablecerObjetoDatos(Tipo.ObtenerPropiedad(ruta), valor); 
        }

        public void EstablecerSByte(IPropiedad propiedad, sbyte valor)
        {
            _impl.EstablecerSByte(propiedad, valor);
        }

        public void EstablecerSByte(int indice, sbyte valor)
        {
            _impl.EstablecerSByte(Tipo.ObtenerPropiedad(indice), valor);
        }

        public void EstablecerSByte(string ruta, sbyte valor)
        {
            if (helper.ComprobarRuta(ref ruta))
                helper.EstablecerSByte(this, ruta, valor);
            else
                _impl.EstablecerSByte(Tipo.ObtenerPropiedad(ruta), valor); 
        }

        public void EstablecerShort(IPropiedad propiedad, short valor)
        {
            _impl.EstablecerShort(propiedad, valor);
        }

        public void EstablecerShort(int indice, short valor)
        {
            _impl.EstablecerShort(Tipo.ObtenerPropiedad(indice), valor);
        }

        public void EstablecerShort(string ruta, short valor)
        {
            if (helper.ComprobarRuta(ref ruta))
                helper.EstablecerShort(this, ruta, valor);
            else
                _impl.EstablecerShort(Tipo.ObtenerPropiedad(ruta), valor); 
        }

        public void EstablecerString(IPropiedad propiedad, string valor)
        {
            _impl.EstablecerString(propiedad, valor);
        }

        public void EstablecerString(int indice, string valor)
        {
            _impl.EstablecerString(Tipo.ObtenerPropiedad(indice), valor);
        }

        public void EstablecerString(string ruta, string valor)
        {
            if (helper.ComprobarRuta(ref ruta))
                helper.EstablecerString(this, ruta, valor);
            else
                _impl.EstablecerString(Tipo.ObtenerPropiedad(ruta), valor); 
        }

        public void EstablecerUInteger(IPropiedad propiedad, uint valor)
        {
            _impl.EstablecerUInteger(propiedad, valor);
        }

        public void EstablecerUInteger(int indice, uint valor)
        {
            _impl.EstablecerUInteger(Tipo.ObtenerPropiedad(indice), valor);
        }

        public void EstablecerUInteger(string ruta, uint valor)
        {
            if (helper.ComprobarRuta(ref ruta))
                helper.EstablecerUInteger(this, ruta, valor);
            else
                _impl.EstablecerUInteger(Tipo.ObtenerPropiedad(ruta), valor); 
        }

        public void EstablecerULong(IPropiedad propiedad, ulong valor)
        {
            _impl.EstablecerULong(propiedad, valor);
        }

        public void EstablecerULong(int indice, ulong valor)
        {
            _impl.EstablecerULong(Tipo.ObtenerPropiedad(indice), valor);
        }

        public void EstablecerULong(string ruta, ulong valor)
        {
            if (helper.ComprobarRuta(ref ruta))
                helper.EstablecerULong(this, ruta, valor);
            else
                _impl.EstablecerULong(Tipo.ObtenerPropiedad(ruta), valor); 
        }

        public void EstablecerUShort(IPropiedad propiedad, ushort valor)
        {
            _impl.EstablecerUShort(propiedad, valor);
        }

        public void EstablecerUShort(int indice, ushort valor)
        {
            _impl.EstablecerUShort(Tipo.ObtenerPropiedad(indice), valor);
        }

        public void EstablecerUShort(string ruta, ushort valor)
        {
            if (helper.ComprobarRuta(ref ruta))
                helper.EstablecerUShort(this, ruta, valor);
            else
                _impl.EstablecerUShort(Tipo[ruta], valor); 
        }

        public object Obtener(IPropiedad propiedad)
        {
            return _impl.Obtener(propiedad);
        }

        public object Obtener(int indice)
        {
            return _impl.Obtener(Tipo[indice]);
        }

        public object Obtener(string ruta)
        {
            if (helper.ComprobarRuta(ref ruta))
                return helper.Obtener(this, ruta);
            else
                return _impl.Obtener(Tipo[ruta]); 
        }

        public bool ObtenerBoolean(IPropiedad propiedad)
        {
            return _impl.ObtenerBoolean(propiedad);
        }

        public bool ObtenerBoolean(int indice)
        {
            return _impl.ObtenerBoolean(Tipo[indice]); ;
        }

        public bool ObtenerBoolean(string ruta)
        {
            if (helper.ComprobarRuta(ref ruta))
                return helper.ObtenerBoolean(this, ruta);
            else
                return _impl.ObtenerBoolean(Tipo[ruta]); 
        }

        public byte ObtenerByte(IPropiedad propiedad)
        {
            return _impl.ObtenerByte(propiedad); 
        }

        public byte ObtenerByte(int indice)
        {
            return _impl.ObtenerByte(Tipo[indice]); 
        }

        public byte ObtenerByte(string ruta)
        {
            if (helper.ComprobarRuta(ref ruta))
                return helper.ObtenerByte(this, ruta);
            else
                return _impl.ObtenerByte(Tipo[ruta]); 
        }

        public char ObtenerChar(IPropiedad propiedad)
        {
            return _impl.ObtenerChar(propiedad);
        }

        public char ObtenerChar(int indice)
        {
            return _impl.ObtenerChar(Tipo[indice]);
        }

        public char ObtenerChar(string ruta)
        {
            if (helper.ComprobarRuta(ref ruta))
                return helper.ObtenerChar(this, ruta);
            else
                return _impl.ObtenerChar(Tipo[ruta]); 
        }

        public IColeccion ObtenerColeccion(IPropiedad propiedad)
        {
            return _impl.ObtenerColeccion(propiedad);
        }

        public IColeccion ObtenerColeccion(int indice)
        {
            return _impl.ObtenerColeccion(Tipo[indice]);
        }

        public IColeccion ObtenerColeccion(string ruta)
        {
            if (helper.ComprobarRuta(ref ruta))
                return helper.ObtenerColeccion(this, ruta);
            else
                return _impl.ObtenerColeccion(Tipo[ruta]); 
        }

        public DateTime ObtenerDateTime(IPropiedad propiedad)
        {
            return _impl.ObtenerDateTime(propiedad);
        }

        public DateTime ObtenerDateTime(int indice)
        {
            return _impl.ObtenerDateTime(Tipo[indice]);
        }

        public DateTime ObtenerDateTime(string ruta)
        {
            if (helper.ComprobarRuta(ref ruta))
                return helper.ObtenerDateTime(this, ruta);
            else
                return _impl.ObtenerDateTime(Tipo[ruta]); 
        }

        public decimal ObtenerDecimal(IPropiedad propiedad)
        {
            return _impl.ObtenerDecimal(propiedad);
        }

        public decimal ObtenerDecimal(int indice)
        {
            return _impl.ObtenerDecimal(Tipo[indice]);
        }

        public decimal ObtenerDecimal(string ruta)
        {
            if (helper.ComprobarRuta(ref ruta))
                return helper.ObtenerDecimal(this, ruta);
            else
                return _impl.ObtenerDecimal(Tipo[ruta]); 
        }

        public double ObtenerDouble(IPropiedad propiedad)
        {
            return _impl.ObtenerDouble(propiedad);
        }

        public double ObtenerDouble(int indice)
        {
            return _impl.ObtenerDouble(Tipo[indice]);
        }

        public double ObtenerDouble(string ruta)
        {
            if (helper.ComprobarRuta(ref ruta))
                return helper.ObtenerDouble(this, ruta);
            else
                return _impl.ObtenerDouble(Tipo[ruta]); 
        }

        public float ObtenerFloat(IPropiedad propiedad)
        {
            return _impl.ObtenerFloat(propiedad);
        }

        public float ObtenerFloat(int indice)
        {
            return _impl.ObtenerFloat(Tipo[indice]);
        }

        public float ObtenerFloat(string ruta)
        {
            if (helper.ComprobarRuta(ref ruta))
                return helper.ObtenerFloat(this, ruta);
            else
                return _impl.ObtenerFloat(Tipo[ruta]); 
        }

        public int ObtenerInteger(IPropiedad propiedad)
        {
            return _impl.ObtenerInteger(propiedad);
        }

        public int ObtenerInteger(int indice)
        {
            return _impl.ObtenerInteger(Tipo[indice]);
        }

        public int ObtenerInteger(string ruta)
        {
            if (helper.ComprobarRuta(ref ruta))
                return helper.ObtenerInteger(this, ruta);
            else
                return _impl.ObtenerInteger(Tipo[ruta]); 
        }

        public long ObtenerLong(IPropiedad propiedad)
        {
            return _impl.ObtenerLong(propiedad);
        }

        public long ObtenerLong(int indice)
        {
            return _impl.ObtenerLong(Tipo[indice]);
        }

        public long ObtenerLong(string ruta)
        {
            if (helper.ComprobarRuta(ref ruta))
                return helper.ObtenerLong(this, ruta);
            else
                return _impl.ObtenerLong(Tipo[ruta]); 
        }

        public object ObtenerObject(IPropiedad propiedad)
        {
            return _impl.ObtenerObject(propiedad);
        }

        public object ObtenerObject(int indice)
        {
            return _impl.ObtenerObject(Tipo[indice]);
        }

        public object ObtenerObject(string ruta)
        {
            if (helper.ComprobarRuta(ref ruta))
                return helper.ObtenerObject(this, ruta);
            else
                return _impl.ObtenerObject(Tipo[ruta]); 
        }

        public ObjetoDatos ObtenerObjetoDatos(IPropiedad propiedad)
        {
            return _impl.ObtenerObjetoDatos(propiedad);
        }

        public ObjetoDatos ObtenerObjetoDatos(int indice)
        {
            return _impl.ObtenerObjetoDatos(Tipo[indice]);
        }

        public ObjetoDatos ObtenerObjetoDatos(string ruta)
        {
            if (helper.ComprobarRuta(ref ruta))
                return helper.ObtenerObjetoDatos(this, ruta);
            else
                return _impl.ObtenerObjetoDatos(Tipo[ruta]); 
        }

        public sbyte ObtenerSByte(IPropiedad propiedad)
        {
            return _impl.ObtenerSByte(propiedad);
        }

        public sbyte ObtenerSByte(int indice)
        {
            return _impl.ObtenerSByte(Tipo[indice]);
        }

        public sbyte ObtenerSByte(string ruta)
        {
            if (helper.ComprobarRuta(ref ruta))
                return helper.ObtenerSByte(this, ruta);
            else
                return _impl.ObtenerSByte(Tipo[ruta]); 
        }

        public short ObtenerShort(IPropiedad propiedad)
        {
            return _impl.ObtenerShort(propiedad);
        }

        public short ObtenerShort(int indice)
        {
            return _impl.ObtenerShort(Tipo[indice]);
        }

        public short ObtenerShort(string ruta)
        {
            if (helper.ComprobarRuta(ref ruta))
                return helper.ObtenerShort(this, ruta);
            else
                return _impl.ObtenerShort(Tipo[ruta]); 
        }

        public string ObtenerString(IPropiedad propiedad)
        {
            return _impl.ObtenerString(propiedad);
        }

        public string ObtenerString(int indice)
        {
            return _impl.ObtenerString(Tipo[indice]);
        }

        public string ObtenerString(string ruta)
        {
            if (helper.ComprobarRuta(ref ruta))
                return helper.ObtenerString(this, ruta);
            else
                return _impl.ObtenerString(Tipo[ruta]); 
        }

        public uint ObtenerUInteger(IPropiedad propiedad)
        {
            return _impl.ObtenerUInteger(propiedad);
        }

        public uint ObtenerUInteger(int indice)
        {
            return _impl.ObtenerUInteger(Tipo[indice]);
        }

        public uint ObtenerUInteger(string ruta)
        {
            if (helper.ComprobarRuta(ref ruta))
                return helper.ObtenerUInteger(this, ruta);
            else
                return _impl.ObtenerUInteger(Tipo[ruta]); 
        }

        public ulong ObtenerULong(IPropiedad propiedad)
        {
            return _impl.ObtenerULong(propiedad);
        }

        public ulong ObtenerULong(int indice)
        {
            return _impl.ObtenerULong(Tipo[indice]);
        }

        public ulong ObtenerULong(string ruta)
        {
            if (helper.ComprobarRuta(ref ruta))
                return helper.ObtenerULong(this, ruta);
            else
                return _impl.ObtenerULong(Tipo[ruta]); 
        }

        public ushort ObtenerUShort(IPropiedad propiedad)
        {
            return _impl.ObtenerUShort(propiedad);
        }

        public ushort ObtenerUShort(int indice)
        {
            return _impl.ObtenerUShort(Tipo[indice]);
        }

        public ushort ObtenerUShort(string ruta)
        {
            if (helper.ComprobarRuta(ref ruta))
                return helper.ObtenerUShort(this, ruta);
            else
                return _impl.ObtenerUShort(Tipo[ruta]); 
        }

        public void RemoverObjetoDatos(IPropiedad propiedad, ObjetoDatos item)
        {
            _impl.RemoverObjetoDatos(propiedad, item);
        }

        public void RemoverObjetoDatos(int indice, ObjetoDatos item)
        {
            _impl.RemoverObjetoDatos(Tipo[indice], item);
        }

        public void RemoverObjetoDatos(string nombre, ObjetoDatos item)
        {
            _impl.RemoverObjetoDatos(Tipo[nombre], item);
        }

        public ITipo Tipo
        {
            get
            {
                return _impl.Tipo;
            }
        }

        public ObjetoDatos Propietario
        {
            get
            {
                return _impl.Propietario;
            }
        }
    }
}