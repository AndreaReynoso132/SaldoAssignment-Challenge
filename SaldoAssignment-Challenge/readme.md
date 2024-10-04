# SaldoAssignment-Challenge

Este proyecto implementa un sistema para asignar saldos de cuentas de clientes a un grupo de gestores de cobros de manera justa. La asignación se realiza utilizando un algoritmo que distribuye los saldos en orden descendente y de forma equitativa entre los gestores.

## Descripción del Proyecto

- Ordena los saldos en orden descendente.
- Asigna los saldos uno por uno a cada gestor.
- Repite el proceso hasta que todos los saldos estén asignados.

## Tecnologías Utilizadas

- **.NET Core** para la API backend.
- **Entity Framework Core** para la interacción con la base de datos.
- **SQL Server Express** para la base de datos.

## Instalación y Configuración

1. Clona el repositorio.
2. Ejecuta `dotnet restore` para instalar las dependencias.
3. Ejecuta las migraciones para crear las tablas:
   ```bash
   dotnet ef database update
   ```

4. Ejecuta el proyecto:
   ```bash
   dotnet run
   ```

## Ejemplo de Prueba

Puedes usar el siguiente JSON para probar la API:

```json
{
  "saldos": [2277, 3953, 4726, 1414, 627],
  "gestores": [
    {
      "id": 1,
      "nombre": "Gestor 1",
      "saldosAsignados": []
    },
    {
      "id": 2,
      "nombre": "Gestor 2",
      "saldosAsignados": []
    }
  ]
}

## Justificación del Uso de Entity Framework Core (EF Core)
En este proyecto, se decidió utilizar Entity Framework Core (EF Core) en lugar de procedimientos almacenados en T-SQL. Esta elección se basa en las siguientes razones:

Abstracción y Facilidad de Mantenimiento:

EF Core permite a los desarrolladores trabajar con las entidades de C# sin preocuparse directamente por escribir consultas SQL. Esto reduce la cantidad de código específico de SQL y mejora el mantenimiento del proyecto, ya que la lógica de negocio está centralizada en un solo lugar (el código C#).
Si en el futuro es necesario realizar cambios en la lógica de asignación, podemos hacer las modificaciones directamente en el código C# sin necesidad de modificar procedimientos almacenados o escribir nuevos scripts SQL.
Migraciones Automatizadas:

EF Core permite crear y aplicar migraciones que mantienen sincronizada la estructura de la base de datos con el modelo de datos en el código. Esto elimina la necesidad de escribir scripts SQL manuales para la creación y modificación de tablas.
Al usar migraciones, podemos aplicar cambios a la base de datos de manera controlada y segura, lo que resulta especialmente útil para proyectos que evolucionan rápidamente.
Portabilidad:

Al utilizar EF Core, el código es más portátil y menos dependiente de una tecnología específica de base de datos (en este caso, SQL Server). En caso de querer cambiar a otra base de datos, como PostgreSQL o MySQL, el proceso es mucho más sencillo y flexible sin necesidad de reescribir el código SQL.
Inyección de Dependencias y Testing:

EF Core se integra fácilmente con la infraestructura de inyección de dependencias de ASP.NET Core, lo que facilita la separación de responsabilidades y las pruebas unitarias.
Gracias a esto, es posible simular la base de datos para pruebas sin necesidad de conectar con una instancia real de SQL Server, lo cual mejora la eficiencia en el desarrollo y el testing.
Soporte para LINQ:

EF Core permite escribir consultas utilizando LINQ (Language Integrated Query), lo que hace que las consultas sean más intuitivas y seguras. LINQ también ofrece mayor flexibilidad en las consultas y permite manipular los datos sin salir del entorno C#.