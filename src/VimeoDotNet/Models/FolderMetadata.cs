using System;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace VimeoDotNet.Models
{
    [Serializable]
    public class FolderMetadata
    {

        [PublicAPI]
        [JsonProperty(PropertyName = "connections")]
        public FolderConnections Connections { get; set; }

        [PublicAPI]
        [JsonProperty(PropertyName = "interactions")]
        public FolderConnections Interactions { get; set; }
    }
}