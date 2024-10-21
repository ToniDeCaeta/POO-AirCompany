namespace MapaCompanhiaAerea.CompanhiaAerea;

using System;
using MapaCompanhiaAerea.Voo;

public class CompanhiaAerea
{
    private string Nome; //por serem privadas, serão manipuladas apenas dentro da propria Classe
    private List<Voo> Voos;

    public CompanhiaAerea(string nome)
    {
        Nome = nome;
        Voos = new List<Voo>(); // Cria uma lista vazia. 
    }

    public void AdicionarVoo( Voo voo)
    {
        Voos.Add(voo); 
    }

    public string GetNome ()
    {
        return Nome;
    }

    public List<Voo> GetVoos ()
    {
        return Voos;
    }

    internal void AdicionarVoo()
    {
        throw new NotImplementedException();
    }
}
