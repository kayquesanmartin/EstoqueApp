using EstoqueApp.Models;

namespace EstoqueApp.Menus;

public class MenuAddProduto : Menu
{
    public override void Executar(Estoque estoque)
    {
        base.Executar(estoque);
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

        estoque.AddProduto(estoque.GerarNovoId(), adicionarMarca, adicionarProduto, adicionarPreco,
            adicionarUnidades);

        Console.Write("Deseja adicionar outro produto? (s/n): ");
        string continuar = Console.ReadLine()!;
        if (continuar.ToLower() == "s") Console.WriteLine("Alguma coisa até arrumar"); //Chamar a classe adicionar produto novamente?;
        else Console.WriteLine("Alguma cois até arruamr."); // Chamar a função ou classe ExibirMenu();
    }
}