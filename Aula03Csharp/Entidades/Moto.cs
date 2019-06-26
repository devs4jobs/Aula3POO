using System;


namespace Aula03Csharp
{
    public class Moto : Veiculo
    {
        public int Cilindradas;
         
        public Moto()
        {

        }
        public void RegistraMoto()
        {
            Console.Write("Digite o modelo do moto:");
            Modelo = Console.ReadLine();
            Console.Write("Digite a marca do moto:");
            Marca = Console.ReadLine();
            Console.Write("Digite os cilindradas do moto:");
            Cilindradas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o pais de origem do moto:");
            PaisDeOrigem = Console.ReadLine();
            Console.Write("Digite o quantidade maxima de combustivel do moto:");
            QntTanqueCombustivel = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Digite o cumbustivel atual do moto:");
            QntTanqueAtual = Convert.ToDecimal(Console.ReadLine());
            Console.Write("O filtro de combustivel da moto está entupido(true/false):");
            FiltroCombustivelEntupido = Convert.ToBoolean(Console.ReadLine());
            Console.Clear();
        }
        public void Dirigir(decimal xKms,decimal Viagem)
        {
            if (AutonomiaAtual() >= xKms)
            {
                //Define termino da viajem
                viagem += xKms;
                if (viagem >= Viagem)
                {
                    xKms -= viagem - Viagem;
                    Console.WriteLine($"O moto avançou {xKms} quilometro(s). Combustível atual : {Math.Round(Consumo(xKms), 2)} litros - Abasteça-o!\n Você chegou!");
                }
                if(Math.Round(Consumo(xKms),2)==0)
                    Console.WriteLine($"O moto avançou {xKms} quilometro(s). Combustível atual : {Math.Round(Consumo(xKms), 2)} litros - Abasteça-o!\nFalta:{Viagem-viagem}");
                else Console.WriteLine($"O moto avançou {xKms} quilometro(s). Combustível atual : {Math.Round(Consumo(xKms), 2)} litros.\nFalta:{Viagem-viagem}");
            }
            else
                Console.WriteLine($"O moto avançou {AutonomiaAtual()} quilometro(s). Combustível atual : {Math.Round(Consumo(AutonomiaAtual()), 2)} litros - Abasteça-o!\nFalta:{Viagem - viagem}");
        }
        public override decimal AutonomiaAtual()
        {   
            if (Clima && FiltroCombustivelEntupido) { return QntTanqueAtual * (KmPorLitro - (KmPorLitro * 40 / 100)); }
            else if (Clima||FiltroCombustivelEntupido) { return QntTanqueAtual * (KmPorLitro - (KmPorLitro * 20 / 100)); }
            else return QntTanqueAtual * KmPorLitro;
        }
        public decimal Consumo(decimal xKms)
        {
            if (Clima && FiltroCombustivelEntupido){return QntTanqueAtual -= xKms / (KmPorLitro - (KmPorLitro * 40 / 100));}
            else if (Clima||FiltroCombustivelEntupido){return QntTanqueAtual -= xKms / (KmPorLitro - (KmPorLitro * 20 / 100));}
            else return QntTanqueAtual -= xKms / KmPorLitro;
        }
        //Impressão das caracteristicas da moto
        public override string ToString()
        {
            return "Marca:" + Marca
                + "\nModelo:" + Modelo
                + "\nTanque:" + QntTanqueCombustivel
                + "\nTanque Atual:" + QntTanqueAtual
                + "\nFlex:" + Flex
                + "\nFiltro:" + FiltroCombustivelEntupido
                +"\nPotencia:" + Cilindradas;
        }
        public void Viajando(Moto moto,decimal Viagem)
        {
            do
            {
                Console.WriteLine("Digite 1 para dirigir\nDigite 2 para abastecer\nDigite 3 para exibir a quantidade de combustível atual\nDigite 4 para ver todos os dados do veiculo");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1": { Console.WriteLine("Por quantos km's deseja dirigir ?"); moto.Dirigir(Convert.ToDecimal(Console.ReadLine()), Viagem); break; }
                    case "2": { Console.WriteLine("Quantos litros deseja abastecer ?"); moto.Abastecer(Convert.ToDecimal(Console.ReadLine())); break; }
                    case "3": { Console.WriteLine("Quantidade do tanque atual:"); Console.WriteLine($"{Math.Round(moto.QntTanqueAtual, 2)} litros \n"); break; }
                    case "4": { Console.WriteLine(moto.ToString()); break; }
                    default:
                        break;
                }
            } while (moto.viagem != Viagem);

        }
    }
}
