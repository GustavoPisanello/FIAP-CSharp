namespace DeliveryRush.Entregas;

public sealed class EntregaExpressa : Entrega
{
    public override decimal CalcularTaxa(decimal subtotal)
    {
        if (subtotal < 0) throw new ArgumentOutOfRangeException(nameof(subtotal), subtotal, "O Valor não pode ser negativo.");

        decimal taxa = subtotal * 0.15M;

        taxa = Math.Round(taxa, MidpointRounding.AwayFromZero);

        decimal menorTaxa = 12;

        if (taxa > menorTaxa) return taxa;

        return menorTaxa;

    }
}
