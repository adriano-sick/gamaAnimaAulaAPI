<h1>C# .net EF6 REST API Gama/Anima Aulas API</h1>

This is REST .net API system to manage a MS SQL Server database with: ID, Content, Date, Subject, Teacher, Duration and Video link. Developed with .net Entity Framework</br>
</br>In this project I did:

* MS SQL Server based database
* Code First: EF migration used to create database
* Data model creation to DB entity mapping
* Operations implemented: (Get, Get by Id, Get by subject, Get by teacher, Put, Post and Delete)
* REST Architeture standarts used on each operation implemented.
* Unity tests to validate functionalities
* Enviroment Variables to hide connection strings - Heroku Vars
* Cloud database implementation, using somee.com free MS SQL Server cloud server
* Cloud system implemetation, using Heroku => https://gamaanimaaulaapi.herokuapp.com/api/aulas

Requirements and packages:

* .net 5.0.
* NuGet Package Manager.
* Microsoft.EntityFrameworkCore.Design 5.0.10.
* Microsoft.EntityFrameworkCore.inMemory 5.0.10.
* Microsoft.EntityFrameworkCore.SqlServer 5.0.10.
* Microsoft.EntityFrameworkCore.Tools 5.0.10.
* Microsoft.VisualStudio.Web.CodeGenerator.Design 5.0.2

***
<br>

* Endpoints: 
  * Get: https://gamaanimaaulaapi.herokuapp.com/api/aulas
  * Get[Id]: https://gamaanimaaulaapi.herokuapp.com/api/aulas/{id}
  * Get[Subject]: https://gamaanimaaulaapi.herokuapp.com/api/aulas/subject/{subject}
  * Get[Teacher]: https://gamaanimaaulaapi.herokuapp.com/api/aulas/teacher/{teacher}
  * Put: https://gamaanimaaulaapi.herokuapp.com/api/aulas/{id}
  * Post: https://gamaanimaaulaapi.herokuapp.com/api/aulas
  * Delete: https://gamaanimaaulaapi.herokuapp.com/api/aulas/{id}

<br><br>
*Developed by: Adriano Siqueira<br>
*10/11/21
