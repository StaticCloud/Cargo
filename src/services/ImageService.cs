using Cargo.src.interfaces;
using Docker.DotNet;
using Docker.DotNet.Models;
using Spectre.Console;

namespace Cargo.src.services
{
    internal class ImageService : IService
    {
        private DockerClient _client;

        public DockerClient Client { get => _client; }

        public ImageService(DockerClient client)
        { 
            _client = client;
        }

        public async void LoadImages()
        {
            var res = _client.Images.ListImagesAsync(new ImagesListParameters{ All = true }).Result;
            foreach (var image in res) 
            {
                AnsiConsole.WriteLine(image.RepoTags[0]);
            }
        }
    }
}
