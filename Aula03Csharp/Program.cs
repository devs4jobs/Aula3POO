﻿using System;
using System.Collections.Generic;

namespace Aula03Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] carros;
            //string[] motos;
            string retorno = "";
            int i = 0;

            List<Carro> carros = new List<Carro>();
            List<Moto> motos1 = new List<Moto>();

            for (i = 0; i < 3; i++)
            {
                Carro carro = new Carro();

                Console.WriteLine($"DIGITE A MARCA DO CARRO {i + 1}: ");
                carro.Marca = Console.ReadLine();

                Console.WriteLine($"DIGITE O MODELO DO CARRO {i + 1}: ");
                carro.Modelo = Console.ReadLine();

                Console.WriteLine($"DIGITE O PAIS DE ORIGEM DO CARRO {i + 1}: ");
                carro.PaisDeOrigem = Console.ReadLine();

                Console.WriteLine($"O VEICULO{i + 1} É FLEX? sim ou não");
                retorno = Console.ReadLine();

                if (retorno == "SIM" || retorno == "sim")
                {
                    carro.Flex = true;
                }
                else
                    carro.Flex = false;

                Console.WriteLine($"QUAL A QUANTIDADE DE COMBUSTIVEL ATUAL DO CARRO {i + 1} ?");
                carro.QntTanqueAtual = decimal.Parse(Console.ReadLine());

                if (carro.QntTanqueAtual < 0)
                {
                    while (carro.QntTanqueAtual < 0)
                    {
                        Console.WriteLine("Insira um valor válido");
                        Console.WriteLine();
                        Console.WriteLine($"QUAL A QUANTIDADE DE COMBUSTIVEL ATUAL DO CARRO {i + 1} ?");
                        carro.QntTanqueAtual = decimal.Parse(Console.ReadLine());
                        Console.WriteLine();

                    }

                }

                Console.WriteLine("QUAL A QUANTIDADA MAXIMA SUPORTADA NO RESERVATORIO DE COMBUSTIVEL?");
                carro.QntTanqueCombustivel = decimal.Parse(Console.ReadLine());

                if (carro.QntTanqueCombustivel < 0)
                {
                    while (carro.QntTanqueCombustivel < 0)
                    {
                        Console.WriteLine("Insira um valor válido");
                        Console.WriteLine();
                        Console.WriteLine("QUAL A QUANTIDADA MAXIMA SUPORTADA NO RESERVATORIO DE COMBUSTIVEL?");
                        carro.QntTanqueCombustivel = decimal.Parse(Console.ReadLine());
                        Console.WriteLine();

                    }

                }

                Console.WriteLine($"QUANTOS KM/L O CARRO {i + 1} FAZ? ");
                carro.KmPorLitro = decimal.Parse(Console.ReadLine());

                if (carro.KmPorLitro < 0)
                {
                    while (carro.KmPorLitro < 0)
                    {
                        Console.WriteLine("Insira um valor válido");
                        Console.WriteLine();
                        Console.WriteLine($"QUANTOS KM/L O CARRO {i + 1} FAZ? ");
                        carro.KmPorLitro = decimal.Parse(Console.ReadLine());
                        Console.WriteLine();

                    }

                }

                Console.WriteLine($"QUANTOS CAVALOS DE POTENCIA O CARRO {i + 1} TEM?");
                carro.Cavalos = int.Parse(Console.ReadLine());

                if (carro.Cavalos < 0)
                {
                    while (carro.Cavalos < 0)
                    {
                        Console.WriteLine("Insira um valor válido");
                        Console.WriteLine();
                        Console.WriteLine($"QUANTOS CAVALOS DE POTENCIA O CARRO {i + 1} TEM?");
                        carro.Cavalos = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                    }

                }

                Console.WriteLine("SEU FILTRO DE COMBUSTIVEL ESTÁ SUJO? (SIM/NAO)");
                carro.filtro = Console.ReadLine().ToUpper();
                Console.WriteLine();

                //if (carro.filtro.ToString().ToUpper() == "SIM") { carro.FiltroCombustivelEntupido = true; }
                //else
                //    carro.FiltroCombustivelEntupido = false;

                carros.Add(carro);
                

                Console.WriteLine($" MARCA: {carros[i].Marca} \n MODELO: {carros[i].Modelo} \n PAIS DE ORIGEM: {carros[i].PaisDeOrigem} \n FLEX: {carros[i].Flex} \n QUANTIDADE DE COMBUSTIVEL ATUAL: {carros[i].QntTanqueAtual} \n QUANTIDADE DE COMBUSTIVEL TOTAL SUPORTADA: {carros[i].QntTanqueCombustivel} \n POTENCIA: {carros[i].Cavalos} CAVALOS \n FILTRO SUJO: {carros[i].filtro} ");
                Console.WriteLine();
            }

            for (i = 0; i < 2; i++)
            {
                Moto moto = new Moto();

                Console.WriteLine($"DIGITE A MARCA DA MOTO {i + 1}: ");
                moto.Marca = Console.ReadLine();

                Console.WriteLine($"DIGITE O MODELO DA MOTO {i + 1}: ");
                moto.Modelo = Console.ReadLine();

                Console.WriteLine($"DIGITE O PAIS DE ORIGEM DA MOTO {i + 1}: ");
                moto.PaisDeOrigem = Console.ReadLine();

                Console.WriteLine("O VEICULO É FLEX? sim ou não");
                retorno = Console.ReadLine();

                if (retorno == "SIM" || retorno == "sim")
                {
                    moto.Flex = true;
                }
                else
                    moto.Flex = false;

                Console.WriteLine($"QUAL A QUANTIDADE DE COMBUSTIVEL ATUAL DA MOTO {i + 1}?");
                moto.QntTanqueAtual = decimal.Parse(Console.ReadLine());


                if (moto.QntTanqueAtual < 0)
                {
                    while (moto.QntTanqueAtual < 0)
                    {
                        Console.WriteLine("Insira um valor válido");
                        Console.WriteLine();
                        Console.WriteLine($"QUAL A QUANTIDADE DE COMBUSTIVEL ATUAL DA MOTO {i + 1}?");
                        moto.QntTanqueAtual = decimal.Parse(Console.ReadLine());
                        Console.WriteLine();

                    }

                }

                Console.WriteLine("QUAL A QUANTIDADA MAXIMA SUPORTADA NO RESERVATORIO DE COMBUSTIVEL?");
                moto.QntTanqueCombustivel = decimal.Parse(Console.ReadLine());

                if (moto.QntTanqueCombustivel < 0)
                {
                    while (moto.QntTanqueCombustivel < 0)
                    {
                        Console.WriteLine("Insira um valor válido");
                        Console.WriteLine();
                        Console.WriteLine("QUAL A QUANTIDADE MAXIMA SUPORTADA NO RESERVATORIO DE COMBUSTIVEL?");
                        moto.QntTanqueCombustivel = decimal.Parse(Console.ReadLine());
                        Console.WriteLine();

                    }

                }

                Console.WriteLine("QUANTOS KM/L O VEICULO FAZ? ");
                moto.KmPorLitro = decimal.Parse(Console.ReadLine());

                if (moto.KmPorLitro < 0)
                {
                    while (moto.KmPorLitro < 0)
                    {
                        Console.WriteLine("Insira um valor válido");
                        Console.WriteLine();
                        Console.WriteLine("QUANTOS KM/L O VEICULO FAZ? ");
                        moto.KmPorLitro = decimal.Parse(Console.ReadLine());
                        Console.WriteLine();

                    }

                }

                Console.WriteLine($"QUANTAS CILINDRADAS DE POTENCIA A MOTO {i + 1} TEM?");
                moto.Cilindradas = int.Parse(Console.ReadLine());

                if (moto.Cilindradas < 0)
                {
                    while (moto.Cilindradas < 0)
                    {
                        Console.WriteLine("Insira um valor válido");
                        Console.WriteLine();
                        Console.WriteLine($"QUANTAS CILINDRADAS DE POTENCIA A MOTO {i + 1} TEM?");
                        moto.Cilindradas = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                    }

                }

                Console.WriteLine("SEU FILTRO DE COMBUSTIVEL ESTÁ SUJO? (SIM/NAO)");
                moto.filtro = Console.ReadLine().ToUpper();
                Console.WriteLine();

                //if (moto.filtro.ToString().ToUpper() == "SIM") { moto.FiltroCombustivelEntupido = true; }
                //else
                //    moto.FiltroCombustivelEntupido = false;
                motos1.Add(moto);

                Console.WriteLine($" MARCA: {motos1[i].Marca} \n MODELO: {motos1[i].Modelo} \n PAIS DE ORIGEM: {motos1[i].PaisDeOrigem} \n FLEX: {motos1[i].Flex} \n QUANTIDADE DE COMBUSTIVEL ATUAL: {motos1[i].QntTanqueAtual} \n QUANTIDADE DE COMBUSTIVEL TOTAL SUPORTADA: {motos1[i].QntTanqueCombustivel} \n POTENCIA: {motos1[i].Cilindradas} CILINDRAS \n FILTRO SUJO: {motos1[i].filtro}");
                Console.WriteLine();
            }

            Console.WriteLine("Qual o tamanha da viagem em km?");
            decimal viagem = decimal.Parse(Console.ReadLine());

            if (viagem < 0)
            {
                while (viagem < 0)
                {
                    Console.WriteLine("Insira um valor válido");
                    Console.WriteLine();
                    Console.WriteLine("Qual o tamanha da viagem em km?");
                    viagem = decimal.Parse(Console.ReadLine());
                    Console.WriteLine();

                }

            }

            Console.WriteLine();

            Console.WriteLine("PRIMERO IRÃO OS CARROS (UM POR VEZ) E EM SEGUIDA AS MOTOS (UMA POR VEZ)");
            Console.WriteLine();

            Console.WriteLine("COMO ESTÁ O CLIMA? BOM OU RUIM?");
            string clima = Console.ReadLine().ToUpper();
            Console.WriteLine();

            var kmPercorridosCarro = 0;

            var kmPercorridosMoto = 0;

           

            for (i = 0; kmPercorridosCarro < viagem; i++)
            {

                do
                {
                    Console.WriteLine($"Referente ao carro {i + 1}\nDigite 1 para dirigir\nDigite 2 para abastecer\nDigite 3 para exibir a quantidade de combustível atual");
                    string opcao = Console.ReadLine();

                    switch (opcao)
                    {
                        case "1":
                            {
                                Console.WriteLine("Por quantos km's deseja dirigir ?");
                                var dist = int.Parse(Console.ReadLine());
                                kmPercorridosCarro += dist;
                                carros[i].Dirigir(dist, clima);
                                break;
                            }

                        case "2": { Console.WriteLine("Quantos litros deseja abastecer ?"); carros[i].Abastecer(Convert.ToDecimal(Console.ReadLine())); break; }

                        case "3": { Console.WriteLine("Quantidade do tanque atual:"); Console.WriteLine($"{Math.Round(carros[i].QntTanqueAtual, 2)} litros \n"); break; }

                        default:
                            break;
                    }

                } while (viagem > carros[i].viajado);

                Console.WriteLine($"O CARRO {i + 1} CHEGOU AO SEU DESTINO, DIGITE ENTER PARA O PRÓXIMO CARRO");
                Console.ReadLine();
            }

            for (i = 0; kmPercorridosMoto < viagem; i++)
            {
                do
                {
                    Console.WriteLine("Digite 1 para dirigir\nDigite 2 para abastecer\nDigite 3 para exibir a quantidade de combustível atual");
                    string opcao2 = Console.ReadLine();

                    switch (opcao2)
                    {
                        case "1":
                            {
                                Console.WriteLine("Por quantos km's deseja dirigir ?");
                                var dist = int.Parse(Console.ReadLine());
                                kmPercorridosMoto += dist;
                                motos1[i].Dirigir(dist, clima);
                                break;
                            }

                        case "2": { Console.WriteLine("Quantos litros deseja abastecer ?"); motos1[i].Abastecer(Convert.ToDecimal(Console.ReadLine())); break; }

                        case "3": { Console.WriteLine("Quantidade do tanque atual:"); Console.WriteLine($"{Math.Round(motos1[i].QntTanqueAtual, 2)} litros \n"); break; }

                        default:
                            break;
                    }

                } while (viagem > motos1[i].viajado);

                Console.WriteLine($"A MOTO {i + 1} CHEGOU AO SEU DESTINO, DIGITE ENTER PARA A PRÓXIMO MOTO");
                Console.ReadLine();

            }
        }

    }
}







