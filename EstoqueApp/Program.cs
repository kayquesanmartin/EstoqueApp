using EstoqueApp.Menus;
using EstoqueApp.Models;

Estoque estoque = new Estoque();

List<Produtos> detalhesProdutos = new();

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuConsultaEstoque());
opcoes.Add(2, new MenuAddProduto());
opcoes.Add(3, new MenuSair());

void ExibirMenu()
{
    Console.Clear();
    TituloMenu("Controle de Estoque");

    Console.WriteLine($"[ 1 ] Visualizar Estoque\n" +
                      $"[ 2 ] Adicionar Produto\n" +
                      $"[ 3 ] Sair\n");

    Console.Write("Pressione a opção desejada: ");
    var opicaoEscolhidaNumerica = int.Parse(Console.ReadLine()!);

    if (opcoes.ContainsKey(opicaoEscolhidaNumerica))
    {
        Menu menuASerExibido = opcoes[opicaoEscolhidaNumerica];
        menuASerExibido.Executar(estoque);
        if(opicaoEscolhidaNumerica > 0) ExibirMenu();
    }
    else
    {
        Console.WriteLine("Opção Inválida...");
    }
}

void TituloMenu(string titulo)
{
    int quantidadeLetra = titulo.Length;
    string asterisco = string.Empty.PadLeft(quantidadeLetra, '*');
    Console.WriteLine($"{asterisco}\n" +
                      $"{titulo}\n" +
                      $"{asterisco}\n");
}

ExibirMenu();