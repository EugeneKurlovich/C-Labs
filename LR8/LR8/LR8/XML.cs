using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace LR8
{
    class XML
    {
        public void SSerialize(List <Library> obj)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Library));
            using (FileStream stream = new FileStream("S.xml", FileMode.OpenOrCreate))
            {

                foreach (Library i in obj)
                {
                    serializer.Serialize(stream, i);
                }
                stream.Close();
            }
        }

        public void saveResultSort(dynamic obj)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Library));
            using (FileStream stream = new FileStream("Sort.xml", FileMode.OpenOrCreate))
            {

                foreach (Library i in obj)
                {
                    serializer.Serialize(stream, i);
                }
                stream.Close();
            }
        }

        public void DeSerialize(out Library obj)
        {
            using (FileStream stream = new FileStream("DS.xml", FileMode.OpenOrCreate))
            {
                XmlSerializer Deserializer = new XmlSerializer(typeof(Library));
                obj = (Library)Deserializer.Deserialize(stream);
            }
        }

    }
}
