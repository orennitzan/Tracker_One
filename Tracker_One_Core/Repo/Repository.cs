using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracker_One_Core.Access
{
    public static class Repository
    {

        public static List<XEntity> GetEntitiesListFromJson()
        {
            var res = new List<XEntity>();
            string json = GetJsonString();
            res = JsonConvert.DeserializeObject<List<XEntity>>(json);
            return res;
        }

        public static bool SaveEntitiesListToCsv(List<XEntity> entitiesList)
        {
            return false;
        }

        private static string GetJsonString()
        {
            var jsomPath = Path.Combine(HelperMethods.GetJsonFilePath(), "entityData.json");
            if (!File.Exists(jsomPath)) return null;
            StringBuilder sb = new StringBuilder();
            sb.Append(File.ReadAllText(jsomPath));
            return sb.ToString();
        }

        
    }
}
