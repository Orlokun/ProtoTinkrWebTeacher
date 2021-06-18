using System;
using System.Collections.Generic;

namespace ProtoTinkr
{
    public interface IRubricManager
    {
        public int ChangeRequirementPercentage(int newReq);
        public void AddCriteria(string rubricId, Criteria criteria);
        public void AddIndicator(string rubricId, Indicator indicator);
    }

    public class RubricManager : IRubricManager 
    {
        public int ChangeRequirementPercentage(int newReq)
        {
            // if (newReq.GetType() != typeof(int))
            // {
            //     throw new ArgumentException("Cambio de requerimiento no está basado en un número entero");
            // }
            
            return newReq is < 1 or > 100 ? throw new ArgumentException("Cambio de exigencia está fuera del rango") : 
                newReq;
        }
        
        public void AddCriteria(string rubricId, Criteria criteria)
        {
            
        }

        public void AddIndicator(string rubricId, Indicator indicator)
        {

        }
    }
}