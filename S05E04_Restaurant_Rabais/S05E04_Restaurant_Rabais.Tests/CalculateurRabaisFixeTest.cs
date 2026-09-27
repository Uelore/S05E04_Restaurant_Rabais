using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Rabais.Tests
{
    public class CalculateurRabaisFixeTest
    {
        [Theory]
        [InlineData(6,1)]
        [InlineData(4,0)]
        public void Calculer_MontantVarie_RabaisApplique(decimal sousTotal, decimal montantFinale)
        {
            CalculateurRabaisFixe calculateur = new CalculateurRabaisFixe();
            Assert.Equal(montantFinale, calculateur.Calculer(sousTotal));
        }


    }
}
