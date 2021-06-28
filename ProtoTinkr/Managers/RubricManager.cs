using System;
using System.Collections.Generic;

namespace ProtoTinkr
{
    public interface IRubricManager
    {
        public void ChangeRequirementPercentage(Rubrica rubrica, int newReq);
        public void AddCriteria(string rubricId, Criteria criteria);
        public void AddIndicator(string rubricId, Indicator indicator);
    }

    public class RubricManager : IRubricManager 
    {
        public void ChangeRequirementPercentage(Rubrica rubrica, int newReq)
        {
            rubrica._exigencia =  newReq is < 1 or > 100 ? throw new ArgumentException("Cambio de exigencia está fuera del rango") : 
                newReq;
        }
        
        public void AddCriteria(string rubricId, Criteria criteria)
        {
            //TODO Not implemented
        }

        public void AddIndicator(string rubricId, Indicator indicator)
        {
            //TODO Not implemented
        }
    }
}