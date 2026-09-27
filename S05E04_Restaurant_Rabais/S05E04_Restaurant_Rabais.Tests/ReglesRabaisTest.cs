using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Rabais.Tests
{
    public class ReglesRabaisTest
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(-1, 0)]
        public void LimiterTotalAZero_RecoitMontantVariant_DonneMontantValide(decimal sousTotal, decimal montantFinale)
        {
            Assert.Equal(montantFinale, ReglesRabais.LimiterTotalAZero(sousTotal));
        }
    }
}
