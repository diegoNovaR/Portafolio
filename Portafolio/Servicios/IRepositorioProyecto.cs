using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyecto
    {
        public List<ProyectoDTO> ObtenerProyectos();
    }
}
