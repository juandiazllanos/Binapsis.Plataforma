using System;

namespace Binapsis.Plataforma.Estructura.Impl
{
    public abstract partial class ObjetoBase : IObjetoDatos
    {
        private IObjetoDatos _od;

        internal ObjetoBase(IObjetoDatos od)
        {
            _od = od;
        }

        protected internal IObjetoDatos Propietario
        {
            get
            {
                return _od.Propietario;
            }
        }

        protected internal ITipo Tipo
        {
            get
            {
                return _od.Tipo;
            }
        }
        
        protected internal IObjetoDatos CrearObjetoDatos(int indice)
        {
            return _od.CrearObjetoDatos(indice);
        }

        protected internal IObjetoDatos CrearObjetoDatos(IPropiedad propiedad)
        {
            return _od.CrearObjetoDatos(propiedad);
        }

        protected internal IObjetoDatos CrearObjetoDatos(string ruta)
        {
            return _od.CrearObjetoDatos(ruta);
        }

        protected internal void Eliminar()
        {
            _od.Eliminar();
        }

        protected internal void Establecer(int indice, object valor)
        {
            _od.Establecer(indice, valor);
        }

        protected internal void Establecer(IPropiedad propiedad, object valor)
        {
            _od.Establecer(propiedad, valor);
        }

        protected internal void Establecer(string ruta, object valor)
        {
            _od.Establecer(ruta, valor);
        }

        protected internal void EstablecerBoolean(int indice, bool valor)
        {
            _od.EstablecerBoolean(indice, valor);
        }

        protected internal void EstablecerBoolean(IPropiedad propiedad, bool valor)
        {
            _od.EstablecerBoolean(propiedad, valor);
        }

        protected internal void EstablecerBoolean(string ruta, bool valor)
        {
            _od.EstablecerBoolean(ruta, valor);
        }

        protected internal void EstablecerByte(int indice, byte valor)
        {
            _od.EstablecerByte(indice, valor);
        }

        protected internal void EstablecerByte(IPropiedad propiedad, byte valor)
        {
            _od.EstablecerByte(propiedad, valor);
        }

        protected internal void EstablecerByte(string ruta, byte valor)
        {
            _od.EstablecerByte(ruta, valor);
        }

        protected internal void EstablecerChar(int indice, char valor)
        {
            _od.EstablecerChar(indice, valor);
        }

        protected internal void EstablecerChar(IPropiedad propiedad, char valor)
        {
            _od.EstablecerChar(propiedad, valor);
        }

        protected internal void EstablecerChar(string ruta, char valor)
        {
            _od.EstablecerChar(ruta, valor);
        }

        protected internal void EstablecerDateTime(int indice, DateTime valor)
        {
            _od.EstablecerDateTime(indice, valor);
        }

        protected internal void EstablecerDateTime(IPropiedad propiedad, DateTime valor)
        {
            _od.EstablecerDateTime(propiedad, valor);
        }

        protected internal void EstablecerDateTime(string ruta, DateTime valor)
        {
            _od.EstablecerDateTime(ruta, valor);
        }

        protected internal void EstablecerDecimal(int indice, decimal valor)
        {
            _od.EstablecerDecimal(indice, valor);
        }

        protected internal void EstablecerDecimal(IPropiedad propiedad, decimal valor)
        {
            _od.EstablecerDecimal(propiedad, valor);
        }

        protected internal void EstablecerDecimal(string ruta, decimal valor)
        {
            _od.EstablecerDecimal(ruta, valor);
        }

        protected internal void EstablecerDouble(int indice, double valor)
        {
            _od.EstablecerDouble(indice, valor);
        }

        protected internal void EstablecerDouble(IPropiedad propiedad, double valor)
        {
            _od.EstablecerDouble(propiedad, valor);
        }

        protected internal void EstablecerDouble(string ruta, double valor)
        {
            _od.EstablecerDouble(ruta, valor);
        }

        protected internal void EstablecerFloat(int indice, float valor)
        {
            _od.EstablecerFloat(indice, valor);
        }

        protected internal void EstablecerFloat(IPropiedad propiedad, float valor)
        {
            _od.EstablecerFloat(propiedad, valor);
        }

