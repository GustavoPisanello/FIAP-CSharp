namespace DeliveryRush.Entregas;

public sealed class EntregaPadrao : Entrega
{
    public override decimal CalcularTaxa(decimal subtotal)
    {
        if (subtotal < 0) throw new ArgumentOutOfRangeException(nameof(subtotal), subtotal, "O Valor não pode ser negativo.");
        if (subtotal >= 80) return 0;
        return 8;
    }
}
