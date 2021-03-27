# RestAPI

## Description:

This is an example of a basic Rest API using MongoDB on the backend. Will implement OAuth2 next. Here are the steps I've taken.

## Directions

***
- *Create project in directory of your choice*
	- ` dotnet new webapi `
***
- *Create models for each table in database*
	- ![Model](images/model.png)
***
- Create associated controllers and routes
	- ![Controller](images/controller.png)
***
- *Connect database*
	- *In appsettings.json*
	![App settings with MongoDB](images/appsettings.png)
	- [ASP.NET >> MongoDB](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mongo-app?view=aspnetcore-5.0&tabs=visual-studio)
***
- Create Service that connects to tables/collections in data store. (UserService)
	- *In models add a service for db settings*
	![Create dbsettings service](images/dbsettings.png)
***
- In Services folder add a service for each table/model in db
	- ![UserService](images/userservice1.png)
	![UsersService Two](images/userservice2.png)
***
- *In startup.cs add to ConfigureServices method line 39-45* 
	- ![Configure Services in startup.cs](images/configureservices.png)
    ***