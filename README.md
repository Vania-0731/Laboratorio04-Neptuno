# Laboratorio 04 - Sistema de Gestión Neptuno (WPF + ADO.NET)

Este proyecto es una aplicación de escritorio desarrollada en **WPF** que consume una base de datos SQL Server (**Neptuno**) utilizando la arquitectura **ADO.NET** y procedimientos almacenados con `SqlDataReader`.

## 🚀 Características
- **Menú Principal:** Interfaz minimalista para navegar entre módulos.
- **Listado de Categorías:** Visualización de todas las categorías registradas usando la clase `SqlDataReader`.
- **Búsqueda de Proveedores:** Filtro avanzado por nombre de contacto y ciudad utilizando parámetros de SQL.
- **Arquitectura N-Capas:** Separación de responsabilidades mediante Modelos, Vistas y Lógica de datos.

## 🛠️ Tecnologías Utilizadas
- **Lenguaje:** C#
- **Framework:** .NET Core / .NET 6.0+ (WPF)
- **Base de Datos:** SQL Server 2022
- **Acceso a Datos:** ADO.NET (Microsoft.Data.SqlClient)
- **Control de Versiones:** Git + GitHub

## 📂 Estructura del Proyecto
- `Models/`: Contiene las clases `Categoria.cs` y `Proveedor.cs` (Entidades).
- `Views/`: Ventanas XAML (`ListadoCategorias`, `BusquedaProveedores`) con diseño minimalista.
- `Database/`: Contiene el archivo `script.sql` con la estructura y procedimientos almacenados.
- `Conexion.cs`: Clase centralizada para gestionar la cadena de conexión.

## ⚙️ Configuración e Instalación
1. **Base de Datos:**
   - Abrir SQL Server Management Studio (SSMS).
   - Ejecutar el archivo `script.sql` incluido en este repositorio para crear la base de datos **Neptuno** y los procedimientos almacenados necesarios (`usp_ListarCategorias`, `usp_BuscarProveedores`, etc.).
   - **Importante:** El proyecto está configurado para el usuario `userNeptuno` con contraseña `123456`.
2. **Proyecto en Visual Studio:**
   - Clonar el repositorio y abrir el archivo `.sln`.
   - Restaurar los paquetes NuGet (clic derecho en la solución > Restaurar paquetes NuGet).
   - En la clase `Conexion.cs`, asegúrate de actualizar el `Data Source` con el nombre de tu servidor (actualmente: `LAB1508-06\SQLEXPRESS`).
