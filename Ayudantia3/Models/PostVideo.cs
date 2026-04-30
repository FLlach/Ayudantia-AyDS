using System;

namespace Ayudantia3.Models
{
    public class PostVideo : Publicacion
    {
        public int DuracionSegundos { get; set; }

        public PostVideo(string autor, int duracionSegundos) : base(autor)
        {
            DuracionSegundos = duracionSegundos;
        }

        public override void MostrarContenido()
        {
            Console.WriteLine($"[POST DE VIDEO] - {Autor} el {Fecha}");
            Console.WriteLine($"Reproduciendo video de {DuracionSegundos} segundos...");
        }

        public override void Reaccionar()
        {
            Console.WriteLine("Video guardado en la lista de Reproducción");
        }
    }
}
