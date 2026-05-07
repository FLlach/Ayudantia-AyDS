using System;
using System.Collections.Generic;

namespace ejercicio2Composite
{
    /// Clase Compuesta (Composite): Puede contener tanto Hojas como otros Compuestos.
    public class Departamento : IComponenteEmpleado
    {
        private string _nombre;
        
        // Lista que almacena los hijos. Note que la lista es de la interfaz,
        // lo que permite guardar tanto Empleados como otros Departamentos.
        private List<IComponenteEmpleado> _subordinados = new List<IComponenteEmpleado>();

        public Departamento(string nombre)
        {
            _nombre = nombre;
        }

        // Métodos para gestionar la composición.
        public void Agregar(IComponenteEmpleado componente)
        {
            _subordinados.Add(componente);
        }

        public void Eliminar(IComponenteEmpleado componente)
        {
            _subordinados.Remove(componente);
        }

        /// Implementación Recursiva: Imprime sus datos y delega la tarea a sus hijos.
        public void MostrarDetalles(int indentacion = 0)
        {
            Console.WriteLine($"{new string(' ', indentacion * 2)}[Departamento: {_nombre}]");
            
            // Recorre cada hijo (sin importar si es Empleado o Departamento) 
            // y llama a su propio método MostrarDetalles.
            foreach (var componente in _subordinados)
            {
                componente.MostrarDetalles(indentacion + 1);
            }
        }
    }
}
