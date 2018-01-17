using System;

namespace ConvertTfsXmlToPlaylists
{
    class Program
    {
        public static string inputTfsXml;
        public static string currentTime = DateTime.Now.ToString("ddMMyy_HHmmss");

        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] == "-in")
                {
                    inputTfsXml = args[++i];
                }

                if (args[i].ToLower() == "/?" || args[i].ToLower() == "/h")
                {
                    Console.WriteLine("Usage:\nConvertTfsXmlToCI.exe -in <input_tfs_player_xml>");
                }
            }

            if (string.IsNullOrEmpty(inputTfsXml))
            {
                Console.WriteLine("Missing input or output files");
                Environment.Exit(-1);
            }

            var generateCiPlayList = Logic.GenerateCiPlayList(inputTfsXml);
            var generateScriptPlayerPlayList = Logic.GenerateScriptPlayerPlayList(inputTfsXml);

            var cpPlaylistFile = $"cir_player_playlist_{currentTime}.xml";
            var spPlaylistFile = $"script_player_playlist_{currentTime}.xml";

            XmlUtils.ObjToXmlNoHeader(cpPlaylistFile, generateCiPlayList);
            XmlUtils.ObjToXml(spPlaylistFile, generateScriptPlayerPlayList);

            Console.WriteLine("Generated files:\n" +
                              $"{cpPlaylistFile}\n" +
                              $"{spPlaylistFile}");
            Console.WriteLine("Done!");


        }
    }
}
