namespace ConvertTfsXmlToPlaylists
{
    public class PlayItem
    {
        public string Name { get; set; }
        public string ExecutableName { get; set; }
        public string Arguments { get; set; }
        public bool Enabled { get; set; }
        public int ExcpectedExitCodes { get; set; }
        public string RemoteConfigurationName { get; set; }
        public int SecondsToTimeOut { get; set; }

        public PlayItem()
        {
            
        }

        /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
        public PlayItem(string name, string executableName, string arguments, bool enabled, int excpectedExitCodes, string remoteConfigurationName, int secondsToTimeOut)
        {
            Name = name;
            ExecutableName = executableName;
            Arguments = arguments;
            Enabled = enabled;
            ExcpectedExitCodes = excpectedExitCodes;
            RemoteConfigurationName = remoteConfigurationName;
            SecondsToTimeOut = secondsToTimeOut;
        }


        /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
        public PlayItem(string name, string arguments)
        {
            Name = name;
            ExecutableName = "DNA.exe";
            Arguments = arguments;
            Enabled = true;
            ExcpectedExitCodes = 0;
            RemoteConfigurationName = "DUT";
            SecondsToTimeOut = 800;
        }
    }
}
