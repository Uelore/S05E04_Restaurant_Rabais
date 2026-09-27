using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Rabais
{
    public class CalculateurRabaisFidelite : IStrategieRabais
    {
        public decimal Calculer (decimal sousTotal) 
        {
            return ReglesRabais.LimiterTotalAZero(sousTotal - (sousTotal * 0.10m));
        }
    }
}
