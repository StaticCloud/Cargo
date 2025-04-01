# Cargo

[![Licence](https://img.shields.io/github/license/staticcloud/cargo?style=for-the-badge)](./LICENSE)

## Table of Contents
- [About](#About)
- [Features](#Features)
- [Installation](#Installation)
- [Architecture](#Architecture)

## About
A CLI-based Docker client.

## Features
- Manage images and containers from a CLI-based menu.
- Connect to the Docker daemon to view your images.
- Manage containers categorized by base images.

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
|   |-- ContainerMenu.cs
|   |-- ImageMenu.cs
|   |-- MainMenu.cs
|-- services/
|   |-- ContainerService.cs
|   |-- ImageService.cs
|   |-- Services.cs
|-- utils/
|   |-- ImageUtils.cs
|-- Connection.cs
|-- Program.cs
```
