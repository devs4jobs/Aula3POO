using System;

namespace Aula03Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro { Modelo = "Cruze", Marca = "Chevrolet", Cavalos = 180, PaisDeOrigem = "EUA", Flex = true, QntTanqueAtual = 10, QntTanqueCombustivel = 60 };
            carro.KmLitro(9.1M);
            carro.FiltroCombustivelEntupido = true;
            Console.WriteLine($"Carro:{carro.Modelo} - Marca: {carro.Marca} - Combustível atual {carro.QntTanqueAtual} - QntTanqueTotal = {carro.QntTanqueCombustivel}");

            while (true)
            {
                Console.WriteLine("Digite 1 para dirigir\nDigite 2 para abastecer\nDigite 3 para exibir a quantidade de combustível atual");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1": { Console.WriteLine("Por quantos km's deseja dirigir ?"); carro.Dirigir(Convert.ToDecimal(Console.ReadLine())); break; }
                    case "2": { Console.WriteLine("Quantos litros deseja abastecer ?"); carro.Abastecer(Convert.ToDecimal(Console.ReadLine())); break; }
                    case "3": { Console.WriteLine("Quantidade do tanque atual:"); Console.WriteLine($"{Math.Round(carro.QntTanqueAtual, 2)} litros \n"); break; }

                    default:
                        break;
                }
            }



        }
    }
}
