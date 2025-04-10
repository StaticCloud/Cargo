﻿using Cargo.src.interfaces;
using Docker.DotNet;
using Docker.DotNet.Models;

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

        public Task<IList<ContainerListResponse>> LoadContainers(string id)
        {
            return _client.Containers.ListContainersAsync(new ContainersListParameters
            {
                All = true,
                Filters = new Dictionary<string, IDictionary<string, bool>>()
                {
                    { "ancestor",  new Dictionary<string, bool>() { { id, true }  } }
                }
            });
        }

        public Task<CreateContainerResponse> CreateContainer(string name)
        {
            return _client.Containers.CreateContainerAsync(new CreateContainerParameters
            {
                Image = name,
                HostConfig = new HostConfig
                {
                    // Subject to change
                    PublishAllPorts = true
                }
            });
        }

        public Task<bool> StartContainer(string id) 
        {
            return _client.Containers.StartContainerAsync(id, new ContainerStartParameters());
        }

        public Task<bool> StopContainer(string id)
        {
            return _client.Containers.StopContainerAsync(id, new ContainerStopParameters());
        }
    }
}
