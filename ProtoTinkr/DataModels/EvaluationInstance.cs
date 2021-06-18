using System.Collections.Generic;

namespace ProtoTinkr
{
    public class EvaluationInstance
    {
        public string evalName { get; set; }
        public bool _isCollaborative { get; set; }
        public Rubrica _rubrica;
        public List<Teacher> _teachers;
        public List<StudentGroup> StudentGroups;

        public EvaluationInstance()
        {
            _teachers = new List<Teacher>();
            StudentGroups = new List<StudentGroup>();
        }
    }
}