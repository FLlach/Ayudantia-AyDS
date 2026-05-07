namespace ejercicio3Híbrido
{
    /// Leaf: Representa un elemento simple de la interfaz.
    public class Boton : IComponenteGUI
    {
        private string _texto;

        public Boton(string texto)
        {
            _texto = texto;
        }

        /// Implementación de Dibujar: Solicita al Singleton (Canvas único) 
        /// que realice la operación de dibujo.
        public void Dibujar()
        {
            // El botón no sabe cómo dibujar, le pide al RenderizadorCanvas único que lo haga.
            RenderizadorCanvas.Instancia.Renderizar($"Dibujando Botón '{_texto}'");
        }
    }
}
