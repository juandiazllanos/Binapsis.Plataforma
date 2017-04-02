using System.IO;

namespace Binapsis.Plataforma.Serializacion.Test
{
    internal class FicheroImpl : ISecuencia
    {
        string _ruta;

        public FicheroImpl(string ruta)
        {
            _ruta = ruta;
        }

        public Stream Crear()
        {
            Stream stream = new FileStream(_ruta, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            return stream;
        }
    }
}
