using System;

namespace ejercicio2Composite
{
    /// Clase Hoja (Leaf): Representa los objetos finales de la estructura que no tienen hijos.
    public class Empleado : IComponenteEmpleado
    {
        private string _nombre;
        private string _cargo;

        public Empleado(string nombre, string cargo)
        {
            _nombre = nombre;
            _cargo = cargo;
        }

        /// Implementación simple: Solo imprime sus propios datos.
        public void MostrarDetalles(int indentacion = 0)
        {
            // 'indentacion' ayuda a visualizar la jerarquía visualmente en consola.
            Console.WriteLine($"{new string(' ', indentacion * 2)}- Empleado: {_nombre}, Cargo: {_cargo}");
        }
    }
}
