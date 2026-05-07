namespace Ayudantia3.Models
{
    public class Rectangulo : Figura
    {
        public double Base { get; set; }
        public double Altura { get; set; }


        public Rectangulo(string nombre, double @base, double altura) : base(nombre)
        {
            Base = @base;
            Altura = altura;
        }

        public override double CalcularArea()
        {
            return Base * Altura;
        }

        public override double CalcularPerimetro()
        {
            return 2 * (Base + Altura);
        }
    }
}
