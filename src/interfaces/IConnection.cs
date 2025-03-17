using Docker.DotNet;

namespace Cargo.src.interfaces
{
    interface IConnection
    {
        DockerClient GetClient();
        void TestConnection();
    }
}
