using System;
using System.Collections.Generic;
using System.Globalization;
namespace Aula03Csharp
{
    class Program
    {
        static void Main(string[] args)
        {   int i = 0,potencia,car=0,moto=0;
            bool flex,filtro,clima=false;
            decimal Viagem = 0;
            List<Carro> Carros = new List<Carro>();
            List<Moto> Motos = new List<Moto>();
            do
            {
                try
                {
                    Console.WriteLine("Digite a Marca:");
                    string Marca = Console.ReadLine();
                    Console.WriteLine("Digite o Pais de Origem:");
                    string Pais = Console.ReadLine();
                    Console.WriteLine("O Veiculo é Flex?(s/n)");
                    char s = Convert.ToChar(Console.ReadLine());
                    //Validação flex
                    if (s == 's' || s == 'S')
                        flex = true;
                    else flex = false;
                    Console.WriteLine("Quantos litros tem o Tanque cheio?");
                    decimal QtdT = Convert.ToDecimal(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.WriteLine("Quantos Litros tem no Tanque Atual:");
                    decimal Quan = Convert.ToDecimal(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.WriteLine("O filtro de combustivo esta sujo?(S/N)");
                    s = Convert.ToChar(Console.ReadLine());
                    //Validação do filtro
                    if (s == 's' || s == 'S')
                        filtro = true;
                    else filtro = false;
                    Console.WriteLine("O Veiculo é moto ou carro?");
                    string veiculo = Console.ReadLine();
                    //Finalização do registro caso carro
                    if (veiculo.ToUpper() == "CARRO")
                    {
                        Console.WriteLine("Digite o Modelo do veiculo:");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Digite os Cavalos:");
                        potencia = Convert.ToInt32(Console.ReadLine());
                        Carro carrinho = new Carro(Marca, Pais, QtdT, flex, Quan,filtro, potencia, nome);
                        Console.Write("Quantos KM faz por Litro");
                        decimal Km = Convert.ToDecimal(Console.ReadLine(),CultureInfo.InvariantCulture);
                        carrinho.KmLitro(Km);
                        if (car < 3)
                        {
                            Carros.Add(carrinho);
                            i++;
                            car++;
                        }
                        else
                        {
                            Console.WriteLine("Numero maximo de carros atingido");
                            Console.ReadLine();
                        }
                    }
                    //finalização do registro caso moto
                    else if (veiculo.ToUpper() == "MOTO")
                    {
                        Console.WriteLine("Digite as Cilindradas:");
                        potencia = Convert.ToInt32(Console.ReadLine());
                        Moto motinha = new Moto(Marca, Pais, QtdT, flex, Quan,filtro, potencia);
                        Console.Write("Quantos KM faz por Litro");
                        decimal Km = Convert.ToDecimal(Console.ReadLine(), CultureInfo.InvariantCulture);
                        motinha.KmLitro(Km);
                        if (moto < 2)
                        {
                            Motos.Add(motinha);
                            i++;
                            moto++;
                        }
                        else
                        {
                            Console.WriteLine("Numero maximo de motos atingido");
                            Console.ReadLine();
                        }
                    }//Caso nenhum
                    else
                    { Console.WriteLine("Digite um carro ou moto da proxima vez.");
                        Console.ReadLine();
                    }
                    Console.Clear();
                }catch(Exception e){Console.WriteLine(e.Message);}
            } while (i < 5);
            do
            {
                try
                {
                    //Tamanho da Viajem
                    Console.Write("Digite o tamanho da viagem:");
                    Viagem = Convert.ToDecimal(Console.ReadLine(), CultureInfo.InvariantCulture);
                    bool Viajando = true;
                    Console.Write("Viajar com Carro ou Moto?");
                    string ESCOLHA = Console.ReadLine();
                    if (ESCOLHA.ToUpper() == "CARRO")
                    { i = 0;
                        foreach (Carro C in Carros)
                        {
                            Console.WriteLine($"Carro:{C.Marca}  Numero:{i + 1}");
                            i++;
                        }
                    }
                    if (ESCOLHA.ToUpper() == "MOTO")
                    {
                        i = 0;
                        foreach (Moto C in Motos)
                        {
                            Console.WriteLine($"Moto:{C.Marca}  Numero:{i + 1}");
                            i++;
                        }
                    }
                    Console.Write("Digite o Numero do veiculo:");
                    i = Convert.ToInt32(Console.ReadLine());
                    i -= 1;
                    //Controle do clima
                    Console.Write("Qual o clima da viajem(bom/ruim):");
                    string estado = Console.ReadLine();
                    if (estado.ToUpper() == "BOM")
                        clima = false;
                    else if (estado.ToUpper() == "RUIM")
                        clima = true;
                    do
                    {
                        Console.WriteLine("Digite 1 para dirigir\nDigite 2 para abastecer\nDigite 3 para exibir a quantidade de combustível atual\nDigite 4 para parar a viajem\nDigite 5 para ver todos os dados do veiculo");
                        string opcao = Console.ReadLine();
                        //Viagem Carros
                        if (ESCOLHA.ToUpper() == "CARRO")
                        {
                            Carros[i].Clima = clima;
                            switch (opcao)
                            {
                                case "1": { Console.WriteLine("Por quantos km's deseja dirigir ?"); Carros[i].Dirigir(Convert.ToDecimal(Console.ReadLine()), Viagem); break; }
                                case "2": { Console.WriteLine("Quantos litros deseja abastecer ?"); Carros[i].Abastecer(Convert.ToDecimal(Console.ReadLine())); break; }
                                case "3": { Console.WriteLine("Quantidade do tanque atual:"); Console.WriteLine($"{Math.Round(Carros[i].QntTanqueAtual, 2)} litros \n"); break; }
                                case "4": { Viajando = false; break; }
                                case "5": { Console.WriteLine(Carros[i].ToString()); break; }
                                default:
                                    break;
                            }
                        }
                        //Viagem Motos
                        if (ESCOLHA.ToUpper() == "MOTO")
                        {
                            Motos[i].Clima = clima;
                            switch (opcao)
                            {
                                case "1": { Console.WriteLine("Por quantos km's deseja dirigir ?"); Motos[i].Dirigir(Convert.ToDecimal(Console.ReadLine()), Viagem); break; }
                                case "2": { Console.WriteLine("Quantos litros deseja abastecer ?"); Motos[i].Abastecer(Convert.ToDecimal(Console.ReadLine())); break; }
                                case "3": { Console.WriteLine("Quantidade do tanque atual:"); Console.WriteLine($"{Math.Round(Motos[i].QntTanqueAtual, 2)} litros \n"); break; }
                                case "4": { Viajando = false; break; }
                                case "5": { Console.WriteLine(Motos[i].ToString()); break; }
                                default:
                                    break;
                            }
                        }
                    } while (Viajando == true);

                }
                catch (Exception e) { Console.WriteLine(e.Message); }
            } while (Motos[0].viagem != Viagem || Motos[1].viagem != Viagem || Carros[0].viagem != Viagem || Carros[1].viagem != Viagem || Carros[2].viagem != Viagem);
        }
    }
}
