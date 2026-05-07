namespace ejercicio2Composite
{
    /// Interfaz Común (Component): Define las operaciones que tanto 
    /// las hojas como los compuestos deben implementar.
    public interface IComponenteEmpleado
    {
        // Método que será implementado de forma simple por el Empleado 
        // y de forma recursiva por el Departamento.
        void MostrarDetalles(int indentacion = 0);
    }
}
