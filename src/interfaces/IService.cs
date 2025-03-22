using Docker.DotNet;

namespace Cargo.src.interfaces
{
    interface IService
    {
        public DockerClient Client { get; }
    }
}
