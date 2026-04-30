using System;

namespace Ayudantia3.Models
{
    public class PostImagen : Publicacion
    {
        public string UrlImagen { get; set; }

        public PostImagen(string autor, string urlImagen) : base(autor)
        {
            UrlImagen = urlImagen;
        }

        public override void MostrarContenido()
        {
            Console.WriteLine($"[POST DE IMAGEN] - {Autor} el {Fecha}");
            Console.WriteLine($"Visualizando imagen en: {UrlImagen}");
        }

        public override void Reaccionar()
        {
            Console.WriteLine("¡Le diste Like a la foto!");
        }
    }
}
