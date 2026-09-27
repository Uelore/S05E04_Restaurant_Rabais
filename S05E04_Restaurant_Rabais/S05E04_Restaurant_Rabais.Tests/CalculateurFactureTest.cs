using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Rabais.Tests
{
    public class CalculateurFactureTest
    {
        [Fact]
        public void Constructeur_StrategieNulle_ClasseNonInitie()
        {
            Assert.Throws<ArgumentNullException>(() => new CalculateurFacture(null));
        }
    }
}
