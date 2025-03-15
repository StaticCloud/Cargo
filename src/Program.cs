using Cargo.src.menus;
using Spectre.Console;
using Cargo.src.api;

namespace Cargo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainMenu.Render();
            AnsiConsole.MarkupLine("[white bold]This is still a work in progress. Please visit the [blue][link=https://github.com/StaticCloud/Cargo]GitHub[/][/] page for updates![/]");
            new Connection();
        }
    }
}
