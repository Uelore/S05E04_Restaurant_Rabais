using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Rabais.Tests
{
    public class CalculateurRabaisFideliteTest
    {
        [Fact]
        public void Calculer_StrategieControlee_RabaisApplique()
        {
            CalculateurRabaisFidelite calculateur = new CalculateurRabaisFidelite();
            Assert.Equal(4.5m, calculateur.Calculer(5m));
        }
    }
}
