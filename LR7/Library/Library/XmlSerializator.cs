using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Library
{
    class XmlSer
    {
        public void Serialize(Author obj)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Author));
            using (FileStream stream = new FileStream("Authors.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(stream, obj);
                stream.Close();
            }
        }

        public void DeSerialize( out Author obj)
        {
            using (FileStream stream = new FileStream("Authors.xml", FileMode.OpenOrCreate))
            {
                XmlSerializer Deserializer = new XmlSerializer(typeof(Author));
                obj = (Author)Deserializer.Deserialize(stream);                
            }
        }

    }
}
