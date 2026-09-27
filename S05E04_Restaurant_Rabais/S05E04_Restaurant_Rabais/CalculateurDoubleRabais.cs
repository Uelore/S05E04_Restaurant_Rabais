using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Rabais
{
    public class CalculateurDoubleRabais
    {
        IStrategieRabais m_premiereStrategie;
        IStrategieRabais m_deuxiemeStrategie;

        public CalculateurDoubleRabais(IStrategieRabais premiereStrategie, IStrategieRabais deuxiemeStrategie)
        {
            if (premiereStrategie == null) 
            {
                throw new ArgumentNullException("La première stratégie ne peut pas être nulle");
            }
            if (deuxiemeStrategie == null)
            {
                throw new ArgumentNullException("La deuxième stratégie ne peut pas être nulle");
            }
            m_premiereStrategie = premiereStrategie;
            m_deuxiemeStrategie = deuxiemeStrategie;
        }

        public decimal Calculer(decimal sousTotal)
        {
            sousTotal= m_premiereStrategie.Calculer(sousTotal);
            return m_deuxiemeStrategie.Calculer(sousTotal);
        }
    }
}
