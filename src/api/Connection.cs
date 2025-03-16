using Docker.DotNet;
using Spectre.Console;

namespace Cargo.src.api
{
    internal class Connection
    {
        private DockerClient _client;

        public Connection()
        {
            _client = new DockerClientConfiguration().CreateClient();

            AnsiConsole.Status().Start("[blue]Connecting to Docker engine...[/]", ctx => {
                ctx.Spinner(Spinner.Known.Star);
                ctx.SpinnerStyle(Style.Parse("blue"));
                
                try
                {
                    AnsiConsole.Clear();

                    Task ping = _client.System.PingAsync();

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
