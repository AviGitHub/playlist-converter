namespace ConvertTfsXmlToPlaylists
{
    public class RemoteConfiguration
    {
        public string ConfigurationName { get; set; }
        public string Host { get; set; }
        public string ServerType { get; set; }
        public int Port { get; set; }

        /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
        public RemoteConfiguration(string configurationName, string host, string serverType, int port)
        {
            ConfigurationName = configurationName;
            Host = host;
            ServerType = serverType;
            Port = port;
        }

        /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
        public RemoteConfiguration()
        {
            ConfigurationName = "DUT";
            Host = "${DutIp}";
            ServerType = "XOSA";
            Port = 6500;
        }
    }
}
