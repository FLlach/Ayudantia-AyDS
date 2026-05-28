# Guía de Referencia Rápida: Structurizr DSL
## Arquitectura como Código (Modelo C4)

Esta guía resume los conceptos fundamentales para trabajar con Structurizr DSL, permitiendo definir modelos C4 y generar diagramas de manera programática.

---

## 1. Estructura Base (El Esqueleto)
Todo código en Structurizr DSL se organiza dentro de un bloque `workspace`, que contiene obligatoriamente dos secciones: `model` y `views`.

```structurizr
workspace "Nombre del Proyecto" "Descripción opcional" {

    model {
        // 1. Declaración de personas, sistemas, contenedores y componentes
        // 2. Declaración de relaciones (flechas) entre ellos
    }

    views {
        // 1. Definición de qué diagramas generar (Nivel 1, 2, 3)
        // 2. Configuración estética (colores, formas, estilos)
    }
}
```

---

## 2. Variables e Identificadores
No existen variables predefinidas. Se crean identificadores (nombres cortos) para guardar elementos y referenciarlos después.

**Sintaxis de asignación:**
`nombreVariable = tipoDeElemento "Nombre Público" "Descripción" "Tecnología" "Etiqueta"`

**Ejemplo:**
```structurizr
// Definición
usuario = person "Cliente" "Usuario final de la app"
miSistema = softwareSystem "Sistema de Compras" 

// Uso de variables para crear una relación
usuario -> miSistema "Compra productos en"
```
*Regla de oro:* Identificadores en `camelCase`, sin espacios ni caracteres especiales.

---

## 3. Jerarquía y Palabras Reservadas (Keywords)

### A. Bloque `model` (Arquitectura)
Define los 4 niveles del modelo C4:

- `person`: Usuario humano o actor.
- `softwareSystem`: El nivel más alto del sistema (Nivel 1).
- `container`: Aplicación o base de datos (Nivel 2). *Debe ir dentro de un softwareSystem.*
- `component`: Bloque de código o módulo (Nivel 3). *Debe ir dentro de un container.*

**Jerarquía Visual:**
```text
workspace
  └── model
       ├── person
       └── softwareSystem
            └── container
                 └── component
```

### B. Relaciones
- `->`: Conecta dos elementos. 
  *Uso:* `varA -> varB "Descripción" "Protocolo/Tecnología"`

### C. Bloque `views` (Diagramas)
Indica al motor qué diagramas renderizar:

- `systemContext <variable>`: Diagrama de Contexto (Nivel 1).
- `container <variable>`: Diagrama de Contenedores (Nivel 2).
- `component <variable>`: Diagrama de Componentes (Nivel 3).

**Instrucciones dentro de una vista:**
- `include *`: Incluye todos los elementos conectados al sujeto del diagrama.
- `autoLayout`: Ordenamiento automático (parámetros `tb` para arriba-abajo, `lr` para izquierda-derecha).
- `description "texto"`: Añade una leyenda al pie del diagrama.

---

## 4. Estilos y Estética (`styles`)
Permiten personalizar la apariencia mediante **Tags** (etiquetas).

- `theme default`: Aplica la paleta de colores oficial de C4.
- `element "Tag"`: Selecciona elementos con esa etiqueta para aplicarles estilo.
- `background`: Color de fondo (ej: `#1168bd`).
- `color`: Color de la fuente (ej: `#ffffff`).
- `shape`: Forma geométrica (`Cylinder`, `WebBrowser`, `MobileDevicePortrait`, etc.).

**Ejemplo de Estilo:**
```structurizr
views {
    styles {
        element "Person" {
            shape person
            background #08427b
            color #ffffff
        }
    }
}
```

---

## 5. Formas Disponibles (Shapes)
Puedes cambiar la forma de los elementos usando la propiedad `shape`. Las más comunes son:

- **Básicas:** `Box` (por defecto), `RoundedBox`, `Circle`, `Ellipse`, `Hexagon`, `Diamond`.
- **Almacenamiento e Infraestructura:** `Cylinder`, `Bucket`, `Pipe`, `Folder`.
- **Actores y UI:** `Person`, `Robot`, `WebBrowser`, `Window`, `MobileDevicePortrait`, `MobileDeviceLandscape`.
- **Técnicas:** `Component`, `Terminal`, `Shell`.

---

## 6. Resumen de Reglas de Oro
1. **Identificadores Únicos:** Cada elemento debe tener una variable propia.
2. **Orden Jerárquico:** Un contenedor no puede existir fuera de un sistema.
3. **Tags para Estilos:** Usa etiquetas consistentes para que tus diagramas se vean profesionales.
4. **Relaciones en el Modelo:** Define las conexiones en el `model`, la vista solo decide cuáles mostrar.
