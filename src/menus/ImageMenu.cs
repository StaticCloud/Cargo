using Cargo.src.interfaces;
using Cargo.src.utils;
using Docker.DotNet.Models;
using Spectre.Console;

namespace Cargo.src.menus
{
    internal class ImageMenu : IMenu
    {
        private IList<ImagesListResponse> _images;
        private string[] _choices;
        public ImageMenu(IList<ImagesListResponse> images) 
        { 
            _images = images;
            _choices = new string[_images.Count];

            for (int i = 0; i < _images.Count; i++)
            {
                _choices[i] = $"{ImageUtils.TrimID(_images[i].ID)} {ImageUtils.TrimName(_images[i].RepoTags[0])}";
            }

            Render();
        }

        public void Render()
        {
            AnsiConsole.Prompt(new SelectionPrompt<string>().Title("Select an image to modify:").AddChoices(_choices));
        }
    }
}
