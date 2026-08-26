using DeliveryRush.Entregas;

namespace DeliveryRush.Tests;

public sealed class EntregaTests
{
    [Theory]
    [InlineData(79.99, 8)]
    [InlineData(80, 0)]
    [Trait("CP1Points", "5")]
    public void EntregaPadrao_AplicaLimiteDeGratuidade(double subtotal, double esperado)
    {
        var entrega = new EntregaPadrao();

        Assert.Equal((decimal)esperado, entrega.CalcularTaxa((decimal)subtotal));
    }

    [Theory]
    [InlineData(50, 12)]
    [InlineData(100, 15)]
    [Trait("CP1Points", "5")]
    public void EntregaExpressa_AplicaPercentualComMinimo(double subtotal, double esperado)
    {
        var entrega = new EntregaExpressa();

        Assert.Equal((decimal)esperado, entrega.CalcularTaxa((decimal)subtotal));
    }
}
