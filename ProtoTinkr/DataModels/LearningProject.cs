using System.Collections.Generic;

namespace ProtoTinkr
{
    public class LearningProject
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string grade { get; set; }
        public List<string> Teachers;
        public List<string> Students;
        public List<string> evaluations;
        public string join_code { get; set; }

        public LearningProject()
        {
            Teachers = new List<string>();
            Students = new List<string>();
        }
    }
}