namespace DeliveryRush.Services;

public sealed record IndicadoresPedidos(
    int Quantidade,
    decimal FaturamentoTotal,
    decimal? TicketMedio);
