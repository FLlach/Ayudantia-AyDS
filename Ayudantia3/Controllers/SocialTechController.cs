using System;
using System.Collections.Generic;
using Ayudantia3.Models;

namespace Ayudantia3.Controllers
{
    public class SocialTechController
    {
        public void Ejecutar()
        {
            Console.WriteLine("=== MOTOR LÓGICO SOCIALTECH ===");
            Console.WriteLine("===============================");

            List<Publicacion> muro = new List<Publicacion>();

            muro.Add(new PostTexto("JuanPerez88", "¡Hola a todos! Este es mi primer post en SocialTech."));
            muro.Add(new PostImagen("MariaDesign", "https://imagenes.com/atardecer.jpg"));
            muro.Add(new PostVideo("GamerPro", 120));

            foreach (var post in muro)
            {
                post.MostrarContenido();
                post.Reaccionar();
                Console.WriteLine("-------------------------------\n");
            }

            Console.WriteLine("Presione Enter para finalizar...");
        }
    }
}
