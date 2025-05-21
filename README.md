# 🛒 Supermercado Electrónico - Sistema de gestión de productos y usuarios

Hola, somos los desarrolladores de esta aplicación de escritorio desarrollada en C# utilizando Windows Forms. El propósito de este proyecto es simular el funcionamiento de un sistema básico de gestión para un supermercado electrónico, enfocado 
principalmente en el manejo de usuarios y productos, todo organizado bajo una arquitectura en capas que implementa patrones de diseño como Repositorio, Unit of Work y Singleton.

Este proyecto fue una excelente oportunidad para profundizar mis conocimientos en programación orientada a objetos, gestión de formularios en C#, y la estructuración de proyectos robustos y mantenibles.

---
## 🎯 Objetivo del proyecto

El objetivo de este sistema es proporcionar una base funcional para un sistema de punto de venta (POS) o gestión de productos en un entorno de supermercado o comercio electrónico. Más allá de cumplir con funciones específicas, el foco estuvo en 
aplicar buenas prácticas de diseño de software: organización por capas, reutilización de código, separación de responsabilidades y mantenibilidad.

## 🧩 Funcionalidades principales

La aplicación incluye funcionalidades esenciales para la administración de un supermercado digital, entre las cuales destaco:

- *Inicio de sesión:* Formulario de autenticación con validación de credenciales contra la base de datos.
- *Registro y listado de productos:* Permite crear, guardar y visualizar productos dentro del sistema.
- *Gestión de sesiones:* Implementación de un sistema de sesión simple para identificar al usuario autenticado.
- *Estructura modular:* Separación clara entre la lógica de presentación, lógica de negocio, acceso a datos y utilidades compartidas.
- *Persistencia de datos:* Se espera conexión a una base de datos relacional (por defecto, SQL Server), usando una clase Singleton para gestionar la conexión.

---

## 🏗 Arquitectura del proyecto

El diseño del sistema sigue el enfoque de arquitectura en capas, lo que facilita su mantenimiento y escalabilidad. Las principales capas y componentes son:

- *Presentación:* Formularios (Form1, loginForm) que constituyen la interfaz gráfica del usuario.
- *Clases del dominio:* Representaciones de entidades como Usuario y Productos.
- *Repositorios:* Interfaces y clases que encapsulan el acceso a datos (como ProductoRepository).
- *Servicios:* Encapsulan la lógica de negocio, por ejemplo, AuthService para el proceso de autenticación.
- *UnitOfWork:* Implementación de una unidad de trabajo para manejar transacciones.
- *Utilidades:* Clases auxiliares como dbConexionsingleton (para la conexión con la base de datos) y sesionUsuario.

---

## 🔧 Tecnologías y herramientas utilizadas

- *Lenguaje:* C#
- *Framework:* .NET Framework (Windows Forms)
- *IDE:* Visual Studio
- *Gestión de base de datos:* SQL Server (la conexión se gestiona desde código)
- *Diseño:* Patrones Unit of Work, Repositorio, Singleton
- *Gestión de recursos:* .resx para recursos y configuraciones

---

## 📂 Estructura del proyecto (resumen)

```plaintext
supermecadoelectronico/
│
├── Form1.cs                         # Formulario principal
├── loginForm.cs                     # Formulario de autenticación
├── CLASES/
│   ├── Productos.cs                 # Entidad de productos
│   ├── Usuario.cs                   # Entidad de usuario
│   ├── repositorios/                # Interfaces y clases de acceso a datos
│   ├── services/                    # Servicios como autenticación
│   ├── UnitOfWork/                  # Implementación del patrón Unit of Work
│   └── Utils/                       # Clases auxiliares como sesión y conexión
├── supermecadoelectronico.sln      # Solución de Visual Studio
├── supermecadoelectronico.csproj   # Proyecto principal
└── README.md                        # Este archivo
