using Portafolio.Models;

namespace Portafolio.Servicios
{
    public class RepositorioProyectos : IRepositorioProyecto
    {

        public List<ProyectoDTO> ObtenerProyectos()
        {
            return new List<ProyectoDTO>()
            {
                new ProyectoDTO
                {
                    Titulo = "Portafolio Personal",
                    DescripcionCorta = "Un portafolio personal para mostrar mis proyectos y habilidades.",
                    Descripcion = "Este es un portafolio personal que he creado para mostrar mis proyectos y habilidades. "
                    + "Para este portafolio utilice C# como lenguaje de programación ASP.NET, Framework Blazor aplicando MVC",
                    ImagenURL = "/Imagenes/integra.jpg",
                    UrlGit = "https://github.com/diegoNovaR/Portafolio.git",
                    Url = "#",
                    Tecnologias = "C#, Blazor, ASP.NET, HTML, CSS, Bootstrap"
                },
                new ProyectoDTO
                {
                    Titulo = "Cafeteria",
                    DescripcionCorta = "Es una presentacion de una cafeteria realizada para reforzar las habilidades que aprendí",
                    Descripcion = "Con este proyecto un cliente puede iniciar sesión, añadir compras a su carrito, puede eliminar las mismas compras y eliminar su sesión."
                    + "Para este proyecto utilice C# como lenguaje de programación ASP.NET, Framework Blazor aplicando MVC",
                    ImagenURL = "/Imagenes/integra.jpg",
                    UrlGit = "https://github.com/diegoNovaR/CafeteriaArquitectura.git",
                    Url = "#",
                    Tecnologias = "C#, Blazor, ASP.NET, HTML, CSS, Bootstrap"
                },
                new ProyectoDTO
                {
                    Titulo = "Gestion de Tareas Web Api",
                    DescripcionCorta = "Realice un Web Api de una gestión de tareas, en la cual aplique una conexión a SQL Server",
                    Descripcion = "Con este proyecto un cliente puede iniciar sesión, añadir compras a su carrito, puede eliminar las mismas compras y eliminar su sesión."
                    + "Para este proyecto utilice C# como lenguaje de programación ASP.NET, Framework Blazor aplicando MVC",
                    ImagenURL = "/Imagenes/integra.jpg",
                    UrlGit = "https://github.com/diegoNovaR/Portafolio.git",
                    Url = "#",
                    Tecnologias = "C#, Blazor, ASP.NET, HTML, CSS, Bootstrap"
                },  
                 new ProyectoDTO
                {
                    Titulo = "Web Api Biblioteca",
                    DescripcionCorta = "Realice una Web Api de una Biblioteca",
                    Descripcion = "Con este proyecto un cliente puede iniciar sesión, añadir compras a su carrito, puede eliminar las mismas compras y eliminar su sesión."
                    + "Para este proyecto utilice C# como lenguaje de programación ASP.NET, Framework Blazor aplicando MVC",
                    ImagenURL = "/Imagenes/integra.jpg",
                    UrlGit = "https://github.com/diegoNovaR/Portafolio.git",
                    Url = "#",
                    Tecnologias = "C#, Blazor, ASP.NET, HTML, CSS, Bootstrap"
                }
            };
        }
    }
}
