using Docker.DotNet.Models;
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

        public static void ContainerTable(IList<ContainerListResponse> res)
        {
            Table table = new Table();

            table.Border = TableBorder.SimpleHeavy;

            table.AddColumn("[blue]ID[/]");
            table.AddColumn("[blue]Name[/]");
            table.AddColumn("[blue]Running[/]");

            foreach (ContainerListResponse row in res) 
            {
                // Reminder to consolidate ID trimmer in non-image util class
                string color = row.State == "running" ? "Green" : "White";

                table.AddRow($"{row.ID.Substring(0, 12)}", $"{row.Names[0].Split('/')[1]}", $"[{color}]{row.State}[/]");
            }

            AnsiConsole.Write(table);
        }
    }
}
