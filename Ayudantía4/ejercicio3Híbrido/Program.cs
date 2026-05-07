using ejercicio3Híbrido;

Console.WriteLine("--- Demostración Integración Singleton + Composite ---");

// Crear elementos de la interfaz
Boton btnAceptar = new Boton("Aceptar");
Boton btnCancelar = new Boton("Cancelar");
Boton btnAyuda = new Boton("Ayuda");

Panel panelPrincipal = new Panel("Ventana Principal");
Panel panelInferior = new Panel("Barra de Herramientas");

// Estructurar la jerarquía
panelInferior.Agregar(btnAceptar);
panelInferior.Agregar(btnCancelar);

panelPrincipal.Agregar(btnAyuda);
panelPrincipal.Agregar(panelInferior);

// El RenderizadorCanvas se instancia automáticamente al ser usado
// Dibujar la interfaz completa
panelPrincipal.Dibujar();
