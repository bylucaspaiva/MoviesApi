# MoviesApi
 A simple api example with .net 6.
 Here you can see how connect an api to a database and make requests to it.
 And can see how to document automatically an aplication with Swegger as well.

## Packages 

- EntityFrameworkCore
- EntityFrameworkCore.Tools
- Pomelo.EntityFrameworkCore.MySQL
- Microsoft.AspNetCore.Mvc.NewtonsoftJson

## Commands in nuget console 
- Add-Migration CreateTableMovie
- Update-Database

## Commands in MySQL Workbanch
- show databases;
- use movie;
- show tables;
- describe movies;

## How to use NewtonSoft:
To make patch requests

	[   
        {
            "op": "replace",
            "path": "Title",
            "value": "Avatar"
        }
    ]
