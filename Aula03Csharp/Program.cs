using System;
using System.Collections.Generic;
using System.Globalization;
namespace Aula03Csharp
{
    class Program
    {
        static void Main(string[] args)
        {   bool clima=false;
            decimal Viagem=0;
            int i;
            List<Carro> Carros = new List<Carro>();
            List<Moto> Motos = new List<Moto>();
            for(i=0;i<3;i++)
            {
                try
                {
                    Carro carrinho = new Carro();
                    carrinho.RegistraCarro();
                    Carros.Add(carrinho);
                }catch(Exception e){
                    Console.WriteLine(e.Message);
                    i--;
                }
            } 
            for(i=0;i<2;i++)
            {
                try
                {
                    Moto motinha= new Moto();
                    motinha.RegistraMoto();
                    Motos.Add(motinha);
                }
                catch (Exception e) {
                    Console.WriteLine(e.Message);
                    i--;
                }
            }
            //defini primeiro carro
            i = 0;
            do
            {
                try
                {
                    //Tamanho da Viajem
                    Console.Write("Digite o tamanho da viagem:");
                    Viagem = Convert.ToDecimal(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                catch (Exception e) { Console.WriteLine(e.Message); }
            } while (Viagem > 0);
            //Controle do clima
            Console.Write("Qual o clima da viajem(bom/ruim):");
            string estado = Console.ReadLine();
            if (estado.ToUpper() == "RUIM")
                clima = true;
            do
            {
                do
                {
                    Console.WriteLine("Digite 1 para dirigir\nDigite 2 para abastecer\nDigite 3 para exibir a quantidade de combustível atual\nDigite 4 para ver todos os dados do veiculo");
                    string opcao = Console.ReadLine();
                    //Clima                                           
                    Carros[i].Clima = clima;
                    switch (opcao)
                    {
                        case "1": { Console.WriteLine("Por quantos km's deseja dirigir ?"); Carros[i].Dirigir(Convert.ToDecimal(Console.ReadLine()), Viagem); break; }
                        case "2": { Console.WriteLine("Quantos litros deseja abastecer ?"); Carros[i].Abastecer(Convert.ToDecimal(Console.ReadLine())); break; }
                        case "3": { Console.WriteLine("Quantidade do tanque atual:"); Console.WriteLine($"{Math.Round(Carros[i].QntTanqueAtual, 2)} litros \n"); break; }
                        case "4": { Console.WriteLine(Carros[i].ToString()); break; }
                        default:
                            break;
                    }
                } while ( Carros[i].viagem != Viagem);
                //Troca do carro
                i++;
            } while (Carros[0].viagem != Viagem || Carros[1].viagem != Viagem || Carros[2].viagem != Viagem);
            //Primeira moto
            i = 0;
            do
            {
                do
                {
                    Console.WriteLine("Digite 1 para dirigir\nDigite 2 para abastecer\nDigite 3 para exibir a quantidade de combustível atual\nDigite 4 para ver todos os dados do veiculo");
                    string opcao = Console.ReadLine();
                    //Clima
                    Motos[i].Clima = clima;
                    switch (opcao)
                    {
                        case "1": { Console.WriteLine("Por quantos km's deseja dirigir ?"); Motos[i].Dirigir(Convert.ToDecimal(Console.ReadLine()), Viagem); break; }
                        case "2": { Console.WriteLine("Quantos litros deseja abastecer ?"); Motos[i].Abastecer(Convert.ToDecimal(Console.ReadLine())); break; }
                        case "3": { Console.WriteLine("Quantidade do tanque atual:"); Console.WriteLine($"{Math.Round(Motos[i].QntTanqueAtual, 2)} litros \n"); break; }
                        case "4": { Console.WriteLine(Motos[i].ToString()); break; }
                        default:
                            break;
                    }
                } while (Motos[i].viagem != Viagem);
                //Troca Moto
                i++;
            } while (Motos[0].viagem != Viagem || Motos[1].viagem != Viagem);
            Console.Write("Completou a viajem!");
            Console.ReadLine();
        }
    }
}
