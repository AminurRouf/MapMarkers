using System.Xml.Serialization;
using IRISMap.Repositories;

namespace IRISMap.Models
{
    public class Location : Entity
    {
        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public string Latitude { get; set; }

        [XmlAttribute]
        public string Longitude { get; set; }
    }
}
