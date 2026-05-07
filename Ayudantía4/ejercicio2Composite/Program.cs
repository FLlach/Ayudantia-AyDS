using ejercicio2Composite;

Console.WriteLine("--- Demostración Patrón Composite ---");

// Crear empleados individuales
Empleado emp1 = new Empleado("Juan Perez", "Programador Senior");
Empleado emp2 = new Empleado("Maria Garcia", "Diseñadora UX");
Empleado emp3 = new Empleado("Carlos Ruiz", "Programador Junior");
Empleado emp4 = new Empleado("Ana Lopez", "QA Engineer");

// Crear departamentos
Departamento depDesarrollo = new Departamento("Desarrollo");
Departamento depDiseño = new Departamento("Diseño");
Departamento corporacion = new Departamento("Corporación Tecnológica");

// Organizar jerarquía
depDesarrollo.Agregar(emp1);
depDesarrollo.Agregar(emp3);
depDesarrollo.Agregar(emp4);

depDiseño.Agregar(emp2);

corporacion.Agregar(depDesarrollo);
corporacion.Agregar(depDiseño);

// Mostrar organigrama completo
corporacion.MostrarDetalles();
