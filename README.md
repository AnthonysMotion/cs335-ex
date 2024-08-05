# cs335-ex

university of auckland,
compsci 335
semester 2, 2024

lecture exercises

--

dotnet new console --use-program-main --name name
dotnet tool install --global dotnet-ef
dotnet tool update --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.EntityFrameworkCore.Design

dotnet ef migrations add InitialCreate
dotnet ef datebase update
