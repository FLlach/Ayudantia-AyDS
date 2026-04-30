using System;

namespace Ayudantia3.Models
{
    public class Circulo : Figura
    {
        public double Radio { get; set; }

        public Circulo(string nombre, double radio) : base(nombre) //usamos base() para llamara al constructor padre (clase base) desde el constructor del hijo, hacemos esto pq la clase hija hereda métodos y atributos pero no el constructor, estamos obligados a usarlos si la clase padre no tiene un constructor implícito
        {
            Radio = radio;
        }

        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio;
        }
    }
}
