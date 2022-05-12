using JetBrains.Annotations;
using Newtonsoft.Json;

namespace VimeoDotNet.Models
{
    /// <summary>
    /// Album connections
    /// </summary>
    public class FolderConnections
    {
        /// <summary>
        /// Videos
        /// </summary>
        [PublicAPI]
        [JsonProperty(PropertyName = "items")]
        public FolderConnectionsEntry Items { get; set; }

        [PublicAPI]
        [JsonProperty(PropertyName = "videos")]
        public FolderConnectionsEntry Videos { get; set; }

        [PublicAPI]
        [JsonProperty(PropertyName = "folders")]
        public FolderConnectionsEntry Folders { get; set; }

        [PublicAPI]
        [JsonProperty(PropertyName = "parent_folder")]
        public FolderConnectionsEntry ParentFolder { get; set; }
    }
}