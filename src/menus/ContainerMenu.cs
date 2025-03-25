using Cargo.src.interfaces;
using Cargo.src.services;
using Cargo.src.utils;
using Docker.DotNet.Models;

namespace Cargo.src.menus
{
    internal class ContainerMenu : IMenu
    {
        public Dictionary<string, Action> Choices { get; init; }

        private string _title;
        private string _id;
        private Services _services;

        public ContainerMenu(string image, Services services) 
        {
            _title = image.Split(' ')[1];
            _id = image.Split(' ')[0];
            _services = services;

            Choices = new Dictionary<string, Action>
            {
                { "Manage existing container", ManageExistingContainers },
                { "Create new container", CreateNewContainer }
            };
        }

        public void Render()
        {
            MenuUtils.Display(Choices, $"What would you like to do with {_title}?");
        }

        private void CreateNewContainer()
        {
            _services.containerService.CreateContainer(_title).Wait();
            ManageExistingContainers();
        }

        private void ManageExistingContainers()
        {
            MenuUtils.ContainerTable(_services.containerService.LoadContainers(_id).Result);
        }
    }
}
