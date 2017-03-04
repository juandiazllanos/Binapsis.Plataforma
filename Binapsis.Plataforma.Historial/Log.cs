using Binapsis.Plataforma.Historial.Interno;

namespace Binapsis.Plataforma.Historial
{
    public class Log
    {        
        public Instantanea CrearInstantanea() => Historial?.CrearInstantanea();

        public void Recuperar(Instantanea instantanea) => Historial?.Recuperar(instantanea);

        public void Deshacer() => Historial?.Deshacer();

        internal HistorialObjetoDatos Historial { get; set; }

    }
}
