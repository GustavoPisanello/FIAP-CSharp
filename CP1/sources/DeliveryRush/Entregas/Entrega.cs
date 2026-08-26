namespace DeliveryRush.Entregas;

public abstract class Entrega
{
    public abstract decimal CalcularTaxa(decimal subtotal);
}
