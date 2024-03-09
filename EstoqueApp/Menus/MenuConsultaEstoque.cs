using EstoqueApp.Models;

namespace EstoqueApp.Menus;

public class MenuConsultaEstoque : Menu
{
    public override void Executar(Estoque estoque)
    {
        Console.Clear(); 
        TituloMenu("Produtos em Estoque");

        Console.WriteLine("{0,-6} {1,-8} {2,10} {3,17} {4, 13}", "ID", "Marca", "Nome", "Preço", "Estoque");
        Console.WriteLine(new string('-', 70));

        estoque.ListarProdutos();

        Console.Write("\nPressione Enter para retornar ao Menu...");

        Console.ReadKey();
    }
}