using System;

namespace ejercicio3Híbrido
{
    /// Singleton: Representa el recurso único de hardware para dibujar (Lienzo/Canvas).
    public class RenderizadorCanvas
    {
        private static RenderizadorCanvas? _instancia;

        // El constructor simula el encendido del hardware.
        private RenderizadorCanvas() 
        {
            Console.WriteLine("Iniciando Hardware del Canvas único...");
        }

        public static RenderizadorCanvas Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new RenderizadorCanvas();
                }
                return _instancia;
            }
        }

        /// Método que centraliza todas las operaciones de dibujo.
        public void Renderizar(string mensaje)
        {
            Console.WriteLine($"[CANVAS ÚNICO]: {mensaje}");
        }
    }
}
