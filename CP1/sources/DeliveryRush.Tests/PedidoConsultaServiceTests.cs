using DeliveryRush.Domain;
using DeliveryRush.Entregas;
using DeliveryRush.Services;

namespace DeliveryRush.Tests;

public sealed class PedidoConsultaServiceTests
{
    [Fact]
    [Trait("CP1Points", "12")]
    public void FiltrarPorTotal_FiltraOrdenaDesempataERetornaResumos()
    {
        var pedidos = new[]
        {
            TestSupport.CriarPedido(30, 120m),
            TestSupport.CriarPedido(20, 100m, new EntregaPadrao()),
            TestSupport.CriarPedido(10, 100m),
            TestSupport.CriarPedido(40, 10m),
        };

        var resultado = PedidoConsultaService.FiltrarPorTotal(pedidos, 100m);

        Assert.Equal([30, 10, 20], resultado.Select(item => item.Numero));
        Assert.All(resultado, item => Assert.True(item.Total >= 100m));
    }

    [Fact]
    [Trait("CP1Points", "8")]
    public void CalcularIndicadores_ColecaoConhecida_RetornaValoresCorretos()
    {
        Pedido[] pedidos =
        [
            TestSupport.CriarPedido(10, 72m),
            TestSupport.CriarPedido(20, 100m),
        ];

        var indicadores = PedidoConsultaService.CalcularIndicadores(pedidos);

        Assert.Equal(2, indicadores.Quantidade);
        Assert.Equal(180m, indicadores.FaturamentoTotal);
        Assert.Equal(90m, indicadores.TicketMedio);
    }
}
