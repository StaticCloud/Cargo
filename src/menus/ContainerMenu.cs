using Cargo.src.interfaces;
using Cargo.src.services;
using Cargo.src.utils;

namespace Cargo.src.menus
{
    internal class ContainerMenu : IMenu
    {
        public Dictionary<string, Action> Choices { get; init; }

        private string _title;
        private string _id;
        private string[] _choices;
        private Services _services;

        public ContainerMenu(string image, Services services) 
        {
            _title = image.Split(' ')[1];
            _id = image.Split(' ')[0];
            _services = services;

            Choices = new Dictionary<string, Action>
            {
                { "Manage existing container", () => Console.WriteLine(_services.containerService.LoadContainers(_id).Result.Count) }
            };
        }

        public void Render()
        {
            MenuUtils.Display(Choices, "What would you like to do with this container?");
        }
    }
}