        protected internal void EstablecerFloat(string ruta, float valor)
        {
            _od.EstablecerFloat(ruta, valor);
        }

        protected internal void EstablecerInteger(int indice, int valor)
        {
            _od.EstablecerInteger(indice, valor);
        }

        protected internal void EstablecerInteger(IPropiedad propiedad, int valor)
        {
            _od.EstablecerInteger(propiedad, valor);
        }

        protected internal void EstablecerInteger(string ruta, int valor)
        {
            _od.EstablecerInteger(ruta, valor);
        }

        protected internal void EstablecerLong(int indice, long valor)
        {
            _od.EstablecerLong(indice, valor);
        }

        protected internal void EstablecerLong(IPropiedad propiedad, long valor)
        {
            _od.EstablecerLong(propiedad, valor);
        }

        protected internal void EstablecerLong(string ruta, long valor)
        {
            _od.EstablecerLong(ruta, valor);
        }

        protected internal void EstablecerObject(int indice, object valor)
        {
            _od.EstablecerObject(indice, valor);
        }

        protected internal void EstablecerObject(IPropiedad propiedad, object valor)
        {
            _od.EstablecerObject(propiedad, valor);
        }

        protected internal void EstablecerObject(string ruta, object valor)
        {
            _od.EstablecerObject(ruta, valor);
        }

        protected internal void EstablecerObjetoDatos(int indice, IObjetoDatos valor)
        {
            _od.EstablecerObjetoDatos(indice, valor);
        }

        protected internal void EstablecerObjetoDatos(IPropiedad propiedad, IObjetoDatos valor)
        {
            _od.EstablecerObjetoDatos(propiedad, valor);
        }

        protected internal void EstablecerObjetoDatos(string ruta, IObjetoDatos valor)
        {
            _od.EstablecerObjetoDatos(ruta, valor);
        }

        protected internal void EstablecerSByte(int indice, sbyte valor)
        {
            _od.EstablecerSByte(indice, valor);
        }

        protected internal void EstablecerSByte(IPropiedad propiedad, sbyte valor)
        {
            _od.EstablecerSByte(propiedad, valor);
        }

        protected internal void EstablecerSByte(string ruta, sbyte valor)
        {
            _od.EstablecerSByte(ruta, valor);
        }

        protected internal void EstablecerShort(int indice, short valor)
        {
            _od.EstablecerShort(indice, valor);
        }

        protected internal void EstablecerShort(IPropiedad propiedad, short valor)
        {
            _od.EstablecerShort(propiedad, valor);
        }

        protected internal void EstablecerShort(string ruta, short valor)
        {
            _od.EstablecerShort(ruta, valor);
        }

        protected internal void EstablecerString(int indice, string valor)
        {
            _od.EstablecerString(indice, valor);
        }

        protected internal void EstablecerString(IPropiedad propiedad, string valor)
        {
            _od.EstablecerString(propiedad, valor);
        }

        protected internal void EstablecerString(string ruta, string valor)
        {
            _od.EstablecerString(ruta, valor);
        }

        protected internal void EstablecerUInteger(int indice, uint valor)
        {
            _od.EstablecerUInteger(indice, valor);
        }

        protected internal void EstablecerUInteger(IPropiedad propiedad, uint valor)
        {
            _od.EstablecerUInteger(propiedad, valor);
        }

        protected internal void EstablecerUInteger(string ruta, uint valor)
        {
            _od.EstablecerUInteger(ruta, valor);
        }

        protected internal void EstablecerULong(int indice, ulong valor)
        {
            _od.EstablecerULong(indice, valor);
        }

        protected internal void EstablecerULong(IPropiedad propiedad, ulong valor)
        {
            _od.EstablecerULong(propiedad, valor);
        }

        protected internal void EstablecerULong(string ruta, ulong valor)
        {
            _od.EstablecerULong(ruta, valor);
        }

        protected internal void EstablecerUShort(int indice, ushort valor)
        {
            _od.EstablecerUShort(indice, valor);
        }

        protected internal void EstablecerUShort(IPropiedad propiedad, ushort valor)
        {
            _od.EstablecerUShort(propiedad, valor);
        }

        protected internal void EstablecerUShort(string ruta, ushort valor)
        {
            _od.EstablecerUShort(ruta, valor);
        }

