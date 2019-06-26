using System;

namespace Aula03Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Carro[] carros = new Carro[3];
            Moto[] motos = new Moto[2];
            decimal viagem =0 ;
            string flex;
            string FiltroCombustivelEntupido;

            // cadastra 3 carros
            for (int i = 0; i < 3; i++)
            {
                try
                {
                    Carro carro = new Carro();
                    Console.WriteLine("digite o modelo do carro: ");
                    carro.Modelo = Console.ReadLine();
                    Console.WriteLine("digite a marca do carro: ");
                    carro.Marca = Console.ReadLine();
                    Console.WriteLine("digite a quantidade de cavalos: ");
                    carro.Cavalos = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("digite o pais de origem: ");
                    carro.PaisDeOrigem = Console.ReadLine();
                    Console.WriteLine("digite se o carro é flex: ");
                    flex = (Console.ReadLine());
                    if (flex == "SIM" || flex == "sim")
                        carro.Flex = true;
                    else
                        carro.Flex = false;
                    Console.WriteLine("digite a quantidade do tanque atual: ");
                    carro.QntTanqueAtual = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("digite a capacidade de combustivel do carro: ");
                    carro.QntTanqueCombustivel = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("digite se o carro está com filtro entupido: ");
                    FiltroCombustivelEntupido = (Console.ReadLine());
                    if (FiltroCombustivelEntupido == "SIM" || FiltroCombustivelEntupido == "sim")
                        carro.FiltroCombustivelEntupido = true;
                    else
                        carro.FiltroCombustivelEntupido = false;
                    Console.WriteLine("digite quantos quilometros faz por litro: ");
                    carro.KmPorLitro = Convert.ToDecimal(Console.ReadLine());
                    carros[i] = carro;
                    Console.Clear();
                }
                catch (Exception)
                {
                    Console.WriteLine("Erro, insira um valor compativel.");
                    i--;
                }
            }
            for (int i = 0; i < 3; i++) // mostra os valores dos 3 carros
            {
              Console.WriteLine($"Carro: {carros[i].Modelo} - Marca: {carros[i].Marca} - Cavalos: {carros[i].Cavalos} - País de origem: {carros[i].PaisDeOrigem} - Carro flex: {carros[i].Flex} - Combustível atual: {carros[i].QntTanqueAtual} - QntTanqueTotal: {carros[i].QntTanqueCombustivel}");
            }
            // cadastra 2 moto
            for (int i = 0; i < 2; i++)
                            {
                try
                {
                    Moto moto = new Moto();
                    Console.WriteLine("digite o modelo da moto: ");
                    moto.Modelo = Console.ReadLine();
                    Console.WriteLine("digite a marca da moto: ");
                    moto.Marca = Console.ReadLine();
                    Console.WriteLine("digite a quantidade de cilindradas: ");
                    moto.Cilindradas = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("digite o pais de origem: ");
                    moto.PaisDeOrigem = Console.ReadLine();
                    Console.WriteLine("digite se a moto é flex: ");
                    flex = (Console.ReadLine());
                    if (flex == "SIM" || flex == "sim")
                        moto.Flex = true;
                    else
                        moto.Flex = false;
                    Console.WriteLine("digite a quantidade do tanque atual: ");
                    moto.QntTanqueAtual = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("digite a capacidade de combustivel da moto: ");
                    moto.QntTanqueCombustivel = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("digite se a moto está com filtro está entupido");
                    FiltroCombustivelEntupido = (Console.ReadLine());
                    if (FiltroCombustivelEntupido == "SIM" || FiltroCombustivelEntupido == "sim")
                        moto.FiltroCombustivelEntupido = true;
                    else
                        moto.FiltroCombustivelEntupido = false;
                    Console.WriteLine("digite quantos quilometros faz por litro: ");
                    moto.KmPorLitro = Convert.ToDecimal(Console.ReadLine());
                    motos[i] = moto;
                    Console.Clear();
                }
                catch(Exception)
                {
                    Console.WriteLine("Erro, insira um valor compativel.");
                    i--;
                }
            }
            for (int i = 0; i < 2; i++) // mostra os valores das 2 motos
            {
              Console.WriteLine($"Motos:{motos[i].Modelo} - Marca: {motos[i].Marca} - Cilindradas: {motos[i].Cilindradas} - País de origem: {motos[i].PaisDeOrigem} - Moto flex: {motos[i].Flex} - Combustível atual: {motos[i].QntTanqueAtual} - QntTanqueTotal: {motos[i].QntTanqueCombustivel}");
            }                                             

            Console.WriteLine("digite quantos KM tem a viagem: "); // cadastra a viagem
            viagem = Convert.ToDecimal(Console.ReadLine());
            while (viagem < 0)
            {
                Console.WriteLine("Numeros invalidos, tente novamente\n");
                viagem = Convert.ToDecimal(Console.ReadLine());
            }

            Console.WriteLine("digite se o clima for bom ou ruim"); // cadstra o clima
            string clima = Console.ReadLine().ToUpper();    
            if (clima == "ruim")
            {
                
            }                

            for(int i = 0; i < 3; i++) // faz a viagem dos carros           
            {
                Console.WriteLine($"Carro: {carros[i].Modelo} - Marca: {carros[i].Marca} - Cavalos: {carros[i].Cavalos} - País de origem: {carros[i].PaisDeOrigem} - Carro flex: {carros[i].Flex} - Combustível atual: {carros[i].QntTanqueAtual} - QntTanqueTotal: {carros[i].QntTanqueCombustivel}");
                do
                {
                    Console.Clear();
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
                } while (viagem > carros[i].viagem);
                Console.WriteLine($"O carro {carros[i].Modelo} chegou no destino, aperte enter para a próxima viagem.");
                Console.ReadLine();
            }

            for(int i = 0; i < 2; i++) // faz a viagem das motos
            {
                Console.WriteLine($"Motos:{motos[i].Modelo} - Marca: {motos[i].Marca} - Cilindradas: {motos[i].Cilindradas} - País de origem: {motos[i].PaisDeOrigem} - Moto flex: {motos[i].Flex} - Combustível atual: {motos[i].QntTanqueAtual} - QntTanqueTotal: {motos[i].QntTanqueCombustivel}");
                do
                {
                    Console.Clear();
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
                } while (viagem > motos[i].viagem);
                Console.WriteLine($"A moto {motos[i].Modelo} chegou no destino, aperte enter para a próxima viagem.");
                Console.ReadLine();
            }
        }
    }
}
