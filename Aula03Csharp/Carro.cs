﻿using System;

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

            if (qtdeKm() >= xKms)
            {
                Console.WriteLine($"O carro avançou {xKms} quilometro(s). Combustível atual : {Math.Round(Consumo(xKms, clima), 2)} litros.");
                viajado += xKms;
            }
            else
            {           
                Console.WriteLine($"O carro avançou {qtdeKm()} quilometro(s). Combustível atual : {0} litros. - Abasteça-o!");
                QntTanqueAtual = 0;
                viajado += qtdeKm();
            }
        }

        public decimal Consumo(decimal xKms, string clima)
        {
            
              if (filtro == "SIM" && clima == "RUIM")
                return QntTanqueAtual -= xKms / (KmPorLitro + (KmPorLitro * 35 / 100));

            else if (filtro == "SIM")
                return QntTanqueAtual -= xKms / (KmPorLitro + (KmPorLitro * 15 / 100));

            else if (clima == "RUIM")
                return QntTanqueAtual -= xKms / (KmPorLitro + (KmPorLitro * 20 / 100));
          
            else
                return QntTanqueAtual -= xKms / KmPorLitro;

        }


    }
}
