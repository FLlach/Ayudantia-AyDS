# Ejercicio práctico: Sistema de Gestión de Figuras Geométricas

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



# Ejercicio Práctico: Sistema de Red Social "SocialTech"

## 🎯 Objetivo
El objetivo de este ejercicio es aplicar los conceptos fundamentales de la **Programación Orientada a Objetos (POO)** en C#, específicamente el uso de **clases abstractas**, **herencia**, y el polimorfismo mediante el **override** de métodos.

---

## 📝 Contexto del Problema
Vas a desarrollar el motor lógico de una red social. En esta plataforma, los usuarios pueden realizar diferentes tipos de publicaciones. Aunque todos los "Posts" comparten características comunes (como el autor y la fecha), la forma en que se visualizan y la manera en que los usuarios interactúan con ellos varía según el tipo de contenido.

---

## ⚙️ Requerimientos Técnicos

### 1. Clase Abstracta: `Publicacion`
Crea una clase base abstracta llamada `Publicacion` que contenga:
- **Propiedades**: 
    - `Autor` (string)
    - `Fecha` (DateTime)
- **Constructor**: Debe inicializar el nombre del autor y asignar la fecha actual (`DateTime.Now`).
- **Método Abstracto**: 
    - `void MostrarContenido()`: No debe tener implementación. Obligará a las clases hijas a definir cómo se muestran.
- **Método Virtual**: 
    - `void Reaccionar()`: Implementación base que imprima: *"Alguien reaccionó a la publicación"*.

### 2. Clases Derivadas
Debes implementar tres tipos de publicaciones específicas:

1.  **`PostTexto`**:
    - Propiedad adicional: `Mensaje` (string).
    - **Override** de `MostrarContenido()`: Muestra el autor, la fecha y el texto del mensaje.
2.  **`PostImagen`**:
    - Propiedad adicional: `UrlImagen` (string).
    - **Override** de `MostrarContenido()`: Muestra un mensaje indicando que se está visualizando la imagen en la URL correspondiente.
    - **Override** de `Reaccionar()`: Debe imprimir: *"¡Le diste Like a la foto!"*.
3.  **`PostVideo`**:
    - Propiedad adicional: `Duracion Segundos` (int).
    - **Override** de `MostrarContenido()`: Indica que se está reproduciendo un video y muestra su duración.
    - **Override** de `Reaccionar()`: Debe imprimir: *"Video guardado en la lista de Reproducción"*.

---

## 🚀 Desafío de Implementación
En tu programa principal (`Program.cs` o método `Main`):
1.  Crea una lista de tipo `List<Publicacion>`.
2.  Instancia al menos un objeto de cada clase derivada y agrégalos a la lista.
3.  Utiliza un bucle `foreach` para recorrer la lista.
4.  Dentro del bucle, llama a los métodos `MostrarContenido()` y `Reaccionar()` para cada publicación.


