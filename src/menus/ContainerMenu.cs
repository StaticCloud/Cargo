using Cargo.src.interfaces;
using Cargo.src.services;
using Cargo.src.utils;
using Docker.DotNet.Models;
using Spectre.Console;
using static System.Net.Mime.MediaTypeNames;

namespace Cargo.src.menus
{
    internal class ContainerMenu : IMenu
    {
        public Dictionary<string, Action> Choices { get; set; }

        private string _title;
        private string _id;
        private Services _services;
        private IList<ContainerListResponse> _containers;

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

        private void StartContainer(string id)
        {
            _services.containerService.StartContainer(id).Wait();
            ManageExistingContainers();
        }

        private void StopContainer(string id)
        {
            _services.containerService.StopContainer(id).Wait();
            ManageExistingContainers();
        }

        private void ManageExistingContainers()
        {
            AnsiConsole.Clear();

            _containers = _services.containerService.LoadContainers(_id).Result;
            MenuUtils.ContainerTable(_containers);

            Choices = new Dictionary<string, Action>
            {
                { "Start Container", StartContainers },
                { "Stop Container",  StopContainers }
            };

            MenuUtils.Display(Choices);
        }

        private void StartContainers()
        {
            for (int i = 0; i < _containers.Count; i++)
            {  
                Choices.Clear();

                Choices.Add(_containers[i].ImageID, () => StartContainer(_containers[i].ID));

                MenuUtils.Display(Choices);
            }
        }

        private void StopContainers()
        {
            for (int i = 0; i < _containers.Count; i++)
            {
                Choices.Clear();

                Choices.Add(_containers[i].ImageID, () => StopContainer(_containers[i].ID));

                MenuUtils.Display(Choices);
            }
        }
    }
}
