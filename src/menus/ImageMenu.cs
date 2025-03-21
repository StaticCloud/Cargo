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
            Table table = new Table().Title("Docker Images").BorderColor(Color.Blue);

            table.Border = TableBorder.SimpleHeavy;

            table.AddColumn("ID");
            table.AddColumn("Name");

            foreach (ImagesListResponse image in _images)
            {
                table.AddRow(ImageUtils.TrimID(image.ID), ImageUtils.TrimName(image.RepoTags[0]));
            }

            AnsiConsole.Write(table);
        }
    }
}
