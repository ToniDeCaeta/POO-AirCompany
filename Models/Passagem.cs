namespace MapaCompanhiaAerea.Passagem;
using MapaCompanhiaAerea.Voo;
public class Passagem
{
    private Voo Voo;
    private string NomePassageiro;
    private double Preco;

    public Passagem (Voo voo, string nomePassageiro, double preco)
    {
        Voo = voo;
        NomePassageiro = nomePassageiro;
        Preco = preco;
    }

    public double CalcularPrecoTotal ()
    {
        double taxaEmbarque = 50.0;
        return Preco + taxaEmbarque;
    }
    public string GetNomePassageiro ()
    {
        return NomePassageiro;
    }
}
