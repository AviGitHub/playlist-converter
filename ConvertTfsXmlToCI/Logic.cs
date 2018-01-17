using System.Collections.Generic;
using System.Xml;

namespace ConvertTfsXmlToPlaylists
{
    public class Logic
    {
        public static PlayList GenerateCiPlayList(string inputTfsXml)
        {
            List<PlayItem> ret = new List<PlayItem>();

            XmlDocument doc = new XmlDocument();
            doc.Load(inputTfsXml);
            XmlNodeList playlistentryconfigurations = doc.GetElementsByTagName("playlistentryconfiguration");

            for (int i = 0; i < playlistentryconfigurations.Count; i++)
            {

                var displayname = playlistentryconfigurations[i].SelectSingleNode("displayname").InnerText.Trim();
                var autotestname = playlistentryconfigurations[i].SelectSingleNode("autotestname").InnerText.Trim()
                    .Replace("&amp;", " ");

                PlayItem paPlayItem = new PlayItem(displayname, autotestname);
                ret.Add(paPlayItem);
            }

            PlayList pl = new PlayList(ret);

            return pl;
        }

        public static PlayListFileHandler GenerateScriptPlayerPlayList(string inputTfsXml)
        {
            List<PlayListEntryConfiguration> playListEntryConfigurations = new List<PlayListEntryConfiguration>();

            XmlDocument doc = new XmlDocument();
            doc.Load(inputTfsXml);
            XmlNodeList playlistentryconfigurations = doc.GetElementsByTagName("playlistentryconfiguration");

            for (int i = 0; i < playlistentryconfigurations.Count; i++)
            {

                var autotestname = playlistentryconfigurations[i].SelectSingleNode("autotestname").InnerText.Trim()
                    .Replace("&amp;", " ");

                PlayListEntryConfiguration plc = new PlayListEntryConfiguration("DNA.exe", autotestname);
                playListEntryConfigurations.Add(plc);
            }
            

            PlayListFileHandler playListFileHandler = new PlayListFileHandler(playListEntryConfigurations);

            return playListFileHandler;
        }
    }
}
