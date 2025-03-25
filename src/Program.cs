using Cargo.src.menus;

namespace Cargo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainMenu mainMenu = new MainMenu();
            
            mainMenu.Render();
        }
    }
}
