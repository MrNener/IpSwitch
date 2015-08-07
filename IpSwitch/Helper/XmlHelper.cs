using System.IO;
using System.Xml.Serialization;

namespace Helper
{
    public static class XmlHelper
    {
        /// <summary>
        /// xml反序列化为对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xml">xml字符串</param>
        /// <returns></returns>
        public static T Deserialize<T>(string xml)
        {
            using (StringReader sr = new StringReader(xml))
            {
                XmlSerializer xmldes = new XmlSerializer(typeof(T));
                return (T)xmldes.Deserialize(sr);
            }
        }
        /// <summary>
        /// xml反序列化为对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static T Deserialize<T>(Stream stream) 
        {
            XmlSerializer xmldes = new XmlSerializer(typeof(T));
            return (T)xmldes.Deserialize(stream);
        }

        /// <summary>
        /// 对象序列化为XML
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">待序列化对象</param>
        /// <returns></returns>
        public static string Serializer<T>(T obj) 
        {
            using (MemoryStream stream = new MemoryStream())
            {
                //创建序列化对象 
                XmlSerializer xml = new XmlSerializer(typeof(T));
                xml.Serialize(stream, obj);
                stream.Position = 0;
                using (StreamReader sr = new StreamReader(stream))
                {
                    return sr.ReadToEnd();
                }
            }

        }
    }
}
