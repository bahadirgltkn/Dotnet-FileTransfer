using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XML.Domain
{
    public class XMLWriter
    {
        public string SerializeObject<T>(T data)
        {
            var MySerializer = new XmlSerializer(typeof(T));
            TextWriter textWriter = new StringWriter();
            MySerializer.Serialize(textWriter, data);
            return textWriter.ToString();
        }
    }
}
