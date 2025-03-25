using Cargo.src.services;
using Cargo.src.utils;
using Docker.DotNet;
using Spectre.Console;

namespace Cargo.src.menus
{
    internal class MainMenu
    {
        public Dictionary<string, Action> Choices { get; init; }

        private DockerClient _client;
        private Services _services;

        public MainMenu() 
        {
            Choices = new Dictionary<string, Action>
            {
                { "Connect to Docker daemon", EstablishConnection },
                { "Exit", () => Environment.Exit(0) }
            };

            AnsiConsole.Write(new FigletText("Cargo").Color(Color.Blue));
        }

        public void Render()
        {
            MenuUtils.Display(Choices);
        }

        public void EstablishConnection()
        {
            // Establish connection to Docker daemon
            _client = new Connection().client;

            // Inject client into services
            _services = new Services(_client);

            // Inject services object for interfacing with Docker daemon
            ImageMenu imageMenu = new ImageMenu(_services);

            imageMenu.Render();
        }
    }
}
