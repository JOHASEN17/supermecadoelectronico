# 🛒 Supermercado Electrónico - Sistema de Gestión de Productos y Usuarios

**Supermercado Electrónico** es una aplicación de escritorio desarrollada en **C#** utilizando **Windows Forms** y el patrón de arquitectura en capas. Este proyecto tiene como finalidad simular el funcionamiento de un sistema de gestión integral para supermercados, especialmente enfocado en el control de productos, ventas e inventario, con posibilidad de extensión hacia una solución completa tipo POS (Point of Sale).

---

## 🎯 Objetivo del Proyecto

El objetivo de este sistema es servir como base funcional y didáctica para el desarrollo de aplicaciones empresariales de escritorio, aplicando principios sólidos de la programación orientada a objetos y buenas prácticas de diseño de software. Además de cumplir con funcionalidades clave, se prioriza la organización modular, la mantenibilidad del código y la separación de responsabilidades.

---

## 🧩 Funcionalidades Principales

A continuación, se describen las funcionalidades implementadas y se justifican algunas de ellas con fragmentos de código extraídos directamente del proyecto:

- 🔐 **Inicio de sesión:** Validación de credenciales contra la base de datos mediante un formulario de autenticación seguro.
- 📋 **Registro y listado de productos:** Alta y visualización de productos activos del inventario.
- 🗑️ **Baja de productos:** Eliminación lógica de productos del sistema.
- 💾 **Persistencia de datos:** Mediante conexión a SQL Server usando una clase Singleton para la administración centralizada de la conexión.
- 🧾 **Registro de ventas:** Posibilidad de registrar ventas y generar reportes (en desarrollo).
- 📦 **Control de inventario:** Control de stock actualizado tras cada venta.
- 🚨 **Alertas de bajo inventario:** Notificación visual de productos que alcanzan un nivel crítico de existencia.
- 👤 **Gestión de sesiones:** Identificación del usuario autenticado durante el uso del sistema.

---

### 🔗 Ejemplo: Conexión Singleton a Base de Datos

```csharp
// dbConexionSingleton.cs
public class dbConexionSingleton
{
    private static SqlConnection conexion;
    private static readonly string cadena = "Data Source=.;Initial Catalog=SupermercadoDB;Integrated Security=True";

    public static SqlConnection ObtenerConexion()
    {
        if (conexion == null)
        {
            conexion = new SqlConnection(cadena);
        }
        return conexion;
    }
}
```
_Este código implementa el patrón Singleton para asegurar una única instancia de conexión a la base de datos durante toda la ejecución de la aplicación._

---

### 🗑️ Ejemplo: Baja lógica de producto

```csharp
// ProductoRepository.cs
public void EliminarProducto(int id)
{
    using (SqlCommand cmd = new SqlCommand("UPDATE Productos SET Activo = 0 WHERE Id = @id", conexion))
    {
        cmd.Parameters.AddWithValue("@id", id);
        conexion.Open();
        cmd.ExecuteNonQuery();
        conexion.Close();
    }
}
```
_Este método realiza una baja lógica de productos mediante un campo `Activo`, evitando la eliminación física de registros._

---

### 🚨 Ejemplo: Alerta por bajo stock

```csharp
// InventarioService.cs
public List<Producto> ObtenerProductosBajoStock()
{
    return productos.Where(p => p.Cantidad <= 5).ToList();
}
```
_Con este método, se filtran los productos cuyo stock es igual o menor a 5 unidades, permitiendo generar alertas visuales al usuario._

---

## 🏗 Arquitectura del Proyecto

El proyecto sigue una **arquitectura en capas**, organizada de la siguiente manera:

- 🎨 **Capa de presentación:** Formularios como `Form1` y `loginForm` que representan la interfaz gráfica.
- 🧠 **Capa de lógica de negocio (Servicios):** Manejo de procesos como autenticación y control de inventario.
- 🗃️ **Capa de acceso a datos (Repositorios):** Acceso a base de datos de forma desacoplada usando interfaces.
- 🔁 **Unit of Work:** Implementación de una unidad de trabajo para agrupar transacciones de forma segura.
- 🧰 **Utilidades:** Clases auxiliares como `dbConexionSingleton` (gestión de conexión) y `sesionUsuario`.

---

## 🖥 Requisitos del Sistema

Para compilar y ejecutar correctamente esta aplicación, necesitas:

- 💻 Sistema operativo: Windows 10 o superior
- 🧰 IDE: Visual Studio 2022 o superior
- 🧱 Framework: .NET Framework 4.7.2 o superior
- 🗄️ Motor de base de datos: SQL Server Developer Edition (recomendado para pruebas y desarrollo)
- 📦 Espacio de almacenamiento mínimo: 200 MB
- 🌐 Conexión a Internet (opcional, solo para restaurar paquetes NuGet si se usan en versiones futuras)

---

## ⚙️ Instalación y Ejecución

1. Clona el repositorio:
   ```bash
   git clone https://github.com/tuusuario/supermercadoelectronico.git
   ```

2. Abre **Visual Studio** y selecciona la solución `supermecadoelectronico.sln` dentro de la carpeta raíz.

3. Asegúrate de tener instalado SQL Server Developer y crea una base de datos con el nombre y tablas esperadas (los scripts no están incluidos en esta versión).

4. Configura la cadena de conexión en el archivo `App.config` o directamente en la clase `dbConexionSingleton.cs`.

5. Presiona `F5` o haz clic en **Start** para ejecutar la aplicación.

---

## 📁 Estructura del Proyecto

```
supermecadoelectronico/
│
├── Form1.cs                         # Formulario principal de productos
├── loginForm.cs                     # Formulario de autenticación de usuarios
├── CLASES/
│   ├── Productos.cs                 # Entidad de producto
│   ├── Usuario.cs                   # Entidad de usuario
│   ├── repositorios/                # Interfaces y clases de acceso a base de datos
│   ├── services/                    # Lógica de negocio (ej. AuthService, ProductoService)
│   ├── UnitOfWork/                  # Implementación del patrón Unit of Work
│   └── Utils/                       # Conexión a DB y gestión de sesión
├── supermecadoelectronico.sln      # Archivo de solución de Visual Studio
├── supermecadoelectronico.csproj   # Proyecto principal en C#
└── README.md                        # Este archivo
```

---

## 📦 Dependencias

- 🧱 **SQL Server Developer Edition** — Motor de base de datos relacional para desarrollo
- 🔗 **ADO.NET (clases nativas)** — Para conexión directa a SQL Server (no se usan paquetes NuGet externos por ahora)
- 📌 *Nota:* En futuras versiones se considerará el uso de paquetes como Dapper, CsvHelper o log4net

---

## 📈 Estado del Proyecto

> 🚧 Este proyecto se encuentra en **fase de pruebas y gestión de desarrollo**.  
> Actualmente funciona como **versión beta**, con funcionalidades básicas implementadas.  
> Se planea incorporar: generación de reportes, mejora en la gestión de usuarios, historial de ventas, y exportación a PDF o CSV.

---

## 👨‍💻 Autores

- **Willinton Puerta**  
- **Carlos Caicedo**

¡Gracias por revisar este proyecto! Cualquier sugerencia o contribución es bienvenida.

---

## 📜 Licencia

Este proyecto es de uso académico y está en desarrollo. Puede reutilizarse con fines educativos o como base para otros proyectos personales.
