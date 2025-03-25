using Spectre.Console;

namespace Cargo.src.utils
{
    internal class MenuUtils
    {
        public static void Display(Dictionary<string, Action> options, string message = "")
        {
            string[] choices = options.Keys.ToArray();

            string choice = AnsiConsole.Prompt(new SelectionPrompt<string>().Title(message).AddChoices(choices));

            options[choice]();
        }
    }
}
