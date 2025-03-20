using Cargo.src.interfaces;
using Spectre.Console;

namespace Cargo.src.menus
{
    internal class ImageMenu : IMenu
    {
        public static void Render()
        {

        }

        private Table BuildTable()
        {
            Table table = new Table().Title("Docker Images");

            table.Border = TableBorder.SimpleHeavy;

            table.AddColumn("ID");
            table.AddColumn("Name");

            return table;
        }
    }
}
