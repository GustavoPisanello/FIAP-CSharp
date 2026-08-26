using DeliveryRush.Entregas;

namespace DeliveryRush.Domain;

public sealed class Pedido
{
    private readonly Entrega _entrega;

    public Pedido(int numero, string cliente, decimal subtotal, Entrega entrega)
    {
        if (numero < 0) throw new ArgumentOutOfRangeException(nameof(numero), numero, "O número não pode ser negativo.");
        if (subtotal < 0) throw new ArgumentOutOfRangeException(nameof(subtotal), subtotal, "O subtotal não pode ser negativo.");
        if (cliente.Trim() == String.Empty) throw new ArgumentException(nameof(cliente), "O nome do cliente é obrigatório.");
        if (entrega == null) throw new ArgumentNullException(nameof(entrega), "A entrega é obrigatória.");

        _entrega = entrega;
        Numero = numero;
        Cliente = cliente.Trim();
        Subtotal = subtotal;
        
    }

    public int Numero { get; }

    public string Cliente { get; } = string.Empty;

    public decimal Subtotal { get; }

    public decimal TaxaEntrega
    {
        get
        {
            return (_entrega as EntregaExpressa)?.CalcularTaxa(Subtotal)
            ?? (_entrega as EntregaPadrao)?.CalcularTaxa(Subtotal)
            ?? 0m;
        }
    }

    public decimal Total
    {
        get
        {
            return Subtotal + TaxaEntrega;
        }
    }
}
