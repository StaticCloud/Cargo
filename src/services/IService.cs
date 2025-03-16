using Docker.DotNet;

namespace Cargo.src.services
{
    interface IService
    {
        DockerClient Client { get; }
    }
}
