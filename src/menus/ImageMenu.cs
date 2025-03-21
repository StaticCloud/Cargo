using Cargo.src.interfaces;
using Cargo.src.utils;
using Docker.DotNet.Models;
using Spectre.Console;

namespace Cargo.src.menus
{
    internal class ImageMenu : IMenu
    {
        private IList<ImagesListResponse> _images;
        public ImageMenu(IList<ImagesListResponse> images) 
        { 
            _images = images;
        }

        public void Render()
        {
            string[] choices = new string[_images.Count];

            for (int i = 0; i < _images.Count; i++) 
            {   
                choices[i] = $"{ImageUtils.TrimID(_images[i].ID)} {ImageUtils.TrimName(_images[i].RepoTags[0])}";
            }

            SelectionPrompt<string> prompt = new SelectionPrompt<string>();
            prompt.AddChoices(choices);

            AnsiConsole.MarkupLine("[underline blue][bold]Docker Images[/][/]");
            AnsiConsole.Prompt(prompt);
        }
    }
}
