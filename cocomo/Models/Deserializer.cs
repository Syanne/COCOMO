using System.IO;
using System.Web;
using System.Xml.Serialization;

namespace cocomo
{
    public class Deserializer
    {
        public static void Deserialize<T>(ref T group)
        {
            string path = HttpContext.Current.Server.MapPath(@"~/App_Data/cocomoIndexes.xml");
            
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (FileStream fileStream = new FileStream(path, FileMode.Open))
            {
                group = (T)serializer.Deserialize(fileStream);
            }            
        }
    }
}
