# ECommerce Móvil en React Native con Clean Architecture

**Autor**: Grupo 6

## Introducción

Este repositorio corresponde a la versión móvil del sistema ECommerce, desarrollado en **React Native** utilizando el enfoque de **Clean Architecture**. El objetivo principal es lograr una estructura clara, modular y escalable que facilite el mantenimiento y la incorporación de nuevas funcionalidades.

---

## ¿Por qué Clean Architecture?

La arquitectura limpia permite separar las responsabilidades en capas bien definidas:

- Evita el acoplamiento entre la lógica de negocio y los detalles técnicos.
- Permite realizar pruebas de manera más sencilla.
- Facilita el reemplazo o actualización de tecnologías sin afectar otras capas.
- Mejora la organización, comprensión y colaboración en equipos de desarrollo.

---

## 📁 Estructura del Proyecto

└── /src
    ├── AppModule.ts              
    ├── /core                     
    │   └── /presentation
    └── /post                     
        ├── /domain
        ├── /application
        ├── /infrastructure
        └── /presentation

---

### Domain
Define el núcleo del negocio: entidades, interfaces y contratos. Esta capa no depende de ninguna otra. Debe ser lo más estable posible.

### Application

Contiene los casos de uso del sistema, que representan las acciones que un usuario o proceso puede realizar. Estos casos de uso utilizan las interfaces del dominio, pero no conocen detalles técnicos.

### Infrastructure
Proporciona implementaciones concretas de las interfaces definidas en domain/. Aquí se integran tecnologías como bases de datos, llamadas HTTP, almacenamiento local, etc.

### Presentation
Aquí se encuentra el código visual de React Native: vistas (pantallas), controladores y lógica de presentación. Es la capa más cercana al usuario y puede consumir directamente los casos de uso de application/.

## Conclusión

Este proyecto móvil de ECommerce está diseñado con Clean Architecture para garantizar un desarrollo mantenible, escalable y modular. Esta separación de responsabilidades asegura una estructura que permite trabajar de forma colaborativa y eficiente.