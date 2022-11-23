using System.Xml.Serialization;

namespace XML.Domain
{
    public class XMLReader
    {
        public T DeserializeXML<T>(string data)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            T response;
            response = (T)serializer.Deserialize(new StringReader(data));
            return response;
        }
    }
}