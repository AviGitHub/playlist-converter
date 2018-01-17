using System.Collections.Generic;

namespace ConvertTfsXmlToPlaylists
{
    public class PlayListFileHandler
    {
        public List<PlayListEntryConfiguration> PlayListEntryList { get; set; }


        /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
        public PlayListFileHandler(List<PlayListEntryConfiguration> playListEntryLists)
        {
            this.PlayListEntryList = playListEntryLists;
        }

        /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
        public PlayListFileHandler()
        {
        }
    }
    
    public class PlayListEntryConfiguration
    {
        public string ScriptName { get; set; }
        public string ScriptPath { get; set; }
        public string Parameters { get; set; }
        public string AdditionalData { get; set; }
        public string EstTime { get; set; }
        public bool Enabled { get; set; }
        

        /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
        public PlayListEntryConfiguration(string scriptName, string parameters)
        {
            ScriptName = scriptName;
            ScriptPath = "";
            Parameters = parameters;
            AdditionalData = "";
            EstTime = "0:0:0";
            Enabled = true;
        }

        /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
        public PlayListEntryConfiguration()
        {
        }
    }
}
