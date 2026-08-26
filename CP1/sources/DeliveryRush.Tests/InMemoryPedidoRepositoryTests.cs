using DeliveryRush.Repositories;

namespace DeliveryRush.Tests;

public sealed class InMemoryPedidoRepositoryTests
{
    [Fact]
    [Trait("CP1Points", "5")]
    public void Adicionar_EObterPorNumero_RetornaMesmoPedido()
    {
        var repository = new InMemoryPedidoRepository();
        var pedido = TestSupport.CriarPedido(10, 20m);

        repository.Adicionar(pedido);

        Assert.Same(pedido, repository.ObterPorNumero(10));
    }

    [Fact]
    [Trait("CP1Points", "5")]
    public void Adicionar_NumeroDuplicado_LancaSemSubstituir()
    {
        var repository = new InMemoryPedidoRepository();
        var original = TestSupport.CriarPedido(10, 20m);
        repository.Adicionar(original);

        Assert.Throws<InvalidOperationException>(
            () => repository.Adicionar(TestSupport.CriarPedido(10, 30m)));
        Assert.Same(original, repository.ObterPorNumero(10));
    }
}
