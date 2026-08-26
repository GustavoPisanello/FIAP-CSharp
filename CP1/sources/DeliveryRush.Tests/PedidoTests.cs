using DeliveryRush.Domain;
using DeliveryRush.Entregas;

namespace DeliveryRush.Tests;

public sealed class PedidoTests
{
    [Fact]
    [Trait("CP1Points", "10")]
    public void Construtor_ValoresValidos_NormalizaEInicializaPedido()
    {
        var pedido = new Pedido(10, "  Ana  ", 48m, new EntregaPadrao());

        Assert.Equal(10, pedido.Numero);
        Assert.Equal("Ana", pedido.Cliente);
        Assert.Equal(48m, pedido.Subtotal);
    }

    [Fact]
    [Trait("CP1Points", "10")]
    public void Calculos_DuasEntregas_UsamPolimorfismo()
    {
        var padrao = new Pedido(10, "Ana", 48m, new EntregaPadrao());
        var expressa = new Pedido(20, "Bia", 100m, new EntregaExpressa());

        Assert.Equal(8m, padrao.TaxaEntrega);
        Assert.Equal(56m, padrao.Total);
        Assert.Equal(15m, expressa.TaxaEntrega);
        Assert.Equal(115m, expressa.Total);
    }
}
