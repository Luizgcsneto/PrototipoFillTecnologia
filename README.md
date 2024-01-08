CRUD: .NET CORE 7 com Angular 16
Repositório para fins de realização do desafio proposto pela empresa Fill Tecnologia, realiazado com o desenvolvimento de .NET CORE 7 com Angular 16

Recursos Utilizados no Desenvolvimento:
Visual Studio 2022;
Visual Studio Code (para o projeto Front-End)
.NET CORE 7.0;
C#;
Angular ^16.2.0;
Typescript ~5.1.3;
Entity Framework Core (DataBase First);
SQL Server;
Node.js (execução do Front-End);

Executando Localmente:
Se faz necessário executar os seguintes comandos (Package Manager Console):
no Projeto de Infra.(Deixar todos na versão 7.0.14)

> Install-Package Microsoft.EntityFrameworkCore.SqlServer  
> Install-Package Microsoft.EntityFrameworkCore.Tools  
> Install-Package Microsoft.EntityFrameworkCore.Design

No anquivo ContextBase: colocar na ConnectionStrings o seu servidor e o banco local. como ele não existe vai ser criado com o comando. 
Lembrar de atualizar a connectionString no projeto de api no arquivo appsettings.json.
Executar os comandos 
"Add-Migration NomeDaMigration"
"Update-Database"

