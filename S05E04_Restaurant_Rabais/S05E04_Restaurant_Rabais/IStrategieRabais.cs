using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Rabais
{
    public interface IStrategieRabais
    {
        public decimal Calculer(decimal sousTotal);
    }
}
