using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace ConvertTfsXmlToPlaylists
{
    public class XmlUtils
    {
        /// <summary>
        /// Store object to file
        /// 
        /// Note that the object must contain an empty constructor
        /// </summary>
        /// <param name="fileName">path</param>
        /// <param name="theObject">input object</param>
        public static void ObjToXmlNoHeader(string fileName, object theObject)
        {
            var settings = new XmlWriterSettings
            {
                Indent = true,
                OmitXmlDeclaration = true
            };

            var xmlSerializer = new XmlSerializer(theObject.GetType());
            var ns = new XmlSerializerNamespaces();
            ns.Add("", "");

            using (var xmlWriter = XmlWriter.Create(fileName, settings))
            {
                xmlSerializer.Serialize(xmlWriter, theObject, ns);
                xmlWriter.Flush();
                xmlWriter.Close();
            }
        }

        /// <summary>
        /// Store object to file
        /// 
        /// Note that the object must contain an empty constructor
        /// </summary>
        /// <param name="fileName">path</param>
        /// <param name="theObject">input object</param>
        public static void ObjToXml(string fileName, object theObject)
        {
            var ser = new XmlSerializer(theObject.GetType());
            using (var sr = new StreamWriter(fileName))
            {
                ser.Serialize(sr, theObject);
                sr.Flush();
                sr.Close();
            }
        }

        /// <summary>
        /// Get object serialized from XML file
        /// </summary>
        /// <typeparam name="T">type of obj</typeparam>
        /// <param name="fileName"></param>
        /// <returns>deserialied object from xml</returns>
        public static T XmlToObj<T>(string fileName)
        {
            var ser = new XmlSerializer(typeof(T));
            using (var sr = new StreamReader(fileName))
            {
                var deserialized = ser.Deserialize(sr);
                sr.Close();
                return (T)deserialized;
            }
        }
    }
}
