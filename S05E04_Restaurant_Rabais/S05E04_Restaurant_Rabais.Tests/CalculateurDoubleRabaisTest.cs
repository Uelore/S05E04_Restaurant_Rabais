using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Rabais.Tests
{
    public class CalculateurDoubleRabaisTest
    {
        [Fact]
        public void Constructeur_ParametreUnNul_ObjetNonInitie()
        {
            Assert.Throws<ArgumentNullException>(() => new CalculateurDoubleRabais(null, new CalculateurRabaisNul()));
        }
        [Fact]
        public void Constructeur_ParametreDeuxNul_ObjetNonInitie()
        {
            Assert.Throws<ArgumentNullException>(() => new CalculateurDoubleRabais(new CalculateurRabaisNul(), null));
        }
        [Fact]
        public void Calculer_FideliteFix_RabaisAccorde()
        {
            CalculateurDoubleRabais calculateur = new CalculateurDoubleRabais(new CalculateurRabaisFidelite(), new CalculateurRabaisFixe());
            Assert.Equal(13, calculateur.Calculer(20));
        }
        [Fact]
        public void Calculer_FixFidelite_RabaisAccorde()
        {
            CalculateurDoubleRabais calculateur = new CalculateurDoubleRabais(new CalculateurRabaisFixe(), new CalculateurRabaisFidelite());
            Assert.Equal(13.50m, calculateur.Calculer(20));
        }
    }
}
