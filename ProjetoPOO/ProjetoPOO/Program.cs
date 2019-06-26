using System;
using System.Collections.Generic;

namespace ProjetoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //LISTAS DOS OBJETOS CARROS e MOTOS
            List<Carro> carros1 = new List<Carro>();
            List<Moto> motos = new List<Moto>();


            //CADASTRO CARROS !!
            //            for (int i = 0; i < 3; i++)
            //            {
            Carro carro = new Carro();

            Console.WriteLine("\nDigite o Modelo do Veiculo Ex: Corolla");
            carro.Modelo = Console.ReadLine();


            Console.WriteLine("\nDigite a Marca do Carro Ex: Toyota");
            carro.Marca = Console.ReadLine();


            Console.WriteLine("\nDigite o Pais de Origem do Carro Ex: China");
            carro.PaisDeOrigem = Console.ReadLine();


            Console.WriteLine("\nDigite a Quantidade atual de Litros no Tanque: Ex : 10");
            carro.QntTanqueAtual = Convert.ToDecimal(Console.ReadLine());


            Console.WriteLine("\nDigite se o Veiculo é Flex : Ex : Sim ou Não !!");
            string flex1 = Console.ReadLine().ToUpper().Replace("Ã", "A");


            //                if (flex1 == "SIM")
            //                    carro.Flex = true;
            //                else if (flex1 == "NAO")
            //                    carro.Flex = false;

            Console.WriteLine("\nDigite a Quantidade de Litros que o Tanque Comporta Ex : 50");
            carro.QntTanqueCombustivel = Convert.ToDecimal(Console.ReadLine());


            Console.WriteLine("\nDigite a Potência do carro em Cavalos !! Ex: 300");
            carro.Cavalos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nQuantos Kilometros ele faz por Litro Ex: 10 ");
            carro.KmPorLitro = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("\nSeu Veiculos Esta Com Filtro Entupido ? ");
            //                string filtro = Console.ReadLine();

            //                if (filtro == "SIM")
            //                    carro.FiltroCombustivelEntupido = true;
            //                else if (filtro == "NAO")
            //                   carro.FiltroCombustivelEntupido = false;


            carros1.Add(carro);
            Console.Clear();

            //            }
            //CADASTRO MOTOS !!
            //            for (int i = 0; i < 2; i++)
            //           {
            Moto moto = new Moto();

            Console.WriteLine("\nDigite o Modelo do Veiculo Ex: XT660");
            moto.Modelo = Console.ReadLine();


            Console.WriteLine("\nDigite a Marca da Moto Ex: Yahama");
            moto.Marca = Console.ReadLine();


            Console.WriteLine("\nDigite o Pais de Origem da Moto Ex: Estados Unidos");
            moto.PaisDeOrigem = Console.ReadLine();


            Console.WriteLine("\nDigite a Quantidade atual de Litros no Tanque: Ex : 10 ");
            moto.QntTanqueAtual = Convert.ToDecimal(Console.ReadLine());


            Console.WriteLine("\nDigite se sua Moto é Flex : Ex : Sim ou Não !!");
            //                string flex1 = Console.ReadLine().ToUpper().Replace("Ã", "A");


            //                if (flex1 == "SIM")
            //                    moto.Flex = true;
            //                else if (flex1 == "NAO")
            //                    moto.Flex = false;

            Console.WriteLine("\nDigite a Quantidade de Litros que o Tanque Comporta Ex : 50");
            moto.QntTanqueCombustivel = Convert.ToDecimal(Console.ReadLine());


            Console.WriteLine("\nDigite a Potência da Moto em cilindradas !! Ex: 300");
            moto.Cilindradas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nQuantos Kilometros sua Moto faz por Litro Ex: 14");
            moto.KmPorLitro = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("\nSeu Veiculos Esta Com Filtro Entupido ? ");
            string filtro = Console.ReadLine();

            if (filtro == "SIM")
                moto.FiltroCombustivelEntupido = true;
            else if (filtro == "NAO")
                moto.FiltroCombustivelEntupido = false;

            motos.Add(moto);
            Console.Clear();
            //            }

            //            var count = 0;
            //            foreach (var carro in carros1)
            {
                //                Console.WriteLine($"\n\nCarro : {carros1[count].Modelo}\nMarca: {carros1[count].Marca}\nPais de Origem : {carros1[count].PaisDeOrigem}\nQuntidade atual de Gazolina: {carros1[count].QntTanqueAtual}\n Quantidade de Gasolina que cabe no tanque :" +
                //                    $"{carros1[count].QntTanqueCombustivel}\n KM's Por Litro: {carros1[count].KmPorLitro} \nCavalos : {carros1[count].Cavalos}\n\n");

                //                count++;
            }

            Console.Clear();

            //            var count1 = 0;
            //            foreach (var moto in motos)
            {
                //               Console.WriteLine($"\n\nMoto : {motos[count1].Modelo}\nMarca: {motos[count1].Marca}\nPais de Origem : {motos[count1].PaisDeOrigem}\nQuntidade atual de Gazolina: {motos[count1].QntTanqueAtual}\n Quantidade de Gasolina que cabe no tanque :" +
                //                   $"{motos[count1].QntTanqueCombustivel}\n KM's Por Litro: {motos[count1].KmPorLitro} \nCavalos : {motos[count1].Cilindradas}\n\n");

                //                count++;
            }

            Console.Clear();

            ClasseViagem lugar = new ClasseViagem();

            Console.WriteLine("Digite o Destino para onde deseja viajar ? ");
            lugar.Destino = Console.ReadLine();

            Console.WriteLine("Digite o a Distancia a Percorrer em KMs \n Ex: 1.400");
            lugar.DistanciaKms = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("O Clima da viagem está ruim  sim ou não ? ");
            lugar.ClimaRuim = Console.ReadLine().ToUpper();



            string opcao = "0";
            while (opcao != "4")
            {
                Console.WriteLine("\nVocê deseja Dirigir Carro ou Moto ? ");
                string op = Console.ReadLine().ToUpper();
                int veiculo = 0;
                if (op == "CARRO")
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine($"{i + 1} - {carros1[i].Modelo}\n");
                    }
                    Console.WriteLine("\nDigite Qual CARRO que você quer dirigir ? ");
                    veiculo = Convert.ToInt32(Console.ReadLine());
                    Console.Write($"O veiculo Escolhido foi {carros1[veiculo].Modelo}");

                    Console.WriteLine("Digite 1 para dirigir\nDigite 2 para abastecer\nDigite 3 para exibir a quantidade de combustível atual\nDigite 4 Para Finalizar o Programa");
                    opcao = Console.ReadLine();

                    switch (opcao)
                    {
                        case "1": { Console.WriteLine("Por quantos km's deseja dirigir ?"); carros1[veiculo].Dirigir(Convert.ToDecimal(Console.ReadLine())); break; }
                        case "2": { Console.WriteLine("Quantos litros deseja abastecer ?"); carros1[veiculo].Abastecer(Convert.ToDecimal(Console.ReadLine())); break; }
                        case "3": { Console.WriteLine("Quantidade do tanque atual:"); Console.WriteLine($"{Math.Round(carros1[veiculo].QntTanqueAtual, 2)} litros \n"); break; }
                        case "4": { Console.WriteLine("Volte Sempre !\n"); break; }

                        default:
                            Console.WriteLine("\nOPÇÃO INVÁLIDA FAVOR INFORMAR UMA OPERAÇÃO VALIDA !! ");
                            opcao = Console.ReadLine();
                            break;
                    }

                }
                else if (op == "Moto")
                {
                    veiculo = 0;
                    for (int i = 0; i < 2; i++)
                    {
                        Console.WriteLine($"{i + 1}-{motos[i].Modelo}\n");
                    }
                    Console.WriteLine("Digite Qual Moto que você quer dirigir ? ");
                    veiculo = Convert.ToInt32(Console.ReadLine());
                    Console.Write($"\nO veiculo Escolhido foi {motos[veiculo].Modelo}");

                    Console.WriteLine("Digite 1 para dirigir\nDigite 2 para abastecer\nDigite 3 para exibir a quantidade de combustível atual\nDigite 4 Para Finalizar o Programa");
                    opcao = Console.ReadLine();

                    switch (opcao)
                    {
                        case "1": { Console.WriteLine("Por quantos km's deseja dirigir ?"); motos[veiculo].Dirigir(Convert.ToDecimal(Console.ReadLine())); break; }
                        case "2": { Console.WriteLine("Quantos litros deseja abastecer ?"); motos[veiculo].Abastecer(Convert.ToDecimal(Console.ReadLine())); break; }
                        case "3": { Console.WriteLine("Quantidade do tanque atual:"); Console.WriteLine($"{Math.Round(motos[veiculo].QntTanqueAtual, 2)} litros \n"); break; }
                        case "4": { Console.WriteLine("Volte Sempre !\n"); break; }

                        default:
                            Console.WriteLine("\nOPÇÃO INVÁLIDA FAVOR INFORMAR UMA OPERAÇÃO VALIDA !! ");
                            opcao = Console.ReadLine();
                            break;

                    }

                }
                else
                    Console.WriteLine("OPÇÃO INVÁLIDA !!");

            }
        }
    }
}
