using System.Collections.Generic;

namespace ProtoTinkr
{
    public class Teacher : PlayerProfile
    {
        public List<LearningProject> draftProjects;
        public List<LearningProject> _programmedProjects;
        public List<LearningProject> _archivedProjects;

        public Teacher()
        {
            draftProjects = new List<LearningProject>();
            _programmedProjects = new List<LearningProject>();
            _archivedProjects = new List<LearningProject>();
        }
    }
}