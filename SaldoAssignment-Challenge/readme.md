# SaldoAssignment-Challenge

Este proyecto implementa un sistema para asignar saldos de cuentas de clientes a un grupo de gestores de cobros de manera justa. La asignaci�n se realiza utilizando un algoritmo que distribuye los saldos en orden descendente y de forma equitativa entre los gestores.

## Descripci�n del Proyecto

- Ordena los saldos en orden descendente.
- Asigna los saldos uno por uno a cada gestor.
- Repite el proceso hasta que todos los saldos est�n asignados.

## Tecnolog�as Utilizadas

- **.NET Core** para la API backend.
- **Entity Framework Core** para la interacci�n con la base de datos.
- **SQL Server Express** para la base de datos.

## Instalaci�n y Configuraci�n

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

## Justificaci�n del Uso de Entity Framework Core (EF Core)
En este proyecto, se decidi� utilizar Entity Framework Core (EF Core) en lugar de procedimientos almacenados en T-SQL. Esta elecci�n se basa en las siguientes razones:

Abstracci�n y Facilidad de Mantenimiento:

EF Core permite a los desarrolladores trabajar con las entidades de C# sin preocuparse directamente por escribir consultas SQL. Esto reduce la cantidad de c�digo espec�fico de SQL y mejora el mantenimiento del proyecto, ya que la l�gica de negocio est� centralizada en un solo lugar (el c�digo C#).
Si en el futuro es necesario realizar cambios en la l�gica de asignaci�n, podemos hacer las modificaciones directamente en el c�digo C# sin necesidad de modificar procedimientos almacenados o escribir nuevos scripts SQL.
Migraciones Automatizadas:

EF Core permite crear y aplicar migraciones que mantienen sincronizada la estructura de la base de datos con el modelo de datos en el c�digo. Esto elimina la necesidad de escribir scripts SQL manuales para la creaci�n y modificaci�n de tablas.
Al usar migraciones, podemos aplicar cambios a la base de datos de manera controlada y segura, lo que resulta especialmente �til para proyectos que evolucionan r�pidamente.
Portabilidad:

Al utilizar EF Core, el c�digo es m�s port�til y menos dependiente de una tecnolog�a espec�fica de base de datos (en este caso, SQL Server). En caso de querer cambiar a otra base de datos, como PostgreSQL o MySQL, el proceso es mucho m�s sencillo y flexible sin necesidad de reescribir el c�digo SQL.
Inyecci�n de Dependencias y Testing:

EF Core se integra f�cilmente con la infraestructura de inyecci�n de dependencias de ASP.NET Core, lo que facilita la separaci�n de responsabilidades y las pruebas unitarias.
Gracias a esto, es posible simular la base de datos para pruebas sin necesidad de conectar con una instancia real de SQL Server, lo cual mejora la eficiencia en el desarrollo y el testing.
Soporte para LINQ:

EF Core permite escribir consultas utilizando LINQ (Language Integrated Query), lo que hace que las consultas sean m�s intuitivas y seguras. LINQ tambi�n ofrece mayor flexibilidad en las consultas y permite manipular los datos sin salir del entorno C#.