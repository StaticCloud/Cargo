using Cargo.src.interfaces;
using Docker.DotNet;

namespace Cargo.src.services
{
    internal class ContainerService : IService
    {
        private DockerClient _client;

        public DockerClient Client { get => _client; }

        public ContainerService(DockerClient client)
        {
            _client = client;
        }
    }
}
