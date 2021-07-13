using System.Collections.Generic;

namespace ProtoTinkr
{
    public class CreateProjectModel
    {
        public string name { get; set; }
        public string description { get; set; }
        public string grade { get; set; }
        public List<string> teachers { get; set; }
        public List<string> evaluations { get; set; }

        public CreateProjectModel()
        {
            
        }
    }
}