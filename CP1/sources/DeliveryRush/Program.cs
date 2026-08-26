using System.Globalization;
using DeliveryRush.Domain;
using DeliveryRush.Entregas;
using DeliveryRush.Repositories;
using DeliveryRush.Services;

CultureInfo.DefaultThreadCurrentCulture = CultureInfo.GetCultureInfo("pt-BR");

Console.Title = "CP1 - DeliveryRush";
EscreverTitulo("DELIVERY RUSH", "Acompanhamento visual da implementação");

var etapasPendentes = 0;
etapasPendentes += ExecutarEtapa("1. Regras de entrega", DemonstrarEntregas) ? 0 : 1;
etapasPendentes += ExecutarEtapa("2. Pedido e total", DemonstrarPedido) ? 0 : 1;
etapasPendentes += ExecutarEtapa("3. Repositório em memória", DemonstrarRepository) ? 0 : 1;
etapasPendentes += ExecutarEtapa("4. Consultas e indicadores", DemonstrarConsultas) ? 0 : 1;

Console.ForegroundColor = etapasPendentes == 0 ? ConsoleColor.Green : ConsoleColor.Cyan;
Console.WriteLine(
    etapasPendentes == 0
        ? "Todas as etapas foram executadas sem pendências."
        : $"Execução concluída com {etapasPendentes} etapa(s) pendente(s).");
Console.ResetColor();

static void DemonstrarEntregas()
{
    var padrao = new EntregaPadrao();
    var expressa = new EntregaExpressa();

    EscreverLinha("Padrão em R$ 79,99", FormatarMoeda(padrao.CalcularTaxa(79.99m)));
    EscreverLinha("Padrão em R$ 80,00", FormatarMoeda(padrao.CalcularTaxa(80m)));
    EscreverLinha("Expressa em R$ 50,00", FormatarMoeda(expressa.CalcularTaxa(50m)));
    EscreverLinha("Expressa em R$ 100,00", FormatarMoeda(expressa.CalcularTaxa(100m)));
}

static void DemonstrarPedido()
{
    var pedido = CriarPedido(101, "Ana", 48m, new EntregaPadrao());

    ExibirPedido(pedido);
}

static void DemonstrarRepository()
{
    IPedidoRepository repository = new InMemoryPedidoRepository();
    repository.Adicionar(CriarPedido(101, "Ana", 40m, new EntregaPadrao()));
    repository.Adicionar(CriarPedido(102, "Bruno", 100m, new EntregaExpressa()));

    var encontrado = repository.ObterPorNumero(102);

    EscreverLinha("Pedidos cadastrados", repository.ObterTodos().Count);
    EscreverLinha("Busca pelo número 102", encontrado?.Cliente ?? "Não encontrado");
    EscreverLinha("Busca pelo número 999", repository.ObterPorNumero(999)?.Cliente ?? "Não encontrado");
}

static void DemonstrarConsultas()
{
    var pedidos = new[]
    {
        CriarPedido(101, "Ana", 72m, new EntregaPadrao()),
        CriarPedido(102, "Bruno", 100m, new EntregaPadrao()),
        CriarPedido(103, "Carla", 120m, new EntregaExpressa()),
    };

    var filtrados = PedidoConsultaService.FiltrarPorTotal(pedidos, 100m);
    var indicadores = PedidoConsultaService.CalcularIndicadores(pedidos);

    Console.WriteLine("  Pedidos com total a partir de R$ 100,00:");
    foreach (var pedido in filtrados)
    {
        Console.WriteLine($"    #{pedido.Numero} | {pedido.Cliente,-10} | {pedido.Total,10:C2}");
    }

    Console.WriteLine();
    EscreverLinha("Quantidade total", indicadores.Quantidade);
    EscreverLinha("Faturamento total", FormatarMoeda(indicadores.FaturamentoTotal));
    EscreverLinha(
        "Ticket médio",
        indicadores.TicketMedio is decimal ticketMedio ? FormatarMoeda(ticketMedio) : "N/D");
}

static Pedido CriarPedido(
    int numero,
    string cliente,
    decimal subtotal,
    Entrega entrega)
    => new(numero, cliente, subtotal, entrega);

static void ExibirPedido(Pedido pedido)
{
    EscreverLinha("Pedido", $"#{pedido.Numero}");
    EscreverLinha("Cliente", pedido.Cliente);
    EscreverLinha("Subtotal", FormatarMoeda(pedido.Subtotal));
    EscreverLinha("Taxa de entrega", FormatarMoeda(pedido.TaxaEntrega));
    EscreverLinha("Total", FormatarMoeda(pedido.Total));
}

static bool ExecutarEtapa(string titulo, Action demonstracao)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine($"[{titulo}]");
    Console.ResetColor();

    try
    {
        demonstracao();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("  STATUS: executada sem pendências.");
        return true;
    }
    catch (NotImplementedException)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("  STATUS: existe um TODO pendente nesta etapa.");
        return false;
    }
    finally
    {
        Console.ResetColor();
        Console.WriteLine(new string('-', 64));
        Console.WriteLine();
    }
}

static void EscreverTitulo(string titulo, string subtitulo)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine(new string('=', 64));
    Console.WriteLine($"{titulo,-64}");
    Console.WriteLine(new string('=', 64));
    Console.ResetColor();
    Console.WriteLine(subtitulo);
    Console.WriteLine();
}

static void EscreverLinha(string rotulo, object valor) =>
    Console.WriteLine($"  {rotulo,-28} {valor}");

static string FormatarMoeda(decimal valor) =>
    valor.ToString("C2", CultureInfo.GetCultureInfo("pt-BR"));
