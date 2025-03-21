using Cargo.src.menus;
using Docker.DotNet;
using Cargo.src.services;
using Cargo.src;

namespace Cargo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainMenu.Render();

            DockerClient client = new Connection().client;
            Services services = new Services(client);

            services.imageService.LoadImages();
        }
    }
}
