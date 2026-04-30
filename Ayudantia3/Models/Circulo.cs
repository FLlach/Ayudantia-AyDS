using System;

namespace Ayudantia3.Models
{
    public class Circulo : Figura
    {
        public double Radio { get; set; }

        public Circulo(string nombre, double radio) : base(nombre)
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
