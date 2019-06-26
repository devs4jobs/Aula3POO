using System;
using System.Collections.Generic;

namespace Aula03Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string retorno = "";
            int i = 0;
            string escolher = "";

            do
            {
            
            List<Carro> carros = new List<Carro>();
            List<Moto> motos1 = new List<Moto>();

            for (i = 0; i < 3; i++)
            {
                try
                {
                    Carro carro = new Carro();

                    Console.WriteLine("Digite a marca do carro: ");
                    carro.Marca = Console.ReadLine();

                    Console.WriteLine("Digite o modelo do carro: ");
                    carro.Modelo = Console.ReadLine();

                    Console.WriteLine("digite o pais de origem do carro: ");
                    carro.PaisDeOrigem = Console.ReadLine();

                    Console.WriteLine("O carro é flex ? sim ou nao");
                    retorno = Console.ReadLine();

                    if (retorno == "SIM" || retorno == "sim")
                    {
                        carro.Flex = true;
                    }
                    else
                        carro.Flex = false;

                    Console.WriteLine("Qual é a capacidade do tanque?");
                    carro.QntTanqueCombustivel = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Quantos litros tem no tanque?");
                    carro.QntTanqueAtual = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("QUantos KM/L o carro faz? ");
                    carro.KmPorLitro = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("quantos cavalos de potencia o carro possui ?");
                    carro.Cavalos = int.Parse(Console.ReadLine());

                    Console.WriteLine("o filtro de combustivel está entupido?");
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

                    Console.WriteLine("Digite a marca da moto: ");
                    moto.Marca = Console.ReadLine();

                    Console.WriteLine("digite o modelo da moto: ");
                    moto.Modelo = Console.ReadLine();

                    Console.WriteLine("Digite o pais de origem da moto : ");
                    moto.PaisDeOrigem = Console.ReadLine();

                    Console.WriteLine("A Moto é flex? sim ou não");
                    retorno = Console.ReadLine();

                    if (retorno == "SIM" || retorno == "sim")
                    {
                        moto.Flex = true;
                    }
                    else
                        moto.Flex = false;

                    Console.WriteLine("Qual é a capacidade do tanque??");
                    moto.QntTanqueCombustivel = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Quantos litros tem no tanque");
                    moto.QntTanqueAtual = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Quantos KM/L a moto faz? ");
                    moto.KmPorLitro = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("quantas cilindradas a moto tem?");
                    moto.Cilindradas = int.Parse(Console.ReadLine());

                    Console.WriteLine("o filtro de combustivel está entupido?");
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


            Console.WriteLine("Digite a quilometragem total da viagem ");
            decimal viagem = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("O clima está bom ou ruim?");
            string clima = Console.ReadLine().ToUpper();

            Console.Write("A viagem começará primeiro com os carros e em seguida irá para as motos");

            for (i = 0; i < 3; i++)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine($"MARCA:{carros[i].Marca} \n MODELO: {carros[i].Modelo} \nPAIS DE ORIGEM: {carros[i].PaisDeOrigem} \n FLEX: {carros[i].Flex} \n QUANTIDADE DE COMBUSTIVEL ATUAL: {carros[i].QntTanqueAtual} \n QUANTIDADE DE COMBUSTIVEL TOTAL SUPORTADA: {carros[i].QntTanqueCombustivel} \n POTENCIA: {carros[i].Cavalos} ");

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

                Console.WriteLine($"O carro chegou{carros[i].Modelo}, digite enter para a próxima viagem.");
                Console.ReadLine();
            }

            for (i = 0; i < 2; i++)
            {
                do
                {
                    Console.Clear();

                    Console.WriteLine($"MARCA: {motos1[i].Marca} \n MODELO: {motos1[i].Modelo} \n PAIS DE ORIGEM: {motos1[i].PaisDeOrigem} \n FLEX: {motos1[i].Flex} \nQUANTIDADE DE COMBUSTIVEL ATUAL: {motos1[i].QntTanqueAtual} \nQUANTIDADE DE COMBUSTIVEL TOTAL SUPORTADA:{motos1[i].QntTanqueCombustivel} \n POTENCIA: {motos1[i].Cilindradas} ");

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
                Console.WriteLine("As motos chegaram no seu destino.");

                }
                Console.WriteLine("Deseja viajar novamente? Sim ou Nao");
                escolher = Console.ReadLine().ToUpper();

            } while (escolher == "SIM");
        }   
    }
}








