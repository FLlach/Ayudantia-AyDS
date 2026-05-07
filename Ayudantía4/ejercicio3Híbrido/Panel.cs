using System.Collections.Generic;

namespace ejercicio3Híbrido
{
    /// <summary>
    /// Composite: Puede contener otros elementos de la GUI.
    /// </summary>
    public class Panel : IComponenteGUI
    {
        private string _nombre;
        private List<IComponenteGUI> _hijos = new List<IComponenteGUI>();

        public Panel(string nombre)
        {
            _nombre = nombre;
        }

        public void Agregar(IComponenteGUI componente)
        {
            _hijos.Add(componente);
        }

        /// <summary>
        /// Implementación de Dibujar: Llama al Singleton para reportar el inicio y fin 
        /// de su propio dibujo, y delega a sus hijos el dibujo de sus contenidos.
        /// </summary>
        public void Dibujar()
        {
            // Acceso al Singleton
            RenderizadorCanvas.Instancia.Renderizar($"--- Iniciando Dibujo de Panel '{_nombre}' ---");
            
            // Recorrido recursivo del Composite
            foreach (var hijo in _hijos)
            {
                hijo.Dibujar();
            }
            
            RenderizadorCanvas.Instancia.Renderizar($"--- Fin de Dibujo de Panel '{_nombre}' ---");
        }
    }
}
