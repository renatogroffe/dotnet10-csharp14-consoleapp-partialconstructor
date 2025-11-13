namespace ConsoleAppPartialConstructor.Models;

public partial class Veiculo
{
    public partial Veiculo(string descritivo, int ano)
    {
        Descritivo = descritivo;
        Ano = ano;
    }
    
    public string Descritivo { get; set; }
    public int Ano { get; set; }
}