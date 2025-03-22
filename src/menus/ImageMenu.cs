using Cargo.src.interfaces;
using Cargo.src.services;
using Cargo.src.utils;
using Docker.DotNet.Models;
using Spectre.Console;

namespace Cargo.src.menus
{
    internal class ImageMenu : IMenu
    {
        private IList<ImagesListResponse> _images;
        private string[] _choices;
        private Services _services;

        public ImageMenu(Services services) 
        { 
            _services = services;
            _images = _services.imageService.LoadImages().Result;
            _choices = new string[_images.Count];

            for (int i = 0; i < _images.Count; i++)
            {
                _choices[i] = $"{ImageUtils.TrimID(_images[i].ID)} {ImageUtils.TrimName(_images[i].RepoTags[0])}";
            }

            Render();
        }

        public void Render()
        {
            string choice = AnsiConsole.Prompt(new SelectionPrompt<string>().Title("Select an image to modify:").AddChoices(_choices));

            new ContainerMenu(choice, _services);
        }
    }
}
