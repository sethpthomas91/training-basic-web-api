# Training Web API

A simple web api that is mostly created through dotnet commands. It has a simple publish step that uses Github Actions so other users can run the application. 


## Getting Started

### Dependencies

* [dotnet 6.0](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)

### Installing

* Coming Soon

### Executing program

1. Clone the repo and navigate to the directory
```
git clone git@github.com:sethpthomas91/training-basic-web-api.git
cd training-basic-web-api
```
2. Trust the server certificate
```
dotnet dev-certs https --trust
```
3. Run the application
```
dotnet run --project ./src/WebApi.csproj
```
4. Open a web browser and navigate to the displayed local host. It should be in your terminal after running the last command and look something like: https://localhost:7187

### Exiting program

1. In your terminal hit `ctl + c`