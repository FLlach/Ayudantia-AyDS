using System;

namespace Ayudantia3.Models
{
    public abstract class Publicacion
    {
        public string Autor { get; set; }
        public DateTime Fecha { get; set; }

        protected Publicacion(string autor)
        {
            Autor = autor;
            Fecha = DateTime.Now;
        }

        // Método abstracto: cada hijo define su visualización
        public abstract void MostrarContenido();

        // Método virtual: implementación base que puede ser sobrescrita
        public virtual void Reaccionar()
        {
            Console.WriteLine("Alguien reaccionó a la publicación");
        }
    }
}