        protected internal bool Establecido(int indice)
        {
            return _od.Establecido(indice);
        }

        protected internal bool Establecido(IPropiedad propiedad)
        {
            return _od.Establecido(propiedad);
        }

        protected internal bool Establecido(string ruta)
        {
            return _od.Establecido(ruta);
        }

        protected internal object Obtener(int indice)
        {
            return _od.Obtener(indice);
        }

        protected internal object Obtener(IPropiedad propiedad)
        {
            return _od.Obtener(propiedad);
        }

        protected internal object Obtener(string ruta)
        {
            return _od.Obtener(ruta);
        }

        protected internal bool ObtenerBoolean(int indice)
        {
            return _od.ObtenerBoolean(indice);
        }

        protected internal bool ObtenerBoolean(IPropiedad propiedad)
        {
            return _od.ObtenerBoolean(propiedad);
        }

        protected internal bool ObtenerBoolean(string ruta)
        {
            return _od.ObtenerBoolean(ruta);
        }

        protected internal byte ObtenerByte(int indice)
        {
            return _od.ObtenerByte(indice);
        }

        protected internal byte ObtenerByte(IPropiedad propiedad)
        {
            return _od.ObtenerByte(propiedad);
        }

        protected internal byte ObtenerByte(string ruta)
        {
            return _od.ObtenerByte(ruta);
        }

        protected internal char ObtenerChar(int indice)
        {
            return _od.ObtenerChar(indice);
        }

        protected internal char ObtenerChar(IPropiedad propiedad)
        {
            return _od.ObtenerChar(propiedad);
        }

        protected internal char ObtenerChar(string ruta)
        {
            return _od.ObtenerChar(ruta);
        }

        protected internal IColeccion ObtenerColeccion(int indice)
        {
            return _od.ObtenerColeccion(indice);
        }

        protected internal IColeccion ObtenerColeccion(IPropiedad propiedad)
        {
            return _od.ObtenerColeccion(propiedad);
        }

        protected internal IColeccion ObtenerColeccion(string ruta)
        {
            return _od.ObtenerColeccion(ruta);
        }

        protected internal DateTime ObtenerDateTime(int indice)
        {
            return _od.ObtenerDateTime(indice);
        }

        protected internal DateTime ObtenerDateTime(IPropiedad propiedad)
        {
            return _od.ObtenerDateTime(propiedad);
        }

        protected internal DateTime ObtenerDateTime(string ruta)
        {
            return _od.ObtenerDateTime(ruta);
        }

        protected internal decimal ObtenerDecimal(int indice)
        {
            return _od.ObtenerDecimal(indice);
        }

        protected internal decimal ObtenerDecimal(IPropiedad propiedad)
        {
            return _od.ObtenerDecimal(propiedad);
        }

        protected internal decimal ObtenerDecimal(string ruta)
        {
            return _od.ObtenerDecimal(ruta);
        }

        protected internal double ObtenerDouble(int indice)
        {
            return _od.ObtenerDouble(indice);
        }

        protected internal double ObtenerDouble(IPropiedad propiedad)
        {
            return _od.ObtenerDouble(propiedad);
        }

        protected internal double ObtenerDouble(string ruta)
        {
            return _od.ObtenerDouble(ruta);
        }

        protected internal float ObtenerFloat(int indice)
        {
            return _od.ObtenerFloat(indice);
        }

        protected internal float ObtenerFloat(IPropiedad propiedad)
        {
            return _od.ObtenerFloat(propiedad);
        }

        protected internal float ObtenerFloat(string ruta)
        {
            return _od.ObtenerFloat(ruta);
        }

        protected internal int ObtenerInteger(int indice)
        {
            return _od.ObtenerInteger(indice);
        }

        protected internal int ObtenerInteger(IPropiedad propiedad)
        {
            return _od.ObtenerInteger(propiedad);
        }

        protected internal int ObtenerInteger(string ruta)
        {
            return _od.ObtenerInteger(ruta);
        }

        protected internal long ObtenerLong(int indice)
        {
            return _od.ObtenerLong(indice);
        }

        protected internal long ObtenerLong(IPropiedad propiedad)
        {
            return _od.ObtenerLong(propiedad);
        }

