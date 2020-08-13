using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;
using IRISMap.Configurations;
using IRISMap.Helpers;
using IRISMap.Repositories;

namespace IRISMap.DbContext
{
    public class XmlContext
    {
        private readonly ApplicationSettings _settings;

        public XmlContext(ApplicationSettings settings)
        {
            _settings = settings;
        }

        public IList<T> DbSet<T>() where T : Entity
        {
            
            //TODO: Should  take  this in from config settings
           string fileLocation = HttpContext.Current.Request.PhysicalApplicationPath + @"\App_Data";

            string filePath = Path.Combine($@"{fileLocation}\{typeof(T).Name}s.xml");
            IList<T> entities = new List<T>();

            if (File.Exists(filePath))
            {
                using (FileStream stream = File.OpenRead(filePath))
                {
                    entities =  SerializerHelper.DeserializeToEntities<T>(stream,  new XmlRootAttribute($"{typeof(T).Name}s"));
                   
                }
            }
            return entities.ToList();
        }

        //TODO Save
      
    }
}