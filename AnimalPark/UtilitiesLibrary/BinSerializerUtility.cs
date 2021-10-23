using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace AnimalPark.UtilitiesLibrary
{
    // This class is used to host all general binary serialization
    public class BinSerializerUtility
    {
        private BinaryFormatter formatter;
        private FileStream stream;

        // This method is used to fetch data from a binary file. The data is the content of an animalmanager object.
        public List<T> OpenBinFile<T>(string fileName)
        {
            List<T> List = new List<T>(); ;
            using (stream = File.Open(fileName, FileMode.Open))
            {
                if(stream.Length > 0)
                {
                    formatter = new BinaryFormatter();
                    List = (List<T>)formatter.Deserialize(stream);
                }
            }
            return List;
        }
        // This method is used to save data from a binary file. The data is the content of an animalmanager object.
        public void SaveBinFile<T>(T obj, string fileName)
        {
            // you must first open a stream for writing.
            using (stream = File.Open(fileName, FileMode.Create))
            {
                // Construct a BinaryFormatter and use it to serialize the data to the stream.
                formatter = new BinaryFormatter();
                formatter.Serialize(stream, obj);
            }

        }

    }
}