using System.Collections;
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

        public Task<IList<ImagesListResponse>> LoadImages()
        {
            return _client.Images.ListImagesAsync(new ImagesListParameters { All = true });
        }
    }
}
