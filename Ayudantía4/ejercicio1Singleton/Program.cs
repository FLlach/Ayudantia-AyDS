using ejercicio1Singleton;

Console.WriteLine("--- Demostración Patrón Singleton ---");

// Intentamos obtener la instancia por primera vez.
// Note que no usamos 'new', sino la propiedad estática 'Instancia'.
ConfiguracionSeguridad terminalA = ConfiguracionSeguridad.Instancia;
Console.WriteLine($"Nivel de alerta inicial en terminalA: {terminalA.NivelAlerta}");

// Modificamos el estado del objeto a través de la variable 'terminalA'.
terminalA.NivelAlerta = "Crítico";
Console.WriteLine("Se ha cambiado el nivel de alerta a 'Crítico' desde terminalA.");

// Obtenemos la instancia nuevamente usando otra variable 'terminalB'.
ConfiguracionSeguridad terminalB = ConfiguracionSeguridad.Instancia;
// Verificamos que 'terminalB' ya tiene el cambio realizado por 'terminalA'.
Console.WriteLine($"Nivel de alerta consultado desde terminalB: {terminalB.NivelAlerta}");

// Comprobación de identidad: ¿Son exactamente el mismo objeto en memoria?
if (ReferenceEquals(terminalA, terminalB))
{
    Console.WriteLine("Éxito: terminalA y terminalB referencian la MISMA instancia de memoria.");
}
else
{
    Console.WriteLine("Error: terminalA y terminalB referencian instancias diferentes.");
}
