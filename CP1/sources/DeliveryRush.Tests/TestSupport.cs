using DeliveryRush.Domain;
using DeliveryRush.Entregas;

namespace DeliveryRush.Tests;

internal static class TestSupport
{
    public static Pedido CriarPedido(
        int numero,
        decimal subtotal,
        Entrega? entrega = null)
        => new(numero, $"Cliente {numero}", subtotal, entrega ?? new EntregaPadrao());
}