        protected internal long ObtenerLong(string ruta)
        {
            return _od.ObtenerLong(ruta);
        }

        protected internal object ObtenerObject(int indice)
        {
            return _od.ObtenerObject(indice);
        }

        protected internal object ObtenerObject(IPropiedad propiedad)
        {
            return _od.ObtenerObject(propiedad);
        }

        protected internal object ObtenerObject(string ruta)
        {
            return _od.ObtenerObject(ruta);
        }

        protected internal IObjetoDatos ObtenerObjetoDatos(int indice)
        {
            return _od.ObtenerObjetoDatos(indice);
        }

        protected internal IObjetoDatos ObtenerObjetoDatos(IPropiedad propiedad)
        {
            return _od.ObtenerObjetoDatos(propiedad);
        }

        protected internal IObjetoDatos ObtenerObjetoDatos(string ruta)
        {
            return _od.ObtenerObjetoDatos(ruta);
        }

        protected internal sbyte ObtenerSByte(int indice)
        {
            return _od.ObtenerSByte(indice);
        }

        protected internal sbyte ObtenerSByte(IPropiedad propiedad)
        {
            return _od.ObtenerSByte(propiedad);
        }

        protected internal sbyte ObtenerSByte(string ruta)
        {
            return _od.ObtenerSByte(ruta);
        }

        protected internal short ObtenerShort(int indice)
        {
            return _od.ObtenerShort(indice);
        }

        protected internal short ObtenerShort(IPropiedad propiedad)
        {
            return _od.ObtenerShort(propiedad);
        }

        protected internal short ObtenerShort(string ruta)
        {
            return _od.ObtenerShort(ruta);
        }

        protected internal string ObtenerString(int indice)
        {
            return _od.ObtenerString(indice);
        }

        protected internal string ObtenerString(IPropiedad propiedad)
        {
            return _od.ObtenerString(propiedad);
        }

        protected internal string ObtenerString(string ruta)
        {
            return _od.ObtenerString(ruta);
        }

        protected internal uint ObtenerUInteger(int indice)
        {
            return _od.ObtenerUInteger(indice);
        }

        protected internal uint ObtenerUInteger(IPropiedad propiedad)
        {
            return _od.ObtenerUInteger(propiedad);
        }

        protected internal uint ObtenerUInteger(string ruta)
        {
            return _od.ObtenerUInteger(ruta);
        }

        protected internal ulong ObtenerULong(int indice)
        {
            return _od.ObtenerULong(indice);
        }

        protected internal ulong ObtenerULong(IPropiedad propiedad)
        {
            return _od.ObtenerULong(propiedad);
        }

        protected internal ulong ObtenerULong(string ruta)
        {
            return _od.ObtenerULong(ruta);
        }

        protected internal ushort ObtenerUShort(int indice)
        {
            return _od.ObtenerUShort(indice);
        }

        protected internal ushort ObtenerUShort(IPropiedad propiedad)
        {
            return _od.ObtenerUShort(propiedad);
        }

        protected internal ushort ObtenerUShort(string ruta)
        {
            return _od.ObtenerUShort(ruta);
        }

        protected internal void RemoverObjetoDatos(int indice, IObjetoDatos item)
        {
            _od.RemoverObjetoDatos(indice, item);
        }

        protected internal void RemoverObjetoDatos(IPropiedad propiedad, IObjetoDatos item)
        {
            _od.RemoverObjetoDatos(propiedad, item);
        }

        protected internal void RemoverObjetoDatos(string nombre, IObjetoDatos item)
        {
            _od.RemoverObjetoDatos(nombre, item);
        }



        #region IObjetoDatos
        IObjetoDatos IObjetoDatos.Propietario
        {
            get
            {
                return _od.Propietario;
            }
        }

        ITipo IObjetoDatos.Tipo
        {
            get
            {
                return _od.Tipo;
            }
        }

        IObjetoDatos IObjetoDatos.CrearObjetoDatos(int indice)
        {
            return _od.CrearObjetoDatos(indice);
        }

        IObjetoDatos IObjetoDatos.CrearObjetoDatos(IPropiedad propiedad)
        {
            return _od.CrearObjetoDatos(propiedad);
        }

        IObjetoDatos IObjetoDatos.CrearObjetoDatos(string ruta)
        {
            return _od.CrearObjetoDatos(ruta);
        }

        void IObjetoDatos.Eliminar()
        {
            _od.Eliminar();
        }

        void IObjetoDatos.Establecer(int indice, object valor)
        {
            _od.Establecer(indice, valor);
        }

        void IObjetoDatos.Establecer(IPropiedad propiedad, object valor)
        {
            _od.Establecer(propiedad, valor);
        }

        void IObjetoDatos.Establecer(string ruta, object valor)
        {
            _od.Establecer(ruta, valor);
        }

        void IObjetoDatos.EstablecerBoolean(int indice, bool valor)
        {
            _od.EstablecerBoolean(indice, valor);
        }

        void IObjetoDatos.EstablecerBoolean(IPropiedad propiedad, bool valor)
        {
            _od.EstablecerBoolean(propiedad, valor);
        }

        void IObjetoDatos.EstablecerBoolean(string ruta, bool valor)
        {
            _od.EstablecerBoolean(ruta, valor);
        }

        void IObjetoDatos.EstablecerByte(int indice, byte valor)
        {
            _od.EstablecerByte(indice, valor);
        }

        void IObjetoDatos.EstablecerByte(IPropiedad propiedad, byte valor)
        {
            _od.EstablecerByte(propiedad, valor);
        }

        void IObjetoDatos.EstablecerByte(string ruta, byte valor)
        {
            _od.EstablecerByte(ruta, valor);
        }

        void IObjetoDatos.EstablecerChar(int indice, char valor)
        {
            _od.EstablecerChar(indice, valor);
        }

        void IObjetoDatos.EstablecerChar(IPropiedad propiedad, char valor)
        {
            _od.EstablecerChar(propiedad, valor);
        }

        void IObjetoDatos.EstablecerChar(string ruta, char valor)
        {
            _od.EstablecerChar(ruta, valor);
        }

        void IObjetoDatos.EstablecerDateTime(int indice, DateTime valor)
        {
            _od.EstablecerDateTime(indice, valor);
        }

        void IObjetoDatos.EstablecerDateTime(IPropiedad propiedad, DateTime valor)
        {
            _od.EstablecerDateTime(propiedad, valor);
        }

        void IObjetoDatos.EstablecerDateTime(string ruta, DateTime valor)
        {
            _od.EstablecerDateTime(ruta, valor);
        }

        void IObjetoDatos.EstablecerDecimal(int indice, decimal valor)
        {
            _od.EstablecerDecimal(indice, valor);
        }

        void IObjetoDatos.EstablecerDecimal(IPropiedad propiedad, decimal valor)
        {
            _od.EstablecerDecimal(propiedad, valor);
        }

        void IObjetoDatos.EstablecerDecimal(string ruta, decimal valor)
        {
            _od.EstablecerDecimal(ruta, valor);
        }

        void IObjetoDatos.EstablecerDouble(int indice, double valor)
        {
            _od.EstablecerDouble(indice, valor);
        }

        void IObjetoDatos.EstablecerDouble(IPropiedad propiedad, double valor)
        {
            _od.EstablecerDouble(propiedad, valor);
        }

        void IObjetoDatos.EstablecerDouble(string ruta, double valor)
        {
            _od.EstablecerDouble(ruta, valor);
        }

        void IObjetoDatos.EstablecerFloat(int indice, float valor)
        {
            _od.EstablecerFloat(indice, valor);
        }

        void IObjetoDatos.EstablecerFloat(IPropiedad propiedad, float valor)
        {
            _od.EstablecerFloat(propiedad, valor);
        }

        void IObjetoDatos.EstablecerFloat(string ruta, float valor)
        {
            _od.EstablecerFloat(ruta, valor);
        }

        void IObjetoDatos.EstablecerInteger(int indice, int valor)
        {
            _od.EstablecerInteger(indice, valor);
        }

        void IObjetoDatos.EstablecerInteger(IPropiedad propiedad, int valor)
        {
            _od.EstablecerInteger(propiedad, valor);
        }

        void IObjetoDatos.EstablecerInteger(string ruta, int valor)
        {
            _od.EstablecerInteger(ruta, valor);
        }

        void IObjetoDatos.EstablecerLong(int indice, long valor)
        {
            _od.EstablecerLong(indice, valor);
        }

        void IObjetoDatos.EstablecerLong(IPropiedad propiedad, long valor)
        {
            _od.EstablecerLong(propiedad, valor);
        }

        void IObjetoDatos.EstablecerLong(string ruta, long valor)
        {
            _od.EstablecerLong(ruta, valor);
        }

        void IObjetoDatos.EstablecerObject(int indice, object valor)
        {
            _od.EstablecerObject(indice, valor);
        }

        void IObjetoDatos.EstablecerObject(IPropiedad propiedad, object valor)
        {
            _od.EstablecerObject(propiedad, valor);
        }

        void IObjetoDatos.EstablecerObject(string ruta, object valor)
        {
            _od.EstablecerObject(ruta, valor);
        }

        void IObjetoDatos.EstablecerObjetoDatos(int indice, IObjetoDatos valor)
        {
            _od.EstablecerObjetoDatos(indice, valor);
        }

        void IObjetoDatos.EstablecerObjetoDatos(IPropiedad propiedad, IObjetoDatos valor)
        {
            _od.EstablecerObjetoDatos(propiedad, valor);
        }

        void IObjetoDatos.EstablecerObjetoDatos(string ruta, IObjetoDatos valor)
        {
            _od.EstablecerObjetoDatos(ruta, valor);
        }

        void IObjetoDatos.EstablecerSByte(int indice, sbyte valor)
        {
            _od.EstablecerSByte(indice, valor);
        }

        void IObjetoDatos.EstablecerSByte(IPropiedad propiedad, sbyte valor)
        {
            _od.EstablecerSByte(propiedad, valor);
        }

        void IObjetoDatos.EstablecerSByte(string ruta, sbyte valor)
        {
            _od.EstablecerSByte(ruta, valor);
        }

        void IObjetoDatos.EstablecerShort(int indice, short valor)
        {
            _od.EstablecerShort(indice, valor);
        }

        void IObjetoDatos.EstablecerShort(IPropiedad propiedad, short valor)
        {
            _od.EstablecerShort(propiedad, valor);
        }

        void IObjetoDatos.EstablecerShort(string ruta, short valor)
        {
            _od.EstablecerShort(ruta, valor);
        }

        void IObjetoDatos.EstablecerString(int indice, string valor)
        {
            _od.EstablecerString(indice, valor);
        }

        void IObjetoDatos.EstablecerString(IPropiedad propiedad, string valor)
        {
            _od.EstablecerString(propiedad, valor);
        }

        void IObjetoDatos.EstablecerString(string ruta, string valor)
        {
            _od.EstablecerString(ruta, valor);
        }

        void IObjetoDatos.EstablecerUInteger(int indice, uint valor)
        {
            _od.EstablecerUInteger(indice, valor);
        }

        void IObjetoDatos.EstablecerUInteger(IPropiedad propiedad, uint valor)
        {
            _od.EstablecerUInteger(propiedad, valor);
        }

        void IObjetoDatos.EstablecerUInteger(string ruta, uint valor)
        {
            _od.EstablecerUInteger(ruta, valor);
        }

        void IObjetoDatos.EstablecerULong(int indice, ulong valor)
        {
            _od.EstablecerULong(indice, valor);
        }

        void IObjetoDatos.EstablecerULong(IPropiedad propiedad, ulong valor)
        {
            _od.EstablecerULong(propiedad, valor);
        }

        void IObjetoDatos.EstablecerULong(string ruta, ulong valor)
        {
            _od.EstablecerULong(ruta, valor);
        }

        void IObjetoDatos.EstablecerUShort(int indice, ushort valor)
        {
            _od.EstablecerUShort(indice, valor);
        }

        void IObjetoDatos.EstablecerUShort(IPropiedad propiedad, ushort valor)
        {
            _od.EstablecerUShort(propiedad, valor);
        }

        void IObjetoDatos.EstablecerUShort(string ruta, ushort valor)
        {
            _od.EstablecerUShort(ruta, valor);
        }

        bool IObjetoDatos.Establecido(int indice)
        {
            return _od.Establecido(indice);
        }

