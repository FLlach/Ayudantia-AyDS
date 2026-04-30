using System;
using System.Collections.Generic;
using Ayudantia3.Models;

namespace Ayudantia3.Controllers
{
    public class GeometriaController
    {
        public void Ejecutar()
        {
            Console.WriteLine("=== SISTEMA DE GESTIÓN DE FIGURAS GEOMÉTRICAS ===");
            Console.WriteLine("=================================================");

            List<Figura> figuras = new List<Figura>
            {
                new Circulo("Círculo Pequeño", 5.0),
                new Rectangulo("Rectángulo Estándar", 10.0, 4.0),
                new Circulo("Círculo Grande", 15.0),
                new Rectangulo("Cuadrado", 8.0, 8.0)
            };

            foreach (var figura in figuras)
            {
                figura.MostrarInformacion();
            }

            Console.WriteLine("\nPresione una tecla para pasar al siguiente ejercicio...");
            Console.WriteLine("-------------------------------------------------\n");
        }
    }
}
