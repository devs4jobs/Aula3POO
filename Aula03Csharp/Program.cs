using System;
using System.Globalization;
namespace Aula03Csharp
{
    class Program
    {
        static void Main(string[] args)
        { int i = 0;
            bool flex;
            do
            {
                try
                {
                    Console.WriteLine("Digite o Modelo do veiculo:");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Digite a Marca:");
                    string Marca = Console.ReadLine();
                    Console.WriteLine("Digite o Cavalos ou Cilindradas:");
                    int potencia = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o Pais de Origem:");
                    string Pais = Console.ReadLine();
                    Console.WriteLine("O Veiculo é Flex?(s/n)");
                    char s = Convert.ToChar(Console.ReadLine());
                    if (s == 's' || s == 'S')
                        flex = true;
                    else flex = false;
                    Console.WriteLine("Quantos litros tem o Tanque cheio?");
                    decimal QtdT = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Quantos Litros tem no Tanque Atual");
                    decimal Quan = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("O Veiculo é moto ou carro?");
                    string veiculo = Console.ReadLine();

                    if (veiculo == "carro" || veiculo == "Carro" || veiculo == "CARRO")
                    {
                        Carro Carrinho=new Carro()
                    }
                }
            } while (i < 5);
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
