using System.Collections.Generic;

namespace ConvertTfsXmlToPlaylists
{
    public class PlayList
    {
        public List<PlayItem> PlayItems { get; set; }
        public List<RemoteConfiguration> RemoteConfigurations { get; set; }

        /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
        public PlayList(List<PlayItem> playItems)
        {
            PlayItems = playItems;
            RemoteConfigurations = new List<RemoteConfiguration>(){new RemoteConfiguration()};
        }

        /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
        public PlayList()
        {
            PlayItems = new List<PlayItem>();
            RemoteConfigurations = new List<RemoteConfiguration>() { new RemoteConfiguration() };
        }
    }
}
