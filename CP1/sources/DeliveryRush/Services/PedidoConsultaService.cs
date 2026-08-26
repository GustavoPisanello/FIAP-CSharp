using DeliveryRush.Domain;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DeliveryRush.Services;

public static class PedidoConsultaService
{
    public static IReadOnlyList<PedidoResumo> FiltrarPorTotal(
        IEnumerable<Pedido> pedidos,
        decimal totalMinimo)
    {
        if (totalMinimo < 0) throw new ArgumentOutOfRangeException(nameof(totalMinimo), totalMinimo, "O total mínimo não pode ser negativo.");
        if (pedidos == null) throw new ArgumentOutOfRangeException("A lista de pedidos não pode ser nula.");

        return pedidos
            .Where(pedido => pedido.Total >= totalMinimo)
            .OrderByDescending(pedido => pedido.Total)
            .ThenBy(pedido => pedido.Numero)
            .Select(pedido => new PedidoResumo(
                pedido.Numero,
                pedido.Cliente,
                pedido.Total))
            .ToList();
    }

    public static IndicadoresPedidos CalcularIndicadores(IEnumerable<Pedido> pedidos)
    {
        // TODO CP1-10: calcule quantidade, faturamento e ticket médio.
        throw new NotImplementedException();
    }
}
