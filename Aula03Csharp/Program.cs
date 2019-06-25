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
                    Console.Write("Digite o modelo do carro:");
                    carrinho.Modelo = Console.ReadLine();
                    Console.Write("Digite a marca do carro:");
                    carrinho.Marca = Console.ReadLine();
                    Console.Write("Digite os cavalos do carro:");
                    carrinho.Cavalos = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite o pais de origem do carro:");
                    carrinho.PaisDeOrigem = Console.ReadLine();
                    Console.Write("Digite o quantidade maxima de combustivel do carro:");
                    carrinho.QntTanqueCombustivel = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Digite o cumbustivel atual do carro:");
                    carrinho.QntTanqueAtual = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("O filtro de combustivel do carro está entupido(true/false):");
                    carrinho.FiltroCombustivelEntupido = Convert.ToBoolean(Console.ReadLine());
                    Carros.Add(carrinho);
                    Console.Clear();
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
                    Console.Write("Digite o modelo do moto:");
                    motinha.Modelo = Console.ReadLine();
                    Console.Write("Digite a marca do moto:");
                    motinha.Marca = Console.ReadLine();
                    Console.Write("Digite os cilindradas do moto:");
                    motinha.Cilindradas = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite o pais de origem do moto:");
                    motinha.PaisDeOrigem = Console.ReadLine();
                    Console.Write("Digite o quantidade maxima de combustivel do moto:");
                    motinha.QntTanqueCombustivel = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Digite o cumbustivel atual do moto:");
                    motinha.QntTanqueAtual = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("O filtro de combustivel da moto está entupido(true/false):");
                    motinha.FiltroCombustivelEntupido = Convert.ToBoolean(Console.ReadLine());
                    Motos.Add(motinha);
                    Console.Clear();
                }
                catch (Exception e) {
                    Console.WriteLine(e.Message);
                    i--;
                }
            }
            i = 0;
            do   
            {
                try
                {
                    //Tamanho da Viajem
                    Console.Write("Digite o tamanho da viagem:");
                    Viagem = Convert.ToDecimal(Console.ReadLine(), CultureInfo.InvariantCulture);
                    bool Viajando = true;
                    //Controle do clima
                    Console.Write("Qual o clima da viajem(bom/ruim):");
                    string estado = Console.ReadLine();
                    if (estado.ToUpper() == "RUIM")
                        clima = true;
                    
                    do
                    {
                        Console.WriteLine("Digite 1 para dirigir\nDigite 2 para abastecer\nDigite 3 para exibir a quantidade de combustível atual\nDigite 4 para ver todos os dados do veiculo");
                        string opcao = Console.ReadLine();
                        //Viagem Carros                                            
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
                    } while (Viajando == true);
                    i++;
                }
                catch (Exception e) { Console.WriteLine(e.Message); }
            } while (Carros[0].viagem != Viagem || Carros[1].viagem != Viagem || Carros[2].viagem != Viagem);
        }
    }
}
