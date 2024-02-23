namespace EstoqueApp.Menus;

public class Menu
{
    public void TituloMenu(string titulo)
    {
        int quantidadeLetra = titulo.Length;
        string asterisco = string.Empty.PadLeft(quantidadeLetra, '*');
        Console.WriteLine($"{asterisco}\n" +
                          $"{titulo}\n" +
                          $"{asterisco}\n");
    }
}