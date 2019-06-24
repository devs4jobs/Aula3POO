using System;
using System.Collections.Generic;
using System.Text;

namespace Aula03Csharp
{
    class Clima : Veiculo
    {

        public int Cavalos;
        public bool ClimaRuim;
     
        public void Dirigir(double xKms)
        {

            if (AutonomiaAtual() >= xKms)
                Console.WriteLine($"O carro avançou {xKms} quilometro(s). Combustível atual : {Math.Round(Consumo(xKms), 2)} litros.");
            else
                Console.WriteLine($"O carro não possui combustível suficiente. Combustível atual: {Math.Round(QntTanqueAtual, 2)} - Abasteça-o!");

        }

        public double Consumo(double xKms)
        {
            if (ClimaRuim)
                return QntTanqueAtual -= xKms / KmPorLitro + (KmPorLitro * 20 / 100);
            else
                return QntTanqueAtual -= xKms / KmPorLitro;

        }

    }
}
