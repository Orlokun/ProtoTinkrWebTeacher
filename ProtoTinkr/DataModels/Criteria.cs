using System.Collections.Generic;

namespace ProtoTinkr
{
    public class Criteria
    {
        public string LearningOutcome { get; set; }
        private List<Indicator> _indicators;
        private int _maxScore;

        public Criteria()
        {
            _indicators = new List<Indicator>();
        }

        public void AddIndicator()
        {
            _indicators.Add(new Indicator());
        }
    }
}