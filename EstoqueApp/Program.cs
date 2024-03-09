using EstoqueApp.Menus;
using EstoqueApp.Models;

var estoque = new Estoque();

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuConsultaEstoque());
opcoes.Add(2, new MenuAddProduto());
opcoes.Add(3, new MenuSair());

void ExibirMenu()
{
    Console.Clear();
    Console.WriteLine("Controle de Estoque");

    Console.WriteLine($"[ 1 ] Visualizar Estoque\n" +
                      $"[ 2 ] Adicionar Produto\n" +
                      $"[ 3 ] Sair\n");

    Console.Write("Digite a opção desejada: ");
    var opcaoEscolhidaNumerica = int.Parse(Console.ReadLine()!);

    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];
        menuASerExibido.Executar(estoque);
        if(opcaoEscolhidaNumerica != 3) ExibirMenu();
    }
    else
    {
        Console.WriteLine("Opção Inválida...");
    }
}

ExibirMenu();