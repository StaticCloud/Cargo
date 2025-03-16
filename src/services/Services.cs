using Docker.DotNet;

namespace Cargo.src.services
{
    internal class Services
    {
        public ImageService imageService;

        public Services(DockerClient dockerClient) 
        {
            imageService = new ImageService(dockerClient);
        }
    }
}
