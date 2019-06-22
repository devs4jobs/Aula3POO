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
        //
        public void Dirigir(decimal xKms)
        {

            if (AutonomiaAtual() >= xKms)
                Console.WriteLine($"O moto avançou {xKms} quilometro(s). Combustível atual : {Math.Round(Consumo(xKms), 2)} litros.");
            else
                Console.WriteLine($"O moto não possui combustível suficiente. Combustível atual: {Math.Round(QntTanqueAtual, 2)} - Abasteça-o!");

        }

        public decimal Consumo(decimal xKms)
        {
            if (Clima && FiltroCombustivelEntupido)
            {
                decimal Tanque = QntTanqueAtual;
                QntTanqueAtual -= xKms / KmPorLitro + (KmPorLitro * 40 / 100);
                if (QntTanqueAtual<0)
                {
                    return Tanque;

                }
                return QntTanqueAtual;
            }
            else if (Clima||FiltroCombustivelEntupido)
            {
                decimal Tanque = QntTanqueAtual;
                QntTanqueAtual -= xKms / KmPorLitro + (KmPorLitro * 20 / 100);

            }else
                return QntTanqueAtual -= xKms / KmPorLitro;
        }
    }
}
