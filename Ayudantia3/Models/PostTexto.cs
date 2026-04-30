using System;

namespace Ayudantia3.Models
{
    public class PostTexto : Publicacion
    {
        public string Mensaje { get; set; }

        public PostTexto(string autor, string mensaje) : base(autor)
        {
            Mensaje = mensaje;
        }

        public override void MostrarContenido()
        {
            Console.WriteLine($"[POST DE TEXTO] - {Autor} el {Fecha}");
            Console.WriteLine($"Mensaje: {Mensaje}");
        }
    }
}
