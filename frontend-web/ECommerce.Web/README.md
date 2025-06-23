
#  Proyecto ECommerce en ReactJs con Clean Architecture

**Autor**: Grupo 6

## Introducción

Este repositorio corresponde al desarrollo del sistema ECommerce utilizando **ReactJS** con un enfoque basado en **Clean Architecture**. Esta arquitectura permite escalar el proyecto, mantener el código organizado y mejorar su mantenibilidad.

## Clean Architecture

### Beneficios

- Separación de responsabilidades.
- Independencia entre capas.
- Código más limpio, reusable y testeable.
- Escalabilidad en equipos de desarrollo y funcionalidades.

## Estructura de Carpetas

```
src/
├── adapters/
│   ├── index.js
│   └── userAdapter.js
├── components/
│   ├── UserComponent.jsx
│   └── AdminComponent.jsx
├── models/
│   └── userModel.js
├── hooks/
│   ├── useUser.js
│   └── useAdmin.js
├── services/
│   └── userService.js
├── utilities/
│   └── formatter.js
├── interceptors/
│   └── authInterceptor.js
├── contexts/
│   └── UserContext.js
└── pages/
    └── Home/
        ├── Home.jsx
        ├── components/
        │   └── HomeButton.jsx
        ├── models/
        │   └── homeModel.js
        ├── hooks/
        │   └── useHomeLogic.js
        ├── services/
        │   └── homeService.js
        └── utilities/
            └── homeFormatter.js
```

### Descripción Detallada de la Estructura

#### Pages/Home (Ejemplo simple)

La carpeta `Home` funciona como un contenedor (Container Pattern), encapsulando toda la lógica y los componentes específicos de la página de inicio. Esto permite una mejor organización y un enfoque modular:

- **Home.jsx**: El componente principal que actúa como el contenedor.
- **Components**: Componentes específicos de la página Home, como `HomeButton.jsx`.
- **Models**: Define modelos específicos utilizados en la página Home.
- **Hooks**: Hooks personalizados para la lógica de negocio de la página Home.
- **Services**: Servicios que interactúan con APIs o recursos externos específicos para Home.
- **Utilities**: Herramientas y funciones de ayuda específicas para la página Home.
- **Components en Root**: Accesibles y reutilizables por toda la aplicación.
- **Components en Funcionalidades Específicas**: Utilizados solo dentro de su contexto específico, como en la carpeta `Home`.

## Beneficios de esta Arquitectura

- Código **más fácil de mantener** y **testear**.
- Posibilita **trabajo en equipo** más eficiente.
- Favorece la **modularización** y **reutilización**.
- Facilita la incorporación de **nuevas funcionalidades**.

## Recomendaciones de Desarrollo

- Mantener la regla de responsabilidad única por carpeta.
- Los componentes visuales deben residir en `components/`, mientras que los lógicos específicos de cada funcionalidad se mantienen dentro de sus respectivos contenedores en `pages/`.
- Utilizar `hooks` y `contexts` para mejorar la gestión de estado y efectos secundarios.

## Conclusión
Aplicar Clean Architecture en el desarrollo de un sistema ECommerce con ReactJS permite construir un software bien estructurado, altamente escalable y fácil de mantener. Este enfoque facilita la colaboración entre desarrolladores, promueve buenas prácticas y mejora la experiencia general del desarrollo.


