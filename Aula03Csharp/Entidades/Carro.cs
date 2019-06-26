using System;

namespace Aula03Csharp
{
    public class Carro : Veiculo
    {
        public int Cavalos;
        public Carro()
        {
        }
        public void RegistraCarro()
        {
            Console.Write("Digite o modelo do carro:");
            Modelo = Console.ReadLine();
            Console.Write("Digite a marca do carro:");
            Marca = Console.ReadLine();
            Console.Write("Digite os cavalos do carro:");
            Cavalos = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o pais de origem do carro:");
            PaisDeOrigem = Console.ReadLine();
            Console.Write("Digite o quantidade maxima de combustivel do carro:");
            QntTanqueCombustivel = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Digite o cumbustivel atual do carro:");
            QntTanqueAtual = Convert.ToDecimal(Console.ReadLine());
            Console.Write("O filtro de combustivel do carro está entupido(true/false):");
            FiltroCombustivelEntupido = Convert.ToBoolean(Console.ReadLine());
            Console.Clear();
        }
        public void Dirigir(decimal xKms,decimal Viagem)
        {

            if (AutonomiaAtual() >= xKms)
            {
                viagem += xKms;
                //Define termino da viajem
                if (viagem > Viagem)
                {
                    xKms -= Viagem - viagem;
                    viagem = Viagem;
                    Console.WriteLine($"Você chegou ao seu destino. Combustível atual : {Math.Round(Consumo(xKms), 2)} litros!\nFalta{Viagem-viagem}");
                }
                else if(Math.Round(Consumo(xKms),2)==0)
                    Console.WriteLine($"O carro avançou {xKms} quilometro(s). Combustível atual : {Math.Round(Consumo(xKms), 2)} litros - Abasteça-o!\nFalta{Viagem-viagem}");
                else
                    Console.WriteLine($"O carro avançou {xKms} quilometro(s). Combustível atual : {Math.Round(Consumo(xKms), 2)} litros.\nFalta:{Viagem-viagem}");
            }
            else
                Console.WriteLine($"O carro não possui combustível suficiente. Combustível atual: {Math.Round(QntTanqueAtual, 2)} - Abasteça-o!");
        }
        public override decimal AutonomiaAtual()
        {
            if (Clima && FiltroCombustivelEntupido) { return QntTanqueAtual * KmPorLitro - (KmPorLitro * 35 / 100); }
            else if (Clima) { return QntTanqueAtual * KmPorLitro - (KmPorLitro * 15 / 100); }
            else if (FiltroCombustivelEntupido) { return QntTanqueAtual * KmPorLitro - (KmPorLitro * 20 / 100); }
            else return QntTanqueAtual * KmPorLitro;
        }
        public decimal Consumo(decimal xKms)
        {

            if (FiltroCombustivelEntupido && Clima) { return QntTanqueAtual -= xKms / KmPorLitro - (KmPorLitro * 35 / 100); }
            else if (FiltroCombustivelEntupido) { return QntTanqueAtual -= xKms / KmPorLitro - (KmPorLitro * 20 / 100); }
            else if (Clima) {return QntTanqueAtual -= xKms / KmPorLitro - (KmPorLitro * 15 / 100); }
            else return QntTanqueAtual -= xKms / KmPorLitro;
        }
        //Impressão das caracteristicas dos Carros
        public override string ToString()
        {
            return "Marca:" + Marca
                + "\nModelo:" + Modelo
                + "\nTanque:" + QntTanqueCombustivel
                + "\nTanque Atual:" + QntTanqueAtual
                + "\nFlex:" + Flex
                + "\nFiltroEntupiu:" + FiltroCombustivelEntupido
                + "\nPotencia:" + Cavalos;
                
        }
        public void Viajando(Carro carro,decimal Viagem)
        {
            do
            {
                Console.WriteLine("Digite 1 para dirigir\nDigite 2 para abastecer\nDigite 3 para exibir a quantidade de combustível atual\nDigite 4 para ver todos os dados do veiculo");
                string opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1": { Console.WriteLine("Por quantos km's deseja dirigir ?"); carro.Dirigir(Convert.ToDecimal(Console.ReadLine()), Viagem); break; }
                    case "2": { Console.WriteLine("Quantos litros deseja abastecer ?"); carro.Abastecer(Convert.ToDecimal(Console.ReadLine())); break; }
                    case "3": { Console.WriteLine("Quantidade do tanque atual:"); Console.WriteLine($"{Math.Round(carro.QntTanqueAtual, 2)} litros \n"); break; }
                    case "4": { Console.WriteLine(carro.ToString()); break; }
                    default:
                        break;
                }
            } while (carro.viagem != Viagem);

        }
    }
}
