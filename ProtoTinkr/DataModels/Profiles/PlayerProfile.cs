using System;
using System.Collections.Generic;

namespace ProtoTinkr
{
    public class PlayerProfile
    {
        public string userId { get; set; }
        public string mailAddress { get; set; }
        public string authtoken { get; set; }
        public string organizationName { get; set; }
        public string organizationId { get; set; }
        
        public List<LearningProject> activeProjects;
    }
}