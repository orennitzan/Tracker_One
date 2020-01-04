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
            if(res.Count > Constants.maxSupported)
            {
                int range = res.Count - Constants.maxSupported;
                res.RemoveRange(10, range);
            }
            return res;
        }

        public static bool SaveEntitiesListToCsv(List<XEntity> entitiesList)
        {
            StringBuilder sb = new StringBuilder();
            // eID1, name1, 10, 10 
            foreach (var xe in entitiesList)
            {
                foreach (var p in xe.HistoryTrack)
                {
                    string line = string.Format("{0}, {1}, {2}, {3}\n", xe.DisplayId, xe.Name, p.X.ToString(), p.Y.ToString());
                    sb.Append(line);
                }
            }

            string path = HelperMethods.GetFilePath("Track_History.csv");
            File.WriteAllText(path, sb.ToString());
            return true;
        }

        private static string GetJsonString()
        {
            var jsomPath = HelperMethods.GetFilePath("entityData.json");
            if (!File.Exists(jsomPath)) return null;
            StringBuilder sb = new StringBuilder();
            sb.Append(File.ReadAllText(jsomPath));
            return sb.ToString();
        }


    }
}
