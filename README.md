# Laboratorio 04 - Sistema de Gestión Neptuno (WPF + ADO.NET)

Este proyecto es una aplicación de escritorio desarrollada en **WPF** que consume una base de datos SQL Server (**Neptuno**) utilizando la arquitectura **ADO.NET** y procedimientos almacenados.

##  Características
- **Menú Principal:** Interfaz minimalista para navegar entre módulos.
- **Listado de Categorías:** Visualización de todas las categorías registradas usando `SqlDataReader`.
- **Búsqueda de Proveedores:** Filtro avanzado por nombre de contacto y ciudad con parámetros de SQL.
- **Arquitectura N-Capas:** Separación de responsabilidades mediante Modelos, Vistas y Lógica de datos.

##  Tecnologías Utilizadas
- **Lenguaje:** C#
- **Framework:** .NET Core / .NET 6.0+ (WPF)
- **Base de Datos:** SQL Server 2022
- **Acceso a Datos:** ADO.NET (Microsoft.Data.SqlClient)
- **Control de Versiones:** Git + GitHub

##  Estructura del Proyecto
- `Models/`: Contiene las clases `Categoria.cs` y `Proveedor.cs` que representan las entidades de la base de datos.
- `Views/`: Ventanas XAML (`ListadoCategorias`, `BusquedaProveedores`) con diseño minimalista.
- `Conexion.cs`: Clase centralizada para gestionar la cadena de conexión al servidor SQL.

##  Configuración e Instalación
1. **Base de Datos:**
   - Ejecutar el script `NeptunoDB.sql` en SQL Server Management Studio.
   - Asegurarse de tener creado el usuario `userNeptuno` con clave `123456`.
2. **Procedimientos Almacenados:**
   - Ejecutar los procedimientos `usp_ListarProductos`, `usp_ListarCategorias`, `usp_ListarProveedores` y `usp_BuscarProveedores`.
3. **Proyecto en Visual Studio:**
   - Restaurar los paquetes NuGet (específicamente `Microsoft.Data.SqlClient`).
   - Ajustar la propiedad `Data Source` en `Conexion.cs` con el nombre de tu servidor local.
