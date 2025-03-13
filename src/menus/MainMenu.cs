using Spectre.Console;

namespace Cargo.src.Menus
{
    internal class MainMenu
    {
        public static void Render() => AnsiConsole.Write(new FigletText("Cargo").Centered().Color(Color.Blue));
    }
}
