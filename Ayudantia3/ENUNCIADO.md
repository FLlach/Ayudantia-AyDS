# Enunciado: Sistema de Gestión de Figuras Geométricas

## Objetivo
El objetivo de esta actividad es comprender y aplicar los conceptos de **Clases Abstractas**, **Herencia** y **Polimorfismo** en C#. Se diseñará un sistema que permita manejar diferentes figuras geométricas de manera genérica.

## Contexto
Una empresa de software arquitectónico necesita un módulo que pueda procesar diversas formas geométricas para calcular sus propiedades físicas (área y perímetro). Debido a que cada figura tiene una fórmula distinta, se requiere una estructura que obligue a cada tipo de figura a implementar sus propios cálculos, permitiendo al sistema principal tratarlas a todas de forma uniforme.

## Requerimientos

### 1. Definición de la Clase Base (Abstracta)
Cree una clase abstracta llamada `Figura` dentro del espacio de nombres `Models`:
- **Atributos/Propiedades:**
    - `Nombre` (string): Identificador de la figura.
- **Constructor:** Debe recibir el nombre de la figura.
- **Métodos Abstractos:**
    - `CalcularArea()`: Debe retornar un `double`.
    - `CalcularPerimetro()`: Debe retornar un `double`.
- **Método Concreto:**
    - `MostrarInformacion()`: Debe imprimir en consola el nombre de la figura, su área y su perímetro (formateados a 2 decimales).

### 2. Implementación de Clases Hijas
Cree las siguientes clases que hereden de `Figura`:

#### Clase `Circulo`
- **Propiedad:** `Radio` (double).
- **Implementación:** 
    - Área = $\pi \times r^2$
    - Perímetro = $2 \times \pi \times r$

#### Clase `Rectangulo`
- **Propiedades:** `Base` (double) y `Altura` (double).
- **Implementación:**
    - Área = $base \times altura$
    - Perímetro = $2 \times (base + altura)$

### 3. Lógica de Aplicación (Polimorfismo)
En el archivo `Program.cs`:
1. Cree una lista de objetos de tipo `Figura`.
2. Instancie al menos dos círculos y dos rectángulos con diferentes dimensiones y agréguelos a la lista.
3. Utilice un ciclo `foreach` para recorrer la lista y llamar al método `MostrarInformacion()` de cada objeto.

## Conceptos a Evaluar
- Uso correcto del modificador `abstract`.
- Aplicación de `override` para implementar métodos abstractos.
- Uso de `base()` para llamar al constructor de la clase padre.
- Capacidad de tratar objetos de distintas clases mediante una referencia de la clase base (Polimorfismo).
