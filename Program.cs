using System;
using MapaCompanhiaAerea.CompanhiaAerea;
using MapaCompanhiaAerea.Passagem;
using MapaCompanhiaAerea.Voo;
using MapaCompanhiaAerea.Aeroporto;


  
        // Criar aeroportos
        Aeroporto aeroportoOrigem = new Aeroporto("Aeroporto Internacional A", "Cidade A", "AAA");
        Aeroporto aeroportoDestino = new Aeroporto("Aeroporto Internacional B", "Cidade B", "BBB");


    

        // Criar uma companhia aérea
        CompanhiaAerea companhia = new CompanhiaAerea("Companhia Aérea Exemplo");




        // Criar um voo utilizando os aeroportos de origem e destino
        Voo voo = new Voo("Voo123", 5, aeroportoOrigem, aeroportoDestino);




        // Adicionar o voo à companhia aérea
        companhia.AdicionarVoo(voo);



        // Testar a reserva de assentos
        try
        {
            for (int i = 0; i < 6; i++) // Tentativa de reservar 6 assentos
            {
                voo.reservarAssento();
                Console.WriteLine($"Assento reservado. Total de assentos ocupados: {voo.GetAssentosDisponiveis()}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message); // Exibir mensagem de erro se a reserva falhar
        }




        // Criar uma passagem
        Passagem passagem = new Passagem(voo, "João Silva", 200.0);
        Console.WriteLine($"Nome do passageiro: {passagem.GetNomePassageiro()}");
        Console.WriteLine($"Preço total da passagem (com taxa): {passagem.CalcularPrecoTotal()}");




        // Exibir detalhes do voo
        Console.WriteLine($"Código do Voo: {voo.GetCodigo()}");
        Console.WriteLine($"Assentos disponíveis: {voo.GetAssentosDisponiveis()}");
        Console.WriteLine($"Aeroporto de Origem: {voo.GetAeroportoOrigem().GetNome()}, {voo.GetAeroportoOrigem().GetCidade()}, {voo.GetAeroportoOrigem().GetCodigoIATA()}");
        Console.WriteLine($"Aeroporto de Destino: {voo.GetAeroportoDestino().GetNome()}, {voo.GetAeroportoDestino().GetCidade()}, {voo.GetAeroportoDestino().GetCodigoIATA()}");
    

