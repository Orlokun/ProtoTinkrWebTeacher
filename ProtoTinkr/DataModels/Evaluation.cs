using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace ProtoTinkr
{
    public class Evaluation
    {
        public string EvaluationName { get; set; }
        public string EvaluationId { get; set; }
        public string LearningOutcome { get; set; }
        public int finalSemestralPonderation { get; set; }
        public int finalGrade { get; set; }

        public List<EvaluationInstance> _evalInstance;
        
    }
}