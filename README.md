# Cargo

## Table of Contents
- [About](#About)
- [Features](#Features)
- [Installation](#Installation)
- Usage
- Architecture
- License

## About
A CLI tool for managing your Docker images.

## Features
- Seamlessley generate customized Docker images using existing templates or from scratch.
- Modify and manage images from the CLI.
- Pull from Docker image registries of your choice.
- Push images to accessible Docker image registries.

## Installation

### Prerequisite Installations
- [.NET 9.0](https://dotnet.microsoft.com/en-us/download)  
- [Git](https://git-scm.com/downloads)

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
|-- menus/
|   |-- MainMenu.cs
|-- utils/
|   |-- RenderLogo.cs
|-- Program.cs
```
