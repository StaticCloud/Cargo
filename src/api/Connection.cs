using Docker.DotNet;

namespace Cargo.src.api
{
    internal class Connection
    {
        private DockerClient _client;

        public Connection()
        {
            _client = new DockerClientConfiguration().CreateClient();

            try
            {

                Task ping = _client.System.PingAsync();

                ping.Wait();

                Console.WriteLine(ping.Status);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
