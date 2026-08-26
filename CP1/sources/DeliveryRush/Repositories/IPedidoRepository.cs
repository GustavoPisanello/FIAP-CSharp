using DeliveryRush.Domain;

namespace DeliveryRush.Repositories;

public interface IPedidoRepository
{
    void Adicionar(Pedido pedido);

    Pedido? ObterPorNumero(int numero);

    IReadOnlyList<Pedido> ObterTodos();
}
