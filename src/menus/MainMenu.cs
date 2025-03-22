using Cargo.src.interfaces;
using Cargo.src.services;
using Docker.DotNet;
using Spectre.Console;

namespace Cargo.src.menus
{
    internal class MainMenu : IMenu
    {
        private string[] _choices;
        private ImageMenu _imageMenu;

        private DockerClient _client;
        private Services _services;

        public MainMenu() 
        {
            _choices = ["Connect to the Docker daemon", "Quit"];

            Render();
        }

        public void Render() 
        {
            AnsiConsole.Write(new FigletText("Cargo").Color(Color.Blue));
            AnsiConsole.MarkupLine("[white bold]This is still a work in progress. Please visit the [blue][link=https://github.com/StaticCloud/Cargo]GitHub[/][/] page for updates![/]");
            
            string choice = AnsiConsole.Prompt(new SelectionPrompt<string>().AddChoices(_choices));

            switch (choice) 
            {
                case "Connect to the Docker daemon":
                    EstablishConnection();
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
        }

        public void EstablishConnection()
        {
            // Establish connection to Docker daemon
            _client = new Connection().client;

            // Inject client into services
            _services = new Services(_client);

            // Inject services object for interfacing with Docker daemon
            _imageMenu = new ImageMenu(_services);
        }
    }
}
