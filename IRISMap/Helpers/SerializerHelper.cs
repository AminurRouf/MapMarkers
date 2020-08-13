using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace IRISMap.Helpers
{
    public class SerializerHelper
    {
        public static IList<T> DeserializeToEntities<T>(FileStream stream, XmlRootAttribute root )  
        {  
            var serializer = new XmlSerializer(typeof(List<T>), root);  
            var entities = serializer.Deserialize(stream) as List<T>;
            return entities;
        } 
    }
}