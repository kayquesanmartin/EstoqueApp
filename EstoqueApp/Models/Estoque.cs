namespace EstoqueApp.Models;

public class Estoque
{
    private List<Produtos> Estoques { get; }
    
    int ultimoId = 1;

    public int GerarNovoId()
    {
        return ultimoId++;
    }
    
    public Estoque()
    {
        Estoques = new List<Produtos>
        {
            new Produtos(GerarNovoId(), "Apple", "iPhone 15", 7299.00, 260),
            new Produtos(GerarNovoId(), "Dell", "G15", 5197.00, 503),
            new Produtos(GerarNovoId(), "Philco", "Smart TV 32", 849.00, 26),
            new Produtos(GerarNovoId(), "Sony", "Playstation 5", 3533.00, 307),
            new Produtos(GerarNovoId(), "Microsoft", "Xbox Series X", 3984.00, 883)
        };
    }
    
    public bool EstoqueVazio => Estoques.Count == 0;

    public void AddProduto(int id, string marca, string nome, double preco, int unidades)
    {
        if (Estoques.Exists(produto => produto.Nome.ToLower() == nome.ToLower()))
        {
            Console.WriteLine($"Já possui o produto no estoque.\n");
        }
        else
        {
            Produtos novoProduto = new Produtos(id, marca, nome, preco, unidades);
            Estoques.Add(novoProduto);
            Console.WriteLine($"Produto {novoProduto.Nome} adicionado ao estoque.\n");
        }
    }
    
    // Adicionar opção para filtrar no estoque
    // Exibir descrição do produto?
    // Possuir estoque mínimo?
    // Possuir data de entrada e de saída dos itens
    public void ListarProdutos()
    {
        if (EstoqueVazio)
        {
            Console.WriteLine("Estoque vazio.");
        }
        else
        {
            foreach (var produtos in Estoques)
            {
                produtos.DetalhesProdutos();
            }
        }
    }
}