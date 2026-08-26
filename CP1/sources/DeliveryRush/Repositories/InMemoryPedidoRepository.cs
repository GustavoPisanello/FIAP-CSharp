using DeliveryRush.Domain;
using DeliveryRush.Entregas;

namespace DeliveryRush.Repositories;

public sealed class InMemoryPedidoRepository : IPedidoRepository
{
    private readonly Dictionary<int, Pedido> _pedidos = [];

    public void Adicionar(Pedido pedido)
    {
        if (pedido == null) throw new ArgumentNullException(nameof(pedido), "O pedido é obrigatório");
        if (_pedidos.ContainsKey(pedido.Numero)) throw new InvalidOperationException($"O pedido com o número {pedido.Numero} já existe.");

        _pedidos.Add(pedido.Numero, pedido);

    }

    public Pedido? ObterPorNumero(int numero)
    {
        if (numero < 0) throw new ArgumentOutOfRangeException(nameof(numero), numero, "O número não pode ser negativo.");
        _pedidos.TryGetValue(numero, out var pedido);
        return pedido ?? null;
    }

    public IReadOnlyList<Pedido> ObterTodos()
    {
        return _pedidos.Values.ToArray();
    }
}
