using Docker.DotNet;

namespace Cargo.src.api
{
    internal class Connection
    {
        private DockerClient _client;

        public Connection()
        {
            _client = new DockerClientConfiguration().CreateClient();
        }
    }
}
