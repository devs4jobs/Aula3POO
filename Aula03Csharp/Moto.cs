using System;
using System.Collections.Generic;
using System.Text;

namespace Aula03Csharp
{
    public class Moto : Veiculo
    {
        public int Cilindradas;
        public Moto()
        {

        }
        public void Dirigir(decimal xKms, string clima)
        {
            Console.WriteLine($"O carro não possui autonomia ou combustivel suficiente. Combustível atual: {Math.Round(QntTanqueAtual, 2)} - Abasteça-o!");

            if (xKms <= AutonomiaAtual(true, clima))
            {
                Console.WriteLine($"A moto avançou {xKms} quilometro(s). Combustível atual : {Math.Round(Consumo(xKms, clima), 2)} litros.");
                viajar += xKms;
            }
            else
                Console.WriteLine($"A moto não possui combustível suficiente. Combustível atual: {Math.Round(QntTanqueAtual, 2)} - Abasteça-a!");
        }
        public decimal Consumo(decimal xKms, string clima)
        {

            if (FiltroCombustivelEntupido && clima == "RUIM")
                return QntTanqueAtual -= xKms / (KmPorLitro - (KmPorLitro * 40 / 100));
            else if (FiltroCombustivelEntupido || clima == "RUIM")
                return QntTanqueAtual -= xKms / (KmPorLitro - (KmPorLitro * 20 / 100));
            else
                return QntTanqueAtual -= xKms / KmPorLitro;

        }

    }
}
