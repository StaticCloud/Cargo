using Spectre.Console;

namespace Cargo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnsiConsole.MarkupLine("[underline][white]Welcome to[/] [bold blue]Cargo![/][/]");
            AnsiConsole.MarkupLine("[white bold]This is still a work in progress. Please visit the [blue][link=https://github.com/StaticCloud/Cargo]GitHub[/][/] page for updates![/]");
        }
    }
}
