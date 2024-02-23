using EstoqueApp.Models;

namespace EstoqueApp.Menus;

// Corrigir a classe e implementar na program
public class MenuDetalhesProdutos : Menu
{
    // Fazer dessa classe para exibir os detalhes dos produtos.
    public void Executar(List<Produtos> detalhes)
    {
        Console.Clear();
        TituloMenu("Detalhes do Produto");
        Console.Write("Digite o ID do produto que deseja vizualizar: ");
        int id = int.Parse(Console.ReadLine()!);
        if (detalhes.Exists(produto => produto.Id == id))
        {
            Produtos produto = detalhes[id];
            Console.WriteLine($"\nA média da banda {id} é.");
            /*
             * ESPAÇO RESERVADO PARA COMPLETAR A FUNÇÃO
             */
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nA banda {id} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}