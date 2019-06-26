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

    }
}
