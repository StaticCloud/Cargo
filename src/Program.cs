using Cargo.src.menus;
using Cargo.src.api;
using Docker.DotNet;
using Cargo.src.services;

namespace Cargo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainMenu.Render();

            DockerClient client = new Connection().GetClient();
            Services services = new Services(client);

            services.imageService.LoadImages();
        }
    }
}
