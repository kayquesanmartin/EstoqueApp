using EstoqueApp.Menus;
using EstoqueApp.Models;

Estoque estoque = new Estoque();

const int VISUALIZAR_ESTOQUE = 1;
const int ADICIONAR_PRODUTO = 2;
const int DETALHES_PRODUTOS = 3;
const int SAIR = 4;

void Menu()
{
    Console.Clear();
    TituloMenu("Controle de Estoque");

    Console.WriteLine($"[ {VISUALIZAR_ESTOQUE} ] Visualizar Estoque\n" +
                      $"[ {ADICIONAR_PRODUTO} ] Adicionar Produto\n" +
                      $"[ {DETALHES_PRODUTOS} ] Detalhes dos Produtos\n" +
                      $"[ {SAIR} ] Sair\n");

    Console.Write("Pressione a opção desejada: ");
    var option = int.Parse(Console.ReadLine()!);

    switch (option)
    {
        case VISUALIZAR_ESTOQUE:
            ConsultaEstoque();
            break;
        case ADICIONAR_PRODUTO:
            AdicionarProduto();
            break;
        case DETALHES_PRODUTOS:
            MenuDetalhesProdutos menu = new MenuDetalhesProdutos();
            //menu.Executar();
            Menu();
            break;
        case SAIR:
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine("Opção Inválida...");
            break;
    }
}

// Transformar em classe
void ConsultaEstoque()
{
    Console.Clear(); 
    TituloMenu("Produtos em Estoque");

    Console.WriteLine("{0,-6} {1,-8} {2,10} {3,17} {4, 13}", "ID", "Marca", "Nome", "Preço", "Estoque");
    Console.WriteLine(new string('-', 70));

    estoque.ListarProdutos();

    Console.Write("\nPressione Enter para retornar ao Menu...");

    Console.ReadKey();

    Menu();
}

// Transformar em classe
void AdicionarProduto()
{
    while (true)
    {
        Console.Clear();
        TituloMenu("Adicionando Novo Produto");
        // Verificar enquanto é digitado os valores e pedir para digitar novamente.
        // Validar linha por linha
        Console.Write("Marca: ");
        string adicionarMarca = Console.ReadLine()!;
        Console.Write("Produto: ");
        string adicionarProduto = Console.ReadLine()!;
        Console.Write("Preço: ");
        double adicionarPreco = double.Parse(Console.ReadLine()!);
        Console.Write("Unidades: ");
        int adicionarUnidades = int.Parse(Console.ReadLine()!);
        
        estoque.AdicionarProduto(estoque.GerarNovoId(), adicionarMarca, adicionarProduto, adicionarPreco, adicionarUnidades);
        
        Console.Write("Deseja adicionar outro produto? (s/n): ");
        string continuar = Console.ReadLine()!;
        if (continuar.ToLower() == "s")
        {
            AdicionarProduto();
            break;
        }
        Menu();
        break;
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

Menu();