using Binapsis.Plataforma.Estructura;
using Binapsis.Plataforma.Estructura.Helpers;
using Binapsis.Plataforma.Estructura.Impl;

namespace Binapsis.Plataforma.Notificaciones.Test
{
    internal static class BuilderTipo
    {
        public static ITipo Construir()
        {
            Tipo tipo = new Tipo { Nombre = "ObjetoDatos", Alias = "objetoDatos", Uri = "Binapsis.Plataforma.Estructura" };

            tipo.AgregarPropiedad(new Propiedad { Nombre = "atributoId", Tipo = Primarios.Integer });
            tipo.AgregarPropiedad(new Propiedad { Nombre = "atributoBoolean", Tipo = Primarios.Boolean });
            tipo.AgregarPropiedad(new Propiedad { Nombre = "atributoByte", Tipo = Primarios.Byte });
            tipo.AgregarPropiedad(new Propiedad { Nombre = "atributoChar", Tipo = Primarios.Char });
            tipo.AgregarPropiedad(new Propiedad { Nombre = "atributoDateTime", Tipo = Primarios.DateTime });
            tipo.AgregarPropiedad(new Propiedad { Nombre = "atributoDecimal", Tipo = Primarios.Decimal });
            tipo.AgregarPropiedad(new Propiedad { Nombre = "atributoDouble", Tipo = Primarios.Double });
            tipo.AgregarPropiedad(new Propiedad { Nombre = "atributoFloat", Tipo = Primarios.Float });
            tipo.AgregarPropiedad(new Propiedad { Nombre = "atributoInteger", Tipo = Primarios.Integer });
            tipo.AgregarPropiedad(new Propiedad { Nombre = "atributoLong", Tipo = Primarios.Long });
            tipo.AgregarPropiedad(new Propiedad { Nombre = "atributoSByte", Tipo = Primarios.SByte });
            tipo.AgregarPropiedad(new Propiedad { Nombre = "atributoShort", Tipo = Primarios.Short });
            tipo.AgregarPropiedad(new Propiedad { Nombre = "atributoString", Tipo = Primarios.String });
            tipo.AgregarPropiedad(new Propiedad { Nombre = "atributoUInteger", Tipo = Primarios.UInteger });
            tipo.AgregarPropiedad(new Propiedad { Nombre = "atributoULong", Tipo = Primarios.ULong });
            tipo.AgregarPropiedad(new Propiedad { Nombre = "atributoUShort", Tipo = Primarios.UShort });

            tipo.AgregarPropiedad(new Propiedad { Nombre = "ReferenciaObjetoDatos", Tipo = tipo, Asociacion = Asociacion.Composicion, Cardinalidad = Cardinalidad.Uno });
            tipo.AgregarPropiedad(new Propiedad { Nombre = "ReferenciaObjetoDatosItem", Tipo = tipo, Asociacion = Asociacion.Composicion, Cardinalidad = Cardinalidad.Cero_Muchos });

            return tipo;
        }

        public static ITipo Construir2()
        {
            Tipo tipo = (Tipo)Construir();
            tipo.AgregarPropiedad(new Propiedad { Nombre = "ReferenciaObjetoDatos2", Tipo = tipo, Asociacion = Asociacion.Agregacion, Cardinalidad = Cardinalidad.Uno });
            
            return tipo;
        }

        public static ITipo Construir3()
        {
            Tipo tipo = (Tipo)Construir2();
            tipo.AgregarPropiedad(new Propiedad { Nombre = "ReferenciaObjetoDatosItem2", Tipo = tipo, Asociacion = Asociacion.Agregacion, Cardinalidad = Cardinalidad.Uno });

            return tipo;
        }
    }
}
