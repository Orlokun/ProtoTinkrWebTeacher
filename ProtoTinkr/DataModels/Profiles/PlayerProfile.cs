using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProtoTinkr
{
    public class PlayerProfile
    {
        public string id { get; set; }
        public string email { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public int rol { get; set; }
        public string org_id { get; set; }
        //public List<LearningProject> activeProjects;

        public PlayerProfile(JsonElement jsonElement)
        {
            
        }

        public PlayerProfile()
        {
            
        }
    }
}