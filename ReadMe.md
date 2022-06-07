https://www.freecodecamp.org/news/how-to-perform-crud-operations-with-asp-net-core-using-vs-code-and-ado-net-b12404aef708/


How to perform CRUD Operations With ASP.NET Core using VS Code and ADO.NET


Introduction
In this article we are going to create a web application using ASP.NET Core MVC with the help of Visual Studio Code and ADO.NET. We will be creating a sample Employee Record Management System and performing CRUD operations on it.

We will use VS Code and SQLite for our demo.

Windows PowerShell
Copyright (C) Microsoft Corporation. All rights reserved.

Try the new cross-platform PowerShell https://aka.ms/pscore6

PS C:\Users\AMITAVA\MvcAdoDemo> dotnet add package runtime.native.System.Data.SqlClient.sni --version 4.7.0

PS C:\Users\AMITAVA\MvcAdoDemo>dotnet add package Microsoft.Data.Sqlite.Core --version 7.0.0-preview.3.22175.1
PS C:\Users\AMITAVA\MvcAdoDemo>dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 7.0.0-preview.3.22175.1
PS C:\Users\AMITAVA\MvcAdoDemo>dotnet add package Microsoft.Data.Sqlite --version 7.0.0-preview.3.22175.1
PS C:\Users\AMITAVA\MvcAdoDemo> dotnet add package SQLite --version 3.13.0
