using Docker.DotNet;

namespace Cargo.src.services
{
    internal class Services
    {
        public ImageService imageService { get; }

        public Services(DockerClient dockerClient) 
        {
            imageService = new ImageService(dockerClient);
        }
    }
}
