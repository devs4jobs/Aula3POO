using System;
using System.Collections.Generic;

namespace Aula03Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string retorno = "";

            string escolher = "";

            do
            {

                List<Carro> carros = new List<Carro>();
                List<Moto> motos = new List<Moto>();

                for (int i = 0; i < 3; i++)
                {
                    try
                    {
                        Carro carro = new Carro();

                        Console.WriteLine("DIGITE A MARCA DO CARRO : ");
                        carro.Marca = Console.ReadLine();

                        Console.WriteLine("DIGITE O MODELO DO CARRO: ");
                        carro.Modelo = Console.ReadLine();

                        Console.WriteLine("DIGITE O PAIS DE ORIGEM DO CARRO : ");
                        carro.PaisDeOrigem = Console.ReadLine();

                        Console.WriteLine("O CARRO É FLEX ? SIM OU NAO ? ");
                        retorno = Console.ReadLine().ToUpper();

                        if (retorno == "SIM")

                            carro.Flex = true;

                        else
                            carro.Flex = false;

                        Console.WriteLine("QUAL É A CAPACIDADE DO TANQUE DO CARRO ?");
                        carro.QntTanqueCombustivel = decimal.Parse(Console.ReadLine());
                        carro.QntTanqueCombustivel = carro.ValidacaoDeci(carro.QntTanqueCombustivel);



                        Console.WriteLine("QUANTOS LITROS TEM NO TANQUE ATUAL ? ");
                        carro.QntTanqueAtual = decimal.Parse(Console.ReadLine());
                        carro.QntTanqueAtual = carro.ValidacaoDeci(carro.QntTanqueAtual);


                        Console.WriteLine("QUANTOS KM/L O CARRO FAZ ? ");
                        carro.KmPorLitro = decimal.Parse(Console.ReadLine());
                        carro.KmPorLitro = carro.ValidacaoDeci(carro.KmPorLitro);



                        Console.WriteLine("QUANTOS CAVALO DE POTENCIA O CARRO TEM ?");
                        carro.Cavalos = int.Parse(Console.ReadLine());
                        carro.Cavalos = carro.ValidacaoInt(carro.Cavalos);




                        Console.WriteLine("O FILTRO DE COMBUSTIVEL DO CARRO ESTÁ ENTUPIDO ? ");
                        string filtro = Console.ReadLine();

                        if (filtro.ToString().ToUpper() == "SIM")

                            carro.FiltroCombustivelEntupido = true;
                        else
                            carro.FiltroCombustivelEntupido = false;

                        carros.Add(carro);
                        Console.WriteLine($"MARCA:{carros[i].Marca} \n MODELO: {carros[i].Modelo} \nPAIS DE ORIGEM: {carros[i].PaisDeOrigem} \n FLEX: {carros[i].Flex} \n QUANTIDADE DE COMBUSTIVEL ATUAL: {carros[i].QntTanqueAtual} \n QUANTIDADE DE COMBUSTIVEL TOTAL SUPORTADA: {carros[i].QntTanqueCombustivel} \n POTENCIA: {carros[i].Cavalos} ");
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("ERRO DIGITE NOVAMENTE OS DADOS DO CARRO !!");
                        i--;
                    }
                }

                for (int i = 0; i < 2; i++)
                {

                    try
                    {
                        Moto moto = new Moto();

                        Console.WriteLine("DIGITE A MARCA DA MOTO ? ");
                        moto.Marca = Console.ReadLine();

                        Console.WriteLine("DIGITE O MODELO DA MOTO ? ");
                        moto.Modelo = Console.ReadLine();

                        Console.WriteLine("DIGITE O PAIS DE ORIGEM DA MOTO  ? ");
                        moto.PaisDeOrigem = Console.ReadLine();

                        Console.WriteLine("A MOTO É FLEX ? SIM OU NAO");
                        retorno = Console.ReadLine().ToUpper();

                        if (retorno == "SIM")
                            moto.Flex = true;
                        else
                            moto.Flex = false;

                        Console.WriteLine("QUAL É A CAPACIDADE DO TANQUE ?");
                        moto.QntTanqueCombustivel = decimal.Parse(Console.ReadLine());
                        moto.QntTanqueCombustivel = moto.ValidacaoDeci(moto.QntTanqueCombustivel);


                        Console.WriteLine("QUANTOS LITROS TEM NO TANQUE ATUAL ? ");
                        moto.QntTanqueAtual = decimal.Parse(Console.ReadLine());
                        moto.QntTanqueAtual = moto.ValidacaoDeci(moto.QntTanqueAtual);


                        Console.WriteLine("QUANTOS KM/L A MOTO FAZ ");
                        moto.KmPorLitro = decimal.Parse(Console.ReadLine());
                        moto.KmPorLitro = moto.ValidacaoDeci(moto.KmPorLitro);


                        Console.WriteLine("QUANTAS CILINDRADAS A MOTO TEM?");
                        moto.Cilindradas = int.Parse(Console.ReadLine());
                        moto.Cilindradas = moto.ValidacaoInt(moto.Cilindradas);

                        Console.WriteLine("O FILTRO DE COMBUSTÍVEL DA MOTO ESTÁ ENTUPIDO ?");
                        string filtro2 = Console.ReadLine();

                        if (filtro2.ToString().ToUpper() == "SIM")
                            moto.FiltroCombustivelEntupido = true;
                        else
                            moto.FiltroCombustivelEntupido = false;

                        motos.Add(moto);
                        Console.WriteLine($"MARCA: {motos[i].Marca} \n MODELO: {motos[i].Modelo} \n PAIS DE ORIGEM: {motos[i].PaisDeOrigem} \n FLEX: {motos[i].Flex} \nQUANTIDADE DE COMBUSTIVEL ATUAL: {motos[i].QntTanqueAtual} \nQUANTIDADE DE COMBUSTIVEL TOTAL SUPORTADA:{motos[i].QntTanqueCombustivel} \n POTENCIA: {motos[i].Cilindradas} ");

                    }
                    catch (Exception)
                    {

                        Console.WriteLine("ERRO DIGITE NOVAMENTE OS DADOS DA MOTO !!");
                        i--;
                    }
                }


                Console.WriteLine("DIGITE A KILOMETRAGEM TOTAL DA VIAGEM : ");
                decimal viagem = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("O CLIMA ESTÁ BOM OU RUIM ?");
                string clima = Console.ReadLine().ToUpper();

                Console.Write("A VIAGEM COMEÇARA PRIMEIRO COM OS CARROS E EM SEGUIDA IRA PARA AS MOTOS ");

                for (int i = 0; i < 3; i++)
                {
                    do
                    {

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

                for (int i = 0; i < 2; i++)
                {
                    do
                    {

                        Console.WriteLine($"MARCA: {motos[i].Marca} \n MODELO: {motos[i].Modelo} \n PAIS DE ORIGEM: {motos[i].PaisDeOrigem} \n FLEX: {motos[i].Flex} \nQUANTIDADE DE COMBUSTIVEL ATUAL: {motos[i].QntTanqueAtual} \nQUANTIDADE DE COMBUSTIVEL TOTAL SUPORTADA:{motos[i].QntTanqueCombustivel} \n POTENCIA: {motos[i].Cilindradas} ");

                        Console.WriteLine("Digite 1 para dirigir\nDigite 2 para abastecer\nDigite 3 para exibir a quantidade de combustível atual");
                        string opcao = Console.ReadLine();

                        switch (opcao)
                        {
                            case "1": { Console.WriteLine("Por quantos km's deseja dirigir ?"); motos[i].Dirigir(Convert.ToDecimal(Console.ReadLine()), clima); break; }
                            case "2": { Console.WriteLine("Quantos litros deseja abastecer ?"); motos[i].Abastecer(Convert.ToDecimal(Console.ReadLine())); break; }
                            case "3": { Console.WriteLine("Quantidade do tanque atual:"); Console.WriteLine($"{Math.Round(motos[i].QntTanqueAtual, 2)} litros \n"); break; }

                            default:
                                break;
                        }

                    } while (viagem > motos[i].viajar);
                    Console.WriteLine($"O carro chegou{motos[i].Modelo}, digite enter para a próxima viagem.");
                    Console.ReadLine();
                }
                Console.WriteLine("As motos chegaram no seu destino.");
                Console.WriteLine("Deseja viajar novamente? Sim ou Nao");
                escolher = Console.ReadLine().ToUpper();

            } while (escolher == "SIM");
        }
    }
}