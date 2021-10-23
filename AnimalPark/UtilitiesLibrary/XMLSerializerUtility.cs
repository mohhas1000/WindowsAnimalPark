using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace AnimalPark.UtilitiesLibrary
{
    // This class is used to host all general xml serialization
    public class XMLSerializerUtility
    {
        private XmlSerializer serializer;
        private StreamWriter streamWriter;
        private FileStream fileStream;

        // This method is used to fetch data from a XML-file. The data is the content of a FoodManager objects (foodItems).
        public List<T> OpenXMLFile<T>(string fileName)
        {
            List<T> List = new List<T>(); ;
            using (fileStream = new FileStream(fileName, FileMode.Open))
            {
                serializer = new XmlSerializer(typeof(List<T>));
                List = (List<T>)serializer.Deserialize(fileStream);
            }
            return List;
        }
        // This method is used to save data from a XML-file. The data is the content of a FoodManager objects (foodItems).
        public void SaveXMLFile<T>(string fileName, T obj)
        {
            using (streamWriter = new StreamWriter(fileName))
            {
                serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(streamWriter, obj);
            }
        }

    }
}

