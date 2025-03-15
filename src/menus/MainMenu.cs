using Cargo.src.api;
using Spectre.Console;

namespace Cargo.src.menus
{
    internal class MainMenu
    {
        public static void Render() 
        {
            AnsiConsole.Write(new FigletText("Cargo").Centered().Color(Color.Blue));
            AnsiConsole.MarkupLine("[white bold]This is still a work in progress. Please visit the [blue][link=https://github.com/StaticCloud/Cargo]GitHub[/][/] page for updates![/]");
            string choice = AnsiConsole.Prompt(new SelectionPrompt<string>().AddChoices(new[] { "Connect to Docker", "Quit" }));  
        
            if (choice == "Connect to Docker")
            {
                new Connection();
            }
        }
    }
}
