# Inventarioo
# Proyecto .NET: Gestión de Productos

Este proyecto consiste en el desarrollo de una aplicación de Windows Forms (winforms) utilizando ASP.NET Core 8 y Entity Framework Core. La aplicación se conectará a una base de datos para gestionar una tabla de "Productos".

## Objetivos de la Unidad

Desarrollar un software con ASP.NET Core 8 y Windows Forms (winforms) que se conecte a la base de datos facilitada mediante Entity Framework Core.

## Instrucciones Generales

1. **Sincronización del Modelo de Datos**: Utilizar MySQL Workbench para sincronizar el modelo de datos.
2. **Generación del Modelo de Datos**: Generar el modelo de datos utilizando Entity Framework Core.
3. **Generación del Software**: Crear el software ASP.NET Core 8 con el comando `dotnet new winforms`.
4. **Interfaz Gráfica**: Utilizar SWD4CS para generar la interfaz gráfica en Visual Studio Code.

## Requisitos del Programa

La aplicación debe cumplir con los siguientes requerimientos:

1. **Listado de Productos** 
   - Listar todos los productos que actualmente tenga la base de datos.

2. **Agregar Nuevos Productos** 
   - Crear un formulario que permita agregar nuevos productos.
   - Los campos requeridos son: nombre, descripción y precio.
   - El campo `IdProducto` no es necesario ya que es auto incrementable.
   - Al guardar, la fecha de creación debe ser `DateTime.Now`.

3. **Editar Información de un Producto** 
   - Crear un formulario para editar la información de un producto utilizando el campo `idProducto`.
   - Los campos editables son: nombre, descripción y precio.
   - Al guardar, la información debe actualizarse en la base de datos y la fecha de creación debe ser `DateTime.Now`.

4. **Eliminar un Producto** 
   - Crear un formulario que permita eliminar un producto especificando el `idProducto`.
   - Incluir un botón que, al ser presionado, elimine el producto con el `idProducto` indicado.

## Evaluación
- **Asignatura**: Programación .NET 


## Nota

- Asegúrate de que todos los formularios funcionen correctamente y se conecten a la base de datos usando Entity Framework Core.
- La fecha de creación debe registrarse con el valor `DateTime.Now` en todos los casos de creación y edición de productos.

---

## Desarrollo del Proyecto

### Paso 1: Sincronizar el Modelo de Datos
Utiliza MySQL Workbench para sincronizar y visualizar la estructura de la tabla "Productos".

### Paso 2: Generar el Modelo de Datos
Utiliza Entity Framework Core para generar el modelo de datos a partir de la base de datos.

### Paso 3: Crear el Proyecto ASP.NET Core 8
Ejecuta el comando `dotnet new winforms` para crear un nuevo proyecto de Windows Forms.

### Paso 4: Generar la Interfaz Gráfica
Utiliza SWD4CS para generar la interfaz gráfica del proyecto en Visual Studio Code.

## Creación de la Base de Datos

![image](https://github.com/BenjaminNaveas/Inventarioo/assets/171303417/d4b8a609-f281-472e-90d3-0733029852b4)


Para crear la base de datos y la tabla `Productos`, utiliza las siguientes instrucciones SQL:

```sql
-- Creación de la base de datos (si aún no existe)
CREATE DATABASE IF NOT EXISTS inventarioo;
USE inventarioo;

-- Creación de la tabla productos
CREATE TABLE productos (
    idProducto INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
    nombre VARCHAR(500) NOT NULL,
    descripcion LONGTEXT,
    precio INT NOT NULL,
    fechacreacion DATETIME(6) NOT NULL
);

-- Insertar algunos productos de ejemplo
INSERT INTO productos (nombre, descripcion, precio, fechacreacion)
VALUES ('Camiseta de fútbol', 'Camiseta oficial de la selección nacional', 50, NOW()),
       ('Zapatillas deportivas', 'Zapatillas para correr Nike Air Zoom', 120, NOW()),
       ('Pantalones deportivos', 'Pantalones cortos Adidas para entrenamiento', 35, NOW()),
       ('Balón de fútbol', 'Balón de fútbol Nike Strike', 25, NOW()),
       ('Raqueta de tenis', 'Raqueta de tenis Wilson Pro Staff', 180, NOW());
