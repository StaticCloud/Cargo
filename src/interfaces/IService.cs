using Docker.DotNet;

namespace Cargo.src.interfaces
{
    interface IService
    {
        DockerClient Client { get; }
    }
}
