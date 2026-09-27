namespace Restaurant.Rabais;

public class CalculateurFacture
{
    private IStrategieRabais m_strategie;

    public CalculateurFacture(IStrategieRabais strategie)
    {
        if (strategie == null)
        {
            throw new ArgumentNullException("La stratégie ne peut pas être nulle");
        }
        m_strategie = strategie;
    }
    public decimal CalculerTotal(decimal sousTotal)
    {
        return m_strategie.Calculer(sousTotal);
    }
}