        bool IObjetoDatos.Establecido(IPropiedad propiedad)
        {
            return _od.Establecido(propiedad);
        }

        bool IObjetoDatos.Establecido(string ruta)
        {
            return _od.Establecido(ruta);
        }

        object IObjetoDatos.Obtener(int indice)
        {
            return _od.Obtener(indice);
        }

        object IObjetoDatos.Obtener(IPropiedad propiedad)
        {
            return _od.Obtener(propiedad);
        }

        object IObjetoDatos.Obtener(string ruta)
        {
            return _od.Obtener(ruta);
        }

        bool IObjetoDatos.ObtenerBoolean(int indice)
        {
            return _od.ObtenerBoolean(indice);
        }

        bool IObjetoDatos.ObtenerBoolean(IPropiedad propiedad)
        {
            return _od.ObtenerBoolean(propiedad);
        }

        bool IObjetoDatos.ObtenerBoolean(string ruta)
        {
            return _od.ObtenerBoolean(ruta);
        }

        byte IObjetoDatos.ObtenerByte(int indice)
        {
            return _od.ObtenerByte(indice);
        }

        byte IObjetoDatos.ObtenerByte(IPropiedad propiedad)
        {
            return _od.ObtenerByte(propiedad);
        }

        byte IObjetoDatos.ObtenerByte(string ruta)
        {
            return _od.ObtenerByte(ruta);
        }

        char IObjetoDatos.ObtenerChar(int indice)
        {
            return _od.ObtenerChar(indice);
        }

        char IObjetoDatos.ObtenerChar(IPropiedad propiedad)
        {
            return _od.ObtenerChar(propiedad);
        }

        char IObjetoDatos.ObtenerChar(string ruta)
        {
            return _od.ObtenerChar(ruta);
        }

        IColeccion IObjetoDatos.ObtenerColeccion(int indice)
        {
            return _od.ObtenerColeccion(indice);
        }

        IColeccion IObjetoDatos.ObtenerColeccion(IPropiedad propiedad)
        {
            return _od.ObtenerColeccion(propiedad);
        }

        IColeccion IObjetoDatos.ObtenerColeccion(string ruta)
        {
            return _od.ObtenerColeccion(ruta);
        }

        DateTime IObjetoDatos.ObtenerDateTime(int indice)
        {
            return _od.ObtenerDateTime(indice);
        }

        DateTime IObjetoDatos.ObtenerDateTime(IPropiedad propiedad)
        {
            return _od.ObtenerDateTime(propiedad);
        }

        DateTime IObjetoDatos.ObtenerDateTime(string ruta)
        {
            return _od.ObtenerDateTime(ruta);
        }

        decimal IObjetoDatos.ObtenerDecimal(int indice)
        {
            return _od.ObtenerDecimal(indice);
        }

        decimal IObjetoDatos.ObtenerDecimal(IPropiedad propiedad)
        {
            return _od.ObtenerDecimal(propiedad);
        }

        decimal IObjetoDatos.ObtenerDecimal(string ruta)
        {
            return _od.ObtenerDecimal(ruta);
        }

        double IObjetoDatos.ObtenerDouble(int indice)
        {
            return _od.ObtenerDouble(indice);
        }

        double IObjetoDatos.ObtenerDouble(IPropiedad propiedad)
        {
            return _od.ObtenerDouble(propiedad);
        }

        double IObjetoDatos.ObtenerDouble(string ruta)
        {
            return _od.ObtenerDouble(ruta);
        }

        float IObjetoDatos.ObtenerFloat(int indice)
        {
            return _od.ObtenerFloat(indice);
        }

        float IObjetoDatos.ObtenerFloat(IPropiedad propiedad)
        {
            return _od.ObtenerFloat(propiedad);
        }

        float IObjetoDatos.ObtenerFloat(string ruta)
        {
            return _od.ObtenerFloat(ruta);
        }

        int IObjetoDatos.ObtenerInteger(int indice)
        {
            return _od.ObtenerInteger(indice);
        }

        int IObjetoDatos.ObtenerInteger(IPropiedad propiedad)
        {
            return _od.ObtenerInteger(propiedad);
        }

        int IObjetoDatos.ObtenerInteger(string ruta)
        {
            return _od.ObtenerInteger(ruta);
        }

