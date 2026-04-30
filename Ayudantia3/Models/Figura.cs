using System;

namespace Ayudantia3.Models
{
    public abstract class Figura
    {
        public string Nombre { get; set; }

        protected Figura(string nombre)
        {
            Nombre = nombre;
        }

        // Métodos abstractos que deben ser implementados por las clases hijas
        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();

        // Método común para todas las figuras
        public void MostrarInformacion()
        {
            Console.WriteLine($"--- {Nombre} ---");
            Console.WriteLine($"Área: {CalcularArea():F2}");
            Console.WriteLine($"Perímetro: {CalcularPerimetro():F2}");
            Console.WriteLine();
        }
    }
}
