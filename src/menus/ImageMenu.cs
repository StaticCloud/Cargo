using Cargo.src.interfaces;
using Cargo.src.services;
using Cargo.src.utils;
using Docker.DotNet.Models;

namespace Cargo.src.menus
{
    internal class ImageMenu : IMenu
    {
        public Dictionary<string, Action> Choices { get; init; }

        private string _payload;
        private IList<ImagesListResponse> _images;
        private Services _services;

        public ImageMenu(Services services) 
        { 
            _services = services;
            _images = _services.imageService.LoadImages().Result;
            Choices = new Dictionary<string, Action>();

            for (int i = 0; i < _images.Count; i++)
            {
                _payload = $"{ImageUtils.TrimID(_images[i].ID)} {ImageUtils.TrimName(_images[i].RepoTags[0])}";

                ContainerMenu containerMenu = new ContainerMenu(_payload, _services);

                Choices.Add(_payload, () => containerMenu.Render());
            }
        }

        public void Render()
        {
            MenuUtils.Display(Choices, "What would you like to do with this image?");
        }
    }
}
