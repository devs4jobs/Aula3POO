using System;
using System.Collections.Generic;

namespace Aula03Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Metedos metedos = new Metedos();
            string flex1 ;
            bool Flex = false;
            string op = "";
            string Modelo;
            string Marca;
            string PaisDeOrigem;
            
            List<Veiculo> veiculos1 = new List<Veiculo>();

            int contMotos = 0, contCarros = 0 , vei = 0;


            do
            {
                

                Console.Clear();

                Console.WriteLine("Digite o Modelo do Veiculo Ex: Corolla \n");
                Modelo = Console.ReadLine();

                Console.WriteLine("Digite a Marca do Carro Ex: Toyota \n");
                Marca = Console.ReadLine();

                Console.WriteLine("Digite o Pais de Origem do Carro Ex: China");
                PaisDeOrigem = Console.ReadLine();

                Console.WriteLine("Digite se o Veiculo é Flex : Ex : Sim ou Não !! \n ");
                flex1 = Console.ReadLine();
              
                if (flex1.ToString().ToUpper() == "SIM") { Flex = true; }

                Console.WriteLine("Digite a Quantidade atual de Litros no Tanque: Ex : 10 \n ");
                double QntTanqueAtual = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a Quantidade de Litros que o Tanque Comporta Ex : 50  \n");
                double QntTanqueCombustivel = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Qual Veiculo você deseja Cadastrar Carro ou Moto ? \n");
                op = Console.ReadLine().ToUpper();

                Carro carros = new Carro (Modelo, Marca, PaisDeOrigem, QntTanqueAtual, Flex, QntTanqueCombustivel,400);
                Moto motos = new Moto (Modelo, Marca, PaisDeOrigem, QntTanqueAtual, Flex, QntTanqueCombustivel,300);


                if (op == "CARRO")
                {

                    carros.KmLitro(9.1);
                    carros.FiltroCombustivelEntupido = true;
                    Console.WriteLine("Digite Quantos Cavalos tem o Carro !!! Ex: 320 \n"); 
                    carros.Cavalos = Convert.ToInt32(Console.ReadLine());
                    

                    veiculos1.Add(carros);
                    contCarros++;
                    if (contCarros == 3)
                    
                        Console.WriteLine("Por favor Digite agora 2 motos !! ");
                   
                    vei++;

                }
                else if (op == "MOTO")
                {
         
                    Console.WriteLine("Digite Quantas Cilindradas tem a Moto !! Ex: 660 \n");
                    motos.Cilindradas = Convert.ToInt32(Console.ReadLine());
                    veiculos1.Add(motos);
                    contMotos++;
                    

                    if (contMotos == 2)
                    
                        Console.WriteLine("Por favor Digite agora 3 carros !! ");
                    
                    vei++;
                }


               
            } while (vei < 5);


            var count = 0;
            foreach ( var veiculo in veiculos1)
            {
            Console.WriteLine($"Carro:{veiculos1[count].Modelo} - \n Marca: {veiculos1[count].Marca} - \n Combustível atual no tanque {veiculos1[count].QntTanqueAtual} -\n  QntTanqueTotal = {veiculos1[count].QntTanqueCombustivel}");

                count++;
            }

            while (true)
            {
                Console.WriteLine("Digite 1 para dirigir\nDigite 2 para abastecer\nDigite 3 para exibir a quantidade de combustível atual");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                   case "1": { Console.WriteLine("Por quantos km's deseja dirigir ?"); carros.Dirigir(Convert.ToDouble(Console.ReadLine())); break; }
                   case "2": { Console.WriteLine("Quantos litros deseja abastecer ?"); carros.Abastecer(Convert.ToDouble(Console.ReadLine())); break; }
                   case "3": { Console.WriteLine("Quantidade do tanque atual:"); Console.WriteLine($"{Math.Round(carros.QntTanqueAtual, 2)} litros \n"); break; }

                    default:
                        break;
                }
            }



        }
    }
}
