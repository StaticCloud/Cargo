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
        }
    }
}
