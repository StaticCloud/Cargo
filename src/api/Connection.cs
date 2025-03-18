using Cargo.src.interfaces;
using Cargo.src.services;
using Docker.DotNet;
using Spectre.Console;

namespace Cargo.src.api
{
    internal class Connection
    {
        public DockerClient client { get; }
        
        public Connection()
        {
            client = new DockerClientConfiguration().CreateClient();

            TestConnection();
        }

        public void TestConnection()
        {
            AnsiConsole.Status().Start("[blue]Connecting to Docker daemon...[/]", ctx => {
                ctx.Spinner(Spinner.Known.Star);
                ctx.SpinnerStyle(Style.Parse("blue"));

                try
                {
                    AnsiConsole.Clear();

                    Task ping = client.System.PingAsync();

                    ping.Wait();

                    Console.WriteLine(ping.Status);
                }
                catch
                {
                    AnsiConsole.MarkupLine("[red]Connection to the Docker engine could not be established. Please make sure it is running locally on your machine.[/]");
                }
            });
        }
    }
}
