using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

namespace ProtoTinkr
{
    public class LearningProject
    {
        public string projectName { get; set; }
        public int pedagogicalHours { get; set; }
        public float chronologicalHours => pedagogicalHours * 0.75f;
        
        public Dictionary<string,Teacher> Teachers;
        public Dictionary<string,Students> Students;
        
        public List<Evaluation> _evaluationsList;

        public LearningProject()
        {
            Teachers = new Dictionary<string, Teacher>();
            Students = new Dictionary<string, Students>();
            _evaluationsList = new List<Evaluation>();
        }
    }
}