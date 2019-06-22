using System;
using System.Collections.Generic;
using System.Text;

namespace Aula03Csharp
{
    public class Moto : Veiculo
    {
        public int Cilindradas;
        public bool FiltroCombustivelEntupido;
        public string Modelo;

        public Moto()
        {
        }
        public void Dirigir(decimal xKms)
        {

            if (AutonomiaAtual() >= xKms)
                Console.WriteLine($"A moto avançou {xKms} quilometro(s). Combustível atual : {Math.Round(Consumo(xKms), 2)} litros.");
            else
                Console.WriteLine($"A moto não possui combustível suficiente. Combustível atual: {Math.Round(QntTanqueAtual, 2)} - Abasteça-o!");
        }

        public decimal Consumo(decimal xKms)
        {
            if (FiltroCombustivelEntupido)
                return QntTanqueAtual -= xKms / KmPorLitro + (KmPorLitro * 20 / 100);
            else
                return QntTanqueAtual -= xKms / KmPorLitro;

        }
    }
}
