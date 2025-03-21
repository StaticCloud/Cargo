﻿using Cargo.src.menus;
using Cargo.src.api;
using Docker.DotNet;
using Cargo.src.services;

namespace Cargo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Render();

            DockerClient client = new Connection().client;
            Services services = new Services(client);

            ImageMenu imageMenu = new ImageMenu(services.imageService.LoadImages().Result);
            imageMenu.Render();
        }
    }
}
