using Spectre.Console;

namespace Cargo.src.menus
{
    internal class MainMenu
    {
        public static void Render() => AnsiConsole.Write(new FigletText("Cargo").Centered().Color(Color.Blue));
    
        
    }
}
