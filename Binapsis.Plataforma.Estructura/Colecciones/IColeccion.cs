using System.Collections.Generic;

namespace Binapsis.Plataforma.Estructura.Colecciones
{
    public interface IColeccion : IEnumerable<ObjetoDatos>
    {
        bool Contiene(ObjetoDatos item);

        int Indice(ObjetoDatos item);

        int Longitud { get; }
        
        ObjetoDatos this[int indice] { get; }
    }
}
