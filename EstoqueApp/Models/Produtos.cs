namespace EstoqueApp.Models;

public class Produtos
{
    public Produtos(int id, string marca, string nome, double preco, int unidades)
    {
        Id = id;
        Marca = marca;
        Nome = nome;
        Preco = preco;
        Unidades = unidades;
    }

    private double preco;

    private int unidades;

    public int Id { get; }

    public string Nome { get; }

    public string Marca { get; }

    public double Preco
    {
        get => preco;
        set
        {
            if (value > 0)
                preco = value;
            else
                preco = 10;
        }
    }

    public int Unidades
    {
        get => unidades;
        set
        {
            if (value > 0)
                unidades = value;
            else
                unidades = 10;

        }
    }

    public void DetalhesProdutos()
    {
        Console.WriteLine($"{Id, -3} [{Marca, -10}] {Nome, -15} | R$ {Preco, 8} | Estoque: {Unidades, 4}");
    }
}