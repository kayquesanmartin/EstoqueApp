using EstoqueApp.Models;

namespace EstoqueApp.Menus;

public class MenuSair : Menu
{
    public override void Executar(Estoque estoque)
    {
        Console.WriteLine("Saindo...");
    }
}