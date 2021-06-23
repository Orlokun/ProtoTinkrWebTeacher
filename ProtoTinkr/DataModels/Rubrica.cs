using System.Collections.Generic;

namespace ProtoTinkr
{
    public class Rubrica
    {
        #region DefaultValues
        private readonly int DefaultMaxScore = 4;
        private readonly int DefaultMaxGrade = 7;
        private readonly int DefaultRequirementPercentage = 60;
        #endregion
        #region PublicFields
        public string _name { get; set; }
        public string id { get; set; }
        public string _learningOutcome { get; set; }
        public string CreatorId { get; }
        public int _puntajeMaximo { get; set; }
        public int _notaMaxima { get; set; }
        public int _exigencia { get; set; }
        private List<Criteria> _criterias;
        #endregion
        public Rubrica()
        {
            _notaMaxima = DefaultMaxGrade;
            _puntajeMaximo = DefaultMaxScore;
            _exigencia = DefaultRequirementPercentage;
            _criterias = new List<Criteria>();
        }

    }
}