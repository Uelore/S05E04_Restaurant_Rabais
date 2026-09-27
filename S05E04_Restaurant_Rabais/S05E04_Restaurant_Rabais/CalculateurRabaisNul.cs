using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Rabais
{
    public class CalculateurRabaisNul : IStrategieRabais
    {
        public decimal Calculer(decimal sousTotal) 
        {
            return ReglesRabais.LimiterTotalAZero(sousTotal);
        }

    }
}
