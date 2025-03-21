# Cargo

## Table of Contents
- [About](#About)
- [Features](#Features)
- [Installation](#Installation)
- Usage
- [Architecture](#Architecture)
- License

## About
A CLI-based Docker client.

## Features
- Manage images from the CLI.
- Pull and push Docker images from the Docker daemon.
- Monitor and modify running Docker containers.

## Installation

### Prerequisite Installations
- [Git](https://git-scm.com/downloads)
- [Docker Desktop](https://www.docker.com/products/docker-desktop/)
- [.NET 9.0](https://dotnet.microsoft.com/en-us/download)

### Cloning Instructions

1. Copy a remote URL of your choice:  
``` 
// HTTPS:
https://github.com/StaticCloud/Cargo.git
```

```
// SSH
git@github.com:StaticCloud/Cargo.git
```

2. Open a terminal and clone the repository:
```
> git clone <remote url>
```

3. .NET should implicitly generate all build files and install depenencies. If not, run the following commands:
```
> cd Cargo
> dotnet restore
> dotnet build
```

# Architecture

## File Structure
```
src/
|-- interfaces/
|   |-- IMenu.cs
|   |-- IService.cs
|-- menus/
|   |-- ImageMenu.cs
|   |-- MainMenu.cs
|-- services/
|   |-- ImageService.cs
|   |-- Services.cs
|-- utils/
|   |-- ImageUtils.cs
|-- Connection.cs
|-- Program.cs
```
