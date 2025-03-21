using Cargo.src.interfaces;
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
            Table table = new Table().Title("Docker Images");

            table.Border = TableBorder.SimpleHeavy;

            table.AddColumn("ID");
            table.AddColumn("Name");

            foreach (ImagesListResponse image in _images)
            {
                table.AddRow(image.ID, image.RepoTags[0]);
            }

            AnsiConsole.Write(table);
        }
    }
}