        long IObjetoDatos.ObtenerLong(int indice)
        {
            return _od.ObtenerLong(indice);
        }

        long IObjetoDatos.ObtenerLong(IPropiedad propiedad)
        {
            return _od.ObtenerLong(propiedad);
        }

        long IObjetoDatos.ObtenerLong(string ruta)
        {
            return _od.ObtenerLong(ruta);
        }

        object IObjetoDatos.ObtenerObject(int indice)
        {
            return _od.ObtenerObject(indice);
        }

        object IObjetoDatos.ObtenerObject(IPropiedad propiedad)
        {
            return _od.ObtenerObject(propiedad);
        }

        object IObjetoDatos.ObtenerObject(string ruta)
        {
            return _od.ObtenerObject(ruta);
        }

        IObjetoDatos IObjetoDatos.ObtenerObjetoDatos(int indice)
        {
            return _od.ObtenerObjetoDatos(indice);
        }

        IObjetoDatos IObjetoDatos.ObtenerObjetoDatos(IPropiedad propiedad)
        {
            return _od.ObtenerObjetoDatos(propiedad);
        }

        IObjetoDatos IObjetoDatos.ObtenerObjetoDatos(string ruta)
        {
            return _od.ObtenerObjetoDatos(ruta);
        }

        sbyte IObjetoDatos.ObtenerSByte(int indice)
        {
            return _od.ObtenerSByte(indice);
        }

        sbyte IObjetoDatos.ObtenerSByte(IPropiedad propiedad)
        {
            return _od.ObtenerSByte(propiedad);
        }

        sbyte IObjetoDatos.ObtenerSByte(string ruta)
        {
            return _od.ObtenerSByte(ruta);
        }

        short IObjetoDatos.ObtenerShort(int indice)
        {
            return _od.ObtenerShort(indice);
        }

        short IObjetoDatos.ObtenerShort(IPropiedad propiedad)
        {
            return _od.ObtenerShort(propiedad);
        }

        short IObjetoDatos.ObtenerShort(string ruta)
        {
            return _od.ObtenerShort(ruta);
        }

        string IObjetoDatos.ObtenerString(int indice)
        {
            return _od.ObtenerString(indice);
        }

        string IObjetoDatos.ObtenerString(IPropiedad propiedad)
        {
            return _od.ObtenerString(propiedad);
        }

        string IObjetoDatos.ObtenerString(string ruta)
        {
            return _od.ObtenerString(ruta);
        }

        uint IObjetoDatos.ObtenerUInteger(int indice)
        {
            return _od.ObtenerUInteger(indice);
        }

        uint IObjetoDatos.ObtenerUInteger(IPropiedad propiedad)
        {
            return _od.ObtenerUInteger(propiedad);
        }

        uint IObjetoDatos.ObtenerUInteger(string ruta)
        {
            return _od.ObtenerUInteger(ruta);
        }

        ulong IObjetoDatos.ObtenerULong(int indice)
        {
            return _od.ObtenerULong(indice);
        }

        ulong IObjetoDatos.ObtenerULong(IPropiedad propiedad)
        {
            return _od.ObtenerULong(propiedad);
        }

        ulong IObjetoDatos.ObtenerULong(string ruta)
        {
            return _od.ObtenerULong(ruta);
        }

        ushort IObjetoDatos.ObtenerUShort(int indice)
        {
            return _od.ObtenerUShort(indice);
        }

        ushort IObjetoDatos.ObtenerUShort(IPropiedad propiedad)
        {
            return _od.ObtenerUShort(propiedad);
        }

        ushort IObjetoDatos.ObtenerUShort(string ruta)
        {
            return _od.ObtenerUShort(ruta);
        }

        void IObjetoDatos.RemoverObjetoDatos(int indice, IObjetoDatos item)
        {
            _od.RemoverObjetoDatos(indice, item);
        }

        void IObjetoDatos.RemoverObjetoDatos(IPropiedad propiedad, IObjetoDatos item)
        {
            _od.RemoverObjetoDatos(propiedad, item);
        }

        void IObjetoDatos.RemoverObjetoDatos(string nombre, IObjetoDatos item)
        {
            _od.RemoverObjetoDatos(nombre, item);
        }
        #endregion

    }    
}
