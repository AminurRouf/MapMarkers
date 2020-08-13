using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using IRISMap.Configurations;
using IRISMap.Repositories;
using Newtonsoft.Json;

namespace IRISMap.DbContext
{
    public class JsonContext
    {
        private readonly ApplicationSettings _settings;

        public JsonContext(ApplicationSettings settings)
        {
            _settings = settings;
        }

        public IList<T> DbSet<T>() where T : Entity
        {
            //TODO: Should  take  this in from config settings
           string fileLocation = HttpContext.Current.Request.PhysicalApplicationPath + @"\App_Data";

            string filePath = Path.Combine($@"{fileLocation}\{typeof(T).Name}s.json");
            IList<T> entities = new List<T>();

            if (File.Exists(filePath))
            {
                string json= File.ReadAllText(filePath);
                entities = JsonConvert.DeserializeObject<List<T>>(json);
            }
            return entities.ToList();
        }

      
    }
}