using System;

namespace Aula03Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("digite o modelo do carro: ");
                string Modelo = Console.ReadLine();
                Console.WriteLine("digite a marca do carro: ");
                string Marca = Console.ReadLine();
                Console.WriteLine("digite a quantidade de cavalos: ");
                int Cavalos = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("digite o pais de origem: ");
                string PaisDeOrigem = Console.ReadLine();
                Console.WriteLine("digite se o carro é flex: ");
                bool Flex = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine("digite a quantidade atual: ");
                double QntTanqueAtual = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("digite a capacidade de combustivel do carro: ");
                double QntTanqueCombustivel = Convert.ToDouble(Console.ReadLine());
                Carro carro = new Carro(Modelo, Marca, Cavalos, PaisDeOrigem, Flex, QntTanqueAtual, QntTanqueCombustivel);
            }
            Carro carro = new Carro();
            //Carro carro = new Carro ( Modelo, Marca, Cavalos, PaisDeOrigem, Flex, QntTanqueAtual, QntTanqueCombustivel );
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
