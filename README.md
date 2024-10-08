# TEST - COINK

## Patrón de diseño
MVC

## Base de datos
Postgres

### Modelo relacional uno a uno
![Modelo Relacional](https://github.com/user-attachments/assets/0cb1b500-acbf-4c88-9f92-159c5378bc33)

## Agregar cadena de conexion AppJsonSettings
`PostgreSQLConnection": "Server=127.0.0.1;Port=5432;Database=TestCoink;User Id=postgres;Password=?`

## Creación de la base de datos desde migraciones
1. `dotnet ef migrations add TestMigration`
2. `dotnet ef database update TestMigration`

## Endpoints
Métodos de inserción: **POST**

## Paquetes NuGet utilizados
- EntityFrameworkCore
- EntityFrameworkCore.Design
- EntityFrameworkCore.Relational
- EntityFrameworkCore.Diagnostics
- Npgsql.EntityFrameworkCore.Postgres
- Swashbuckle (Defecto)
