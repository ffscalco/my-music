# MyMusic

Project in .net to play with multilayer architecture, repositories and Unit of Work, Entity Framework, Automapper and Swagger

## Pre-requisites

- .NET Core sdk
- Docker (to run MSSQL Server)
- Visual Studio (recommended IDE)
- Nuget package management console extension for Visual Studio

##  Setup the project

1. Install the pre-requisites above
2. `$ git clone git@github.com:ffscalco/my-music.git` - Clone the project
3. `$ cd my-music` - Go into the project folder
4. `$ docker-compose up -d` to spin up the database
5. Using the nuget package manager console, run `$ Update-Database`

## Runing the project

1. Start the application using Visual Studio
2. You can play with the API using Swagger

### Credits

Many thanks to this [blogpost](https://medium.com/swlh/building-a-nice-multi-layer-net-core-3-api-c68a9ef16368)
