namespace ejercicio1Singleton
{
    /// Clase que implementa el patrón Singleton.
    /// Garantiza que solo exista una instancia de la configuración de seguridad en toda la aplicación.
    public class ConfiguracionSeguridad
    {
        // Variable estática que almacenará la única instancia de la clase.
        private static ConfiguracionSeguridad? _instancia;

        // Propiedad de ejemplo que representa un estado compartido.
        public string NivelAlerta { get; set; } = "Bajo";


        /// Constructor privado: Regla fundamental del Singleton.
        /// Impide que se pueda usar 'new ConfiguracionSeguridad()' fuera de esta clase.

        private ConfiguracionSeguridad() 
        {
            // Aquí se podría inicializar la configuración desde un archivo o BD.
        }

        /// Punto de acceso global a la instancia única.

        public static ConfiguracionSeguridad Instancia
        {
            get
            {
                // Si la instancia aún no ha sido creada, la creamos.
                if (_instancia == null)
                {
                    _instancia = new ConfiguracionSeguridad();
                }
                return _instancia;
            }
        }
    }
}
