using System;

namespace Aula03Csharp
{
    public class Carro : Veiculo
    {
        public int Cavalos;

        public Carro()
        {
        }
        public void Dirigir(decimal xKms, string clima)
        {

            if (xKms <= AutonomiaAtual(false, clima))
            {
                Console.WriteLine($"O carro avançou {xKms} quilometro(s).  Combustível atual : {Math.Round(Consumo(xKms, clima), 2)} litros.");
                viajar += xKms;
            }
            else
                Console.WriteLine($"O carro não possui autonomia ou combustivel suficiente. Combustível atual: {Math.Round(QntTanqueAtual, 2)} - Abasteça-o!");

        }
        public decimal Consumo(decimal xKms, string clima)
        {
            if (FiltroCombustivelEntupido && clima == "RUIM")
                return QntTanqueAtual -= xKms / (KmPorLitro - (KmPorLitro * 35 / 100));
            else if (FiltroCombustivelEntupido)
                return QntTanqueAtual -= xKms / (KmPorLitro - (KmPorLitro * 20 / 100));
            else if (clima == "RUIM")

                return QntTanqueAtual -= xKms / (KmPorLitro - (KmPorLitro * 15 / 100));
            else
                return QntTanqueAtual -= xKms / KmPorLitro;
        }
    }
}
