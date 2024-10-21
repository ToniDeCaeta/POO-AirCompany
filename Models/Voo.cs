namespace MapaCompanhiaAerea.Voo;

public class Voo
{
    private string Codigo { get; set; }
    private int TotalAssentos { get; set; }
    private int AssentosOcupados { get; set; }

    private Aeroporto.Aeroporto AeroportoOrigem;
    private Aeroporto.Aeroporto AeroportoDestino;



    public Voo (string codigo, int totalAssentos, Aeroporto.Aeroporto aeroportoOrigem, Aeroporto.Aeroporto aeroportoDestino) 
    {
        Codigo = codigo;
        TotalAssentos = totalAssentos;
        AssentosOcupados = 0;
        AeroportoOrigem = aeroportoOrigem;
        AeroportoDestino = aeroportoDestino;

    }

    public Voo ()
    {

    }

    public void reservarAssento()
    {
        if (AssentosOcupados < TotalAssentos)
        {
            AssentosOcupados++;
        }
        else 
        {
            throw new Exception ("O voo não possui assentos disponíveis para reserva");
        }
    }

    public int GetAssentosDisponiveis()
    {
        
        return TotalAssentos - AssentosOcupados; 
    }

    public string GetCodigo ()
    {
        return Codigo;
    }


    public Aeroporto.Aeroporto GetAeroportoOrigem()
        {
            return AeroportoOrigem;
        }

        public Aeroporto.Aeroporto GetAeroportoDestino()
        {
            return AeroportoDestino;
        }
    
}
