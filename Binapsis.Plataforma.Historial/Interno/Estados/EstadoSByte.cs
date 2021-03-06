using Binapsis.Plataforma.Estructura;

namespace Binapsis.Plataforma.Historial.Interno.Estados
{
	internal class EstadoSByte : HistorialEstado
    {
		private sbyte _valor;

		public EstadoSByte(IImplementacion impl, IPropiedad propiedad, sbyte valor)
            : base(impl, propiedad)
        {
            _valor = valor;
		}
        
		public override void Deshacer(HistorialComando comando)
        {
            comando.Deshacer(_impl, _propiedad, _valor);
        }
        
    }
}