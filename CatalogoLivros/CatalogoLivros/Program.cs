namespace CatalogoLivros;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("==== Catálogo Livros ====");

        var colecaoLivros = new List<Livro>();

        bool devoContinuar = true;

        while (devoContinuar)
        {
            Console.WriteLine(@"
Por favor, selecione uma opção:
1. Cadastrar
2. Listar
3. Sair
");

            string? entradaUsuario = Console.ReadLine();

            if (!int.TryParse(entradaUsuario, out int opcaoSelecionada))
            {
                Console.WriteLine("Opção Inválida. Selecione novamente.");
                continue;
            }

            var ListaRecursos = new List<Recurso>();

            switch (opcaoSelecionada)
            {
                case 0:
                    devoContinuar = false;
                    break;
                case 1:
                    Console.WriteLine(CadastrarRecurso(ListaRecursos));
                    break;
                case 2:
                    // Listar Livros
                    break;
                case 3:
                    return;
                default:
                    Console.WriteLine("Opção inválida. Digite um número de 1 à 3");
                    continue;

            }

        }
    }
    public static string CadastrarRecurso(List<Recurso> ListaRecurso)
    {
        Console.WriteLine("Digite o nome do recurso: ");
        string NomeRecurso = Console.ReadLine() ?? string.Empty;

        Console.WriteLine("Digite o tipo do recurso: ");
        string TipoRecurso = Console.ReadLine() ?? string.Empty;

        if (!(NomeRecurso.Trim() == string.Empty || TipoRecurso.Trim() == string.Empty))
        {  
            Recurso recurso = new Recurso();
            recurso.Id = ListaRecurso.Count;
            recurso.Nome = NomeRecurso;
            recurso.Tipo = TipoRecurso;

            ListaRecurso.Add(recurso);
            return "Recurso adicionado com sucesso!";
        }

        return "Dados inválidos";

    }

}
