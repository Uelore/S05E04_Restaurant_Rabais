using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Rabais.Tests
{
    public class CalculateurRabaisNulTest
    {
        [Fact]
        public void Calculer_StrategieControlee_RabaisApplique()
        {
            CalculateurRabaisNul calculateur = new CalculateurRabaisNul();
            Assert.Equal(5m, calculateur.Calculer(5m));
        }
    }
}
