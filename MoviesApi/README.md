# MoviesApi

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

	[   
        {
            "op": "replace",
            "path": "Title",
            "value": "Avatar"
        }
    ]
