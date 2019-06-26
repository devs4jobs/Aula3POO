using System;
using System.Collections.Generic;

namespace Aula03Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string retorno = "",  escolher = "";
            int i = 0;
            decimal viagem = 0;

            do
            {   // Criacação das lists
                List<Carro> carros = new List<Carro>();
                List<Moto> motos1 = new List<Moto>();

                for (i = 0; i < 3; i++)
                {
                    try
                    { // Coletando dados do usuario
                        Carro carro = new Carro();

                        Console.WriteLine("Digite a marca do carro:\n  ");
                        carro.Marca = Console.ReadLine();

                        Console.WriteLine("Digite o modelo do carro:\n  ");
                        carro.Modelo = Console.ReadLine();

                        Console.WriteLine("digite o pais de origem do carro:\n  ");
                        carro.PaisDeOrigem = Console.ReadLine();

                        Console.WriteLine("O carro é flex ? sim ou nao\n ");
                        retorno = Console.ReadLine();

                        if (retorno == "SIM" || retorno == "sim")
                        {
                            carro.Flex = true;
                        }
                        else
                            carro.Flex = false;

                        Console.WriteLine("Qual é a capacidade do tanque?\n");
                        carro.QntTanqueCombustivel = decimal.Parse(Console.ReadLine());

                        Console.WriteLine("Quantos litros tem no tanque?\n");
                        carro.QntTanqueAtual = decimal.Parse(Console.ReadLine());

                        Console.WriteLine("QUantos KM/L o carro faz?\n ");
                        carro.KmPorLitro = decimal.Parse(Console.ReadLine());

                        Console.WriteLine("quantos cavalos de potencia o carro possui ?\n");
                        carro.Cavalos = int.Parse(Console.ReadLine());

                        // pergunta do filtro e print do carro cadastrado
                        Console.WriteLine("o filtro de combustivel está entupido?\n");
                        string filtro = Console.ReadLine();

                        if (filtro.ToString().ToUpper() == "SIM") { carro.FiltroCombustivelEntupido = true; }
                        else
                            carro.FiltroCombustivelEntupido = false;

                        carros.Add(carro);
                        Console.WriteLine($"MARCA:{carros[i].Marca} \n MODELO: {carros[i].Modelo} \nPAIS DE ORIGEM: {carros[i].PaisDeOrigem} \n FLEX: {carros[i].Flex} \n QUANTIDADE DE COMBUSTIVEL ATUAL: {carros[i].QntTanqueAtual} \n QUANTIDADE DE COMBUSTIVEL TOTAL SUPORTADA: {carros[i].QntTanqueCombustivel} \n POTENCIA: {carros[i].Cavalos} ");
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Erro, insira um valor compativel.");
                        i--;
                    }
                }

                for (i = 0; i < 2; i++)
                {

                    try
                    {
                        Moto moto = new Moto();

                        Console.WriteLine("Digite a marca da moto:\n ");
                        moto.Marca = Console.ReadLine();

                        Console.WriteLine("digite o modelo da moto:\n");
                        moto.Modelo = Console.ReadLine();

                        Console.WriteLine("Digite o pais de origem da moto \n: ");
                        moto.PaisDeOrigem = Console.ReadLine();

                        Console.WriteLine("A Moto é flex? sim ou não\n");
                        retorno = Console.ReadLine();

                        if (retorno == "SIM" || retorno == "sim")
                        {
                            moto.Flex = true;
                        }
                        else
                            moto.Flex = false;

                        Console.WriteLine("Qual é a capacidade do tanque??\n");
                        moto.QntTanqueCombustivel = decimal.Parse(Console.ReadLine());

                        Console.WriteLine("Quantos litros tem no tanque\n");
                        moto.QntTanqueAtual = decimal.Parse(Console.ReadLine());

                        Console.WriteLine("Quantos KM/L a moto faz?\n ");
                        moto.KmPorLitro = decimal.Parse(Console.ReadLine());

                        Console.WriteLine("quantas cilindradas a moto tem?\n");
                        moto.Cilindradas = int.Parse(Console.ReadLine());

                        // pergunta do filtro e print da carro cadastrado
                        Console.WriteLine("o filtro de combustivel está entupido?\n");
                        string filtro2 = Console.ReadLine();

                        if (filtro2.ToString().ToUpper() == "SIM") { moto.FiltroCombustivelEntupido = true; }
                        else
                            moto.FiltroCombustivelEntupido = false;
                        motos1.Add(moto);
                        Console.WriteLine($"MARCA: {motos1[i].Marca} \n MODELO: {motos1[i].Modelo} \n PAIS DE ORIGEM: {motos1[i].PaisDeOrigem} \n FLEX: {motos1[i].Flex} \nQUANTIDADE DE COMBUSTIVEL ATUAL: {motos1[i].QntTanqueAtual} \nQUANTIDADE DE COMBUSTIVEL TOTAL SUPORTADA:{motos1[i].QntTanqueCombustivel} \n POTENCIA: {motos1[i].Cilindradas} ");

                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Erro, insira um valor compativel.");
                        i--;
                    }
                }
                // perguntando das viagens e do clima 
                Console.WriteLine("Digite a quilometragem total da viagem \n");
                viagem = Convert.ToDecimal(Console.ReadLine());
                while ( viagem < 0)
                {
                    Console.WriteLine("Numeros invalidos, tente novamente\n");
                    viagem = Convert.ToDecimal(Console.ReadLine());
                }

                Console.WriteLine("O clima está bom ou ruim?\n");
                string clima = Console.ReadLine().ToUpper();

                // viagem dos carros e motos
                Console.Write("A viagem começará primeiro com os carros e em seguida irá para as motos\n");

                for (i = 0; i < 3; i++)
                {
                    do
                    {
               
                        Console.WriteLine($"MARCA:{carros[i].Marca}\nMODELO:{carros[i].Modelo}\nPAIS DE ORIGEM:{carros[i].PaisDeOrigem}\nFLEX:{carros[i].Flex}\nQUANTIDADE DE COMBUSTIVEL ATUAL:{carros[i].QntTanqueAtual}\nQUANTIDADE DE COMBUSTIVEL TOTAL SUPORTADA:{carros[i].QntTanqueCombustivel}\nPOTENCIA:{carros[i].Cavalos} ");

                        Console.WriteLine("Digite 1 para dirigir\nDigite 2 para abastecer\nDigite 3 para exibir a quantidade de combustível atual");
                        string opcao = Console.ReadLine();

                        switch (opcao)
                        {
                            case "1": { Console.WriteLine("Por quantos km's deseja dirigir ?"); carros[i].Dirigir(Convert.ToDecimal(Console.ReadLine()), clima); break; }
                            case "2": { Console.WriteLine("Quantos litros deseja abastecer ?"); carros[i].Abastecer(Convert.ToDecimal(Console.ReadLine())); break; }
                            case "3": { Console.WriteLine("Quantidade do tanque atual:"); Console.WriteLine($"{Math.Round(carros[i].QntTanqueAtual, 2)} litros \n"); break; }

                            default:
                                break;
                        }

                    } while (viagem > carros[i].viajar);

                    Console.WriteLine($"O carro {carros[i].Modelo} chegou, digite enter para a próxima viagem.\n");
                    Console.ReadLine();
                }

                for (i = 0; i < 2; i++)
                {
                    do
                    {
   
                        Console.WriteLine($"\nMARCA: {motos1[i].Marca}\nMODELO: {motos1[i].Modelo}\nPAIS DE ORIGEM: {motos1[i].PaisDeOrigem}\nFLEX: {motos1[i].Flex}\nQUANTIDADE DE COMBUSTIVEL ATUAL: {motos1[i].QntTanqueAtual}\nQUANTIDADE DE COMBUSTIVEL TOTAL SUPORTADA:{motos1[i].QntTanqueCombustivel}\nPOTENCIA: {motos1[i].Cilindradas} ");

                        Console.WriteLine("Digite 1 para dirigir\nDigite 2 para abastecer\nDigite 3 para exibir a quantidade de combustível atual");
                        string opcao = Console.ReadLine();

                        switch (opcao)
                        {
                            case "1": { Console.WriteLine("Por quantos km's deseja dirigir ?"); motos1[i].Dirigir(Convert.ToDecimal(Console.ReadLine()), clima); break; }
                            case "2": { Console.WriteLine("Quantos litros deseja abastecer ?"); motos1[i].Abastecer(Convert.ToDecimal(Console.ReadLine())); break; }
                            case "3": { Console.WriteLine("Quantidade do tanque atual:"); Console.WriteLine($"{Math.Round(motos1[i].QntTanqueAtual, 2)} litros \n"); break; }

                            default:
                                break;
                        }

                    } while (viagem > motos1[i].viajar);

                    Console.WriteLine($"A moto {motos1[i].Modelo} chegou, digite enter para a próxima viagem.");
                    Console.ReadLine();
                }
                Console.WriteLine("As motos chegaram no seu destino.");

                Console.WriteLine("Deseja viajar novamente? Sim ou Nao");
                escolher = Console.ReadLine().ToUpper();

            } while (escolher == "SIM");
        }
    }
}








