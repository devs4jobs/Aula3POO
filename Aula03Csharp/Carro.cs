﻿using System;

namespace Aula03Csharp
{
    public class Carro : Veiculo
    {
        public int Cavalos;
        public bool FiltroCombustivelEntupido;
        public string Modelo;
        public Carro()
        {
        }

        public void Dirigir(decimal xKms)
        {

            if (AutonomiaAtual() >= xKms)
                Console.WriteLine($"O carro avançou {xKms} quilometro(s). Combustível atual : {Math.Round(Consumo(xKms),2)} litros.");
            else
                Console.WriteLine($"O carro não possui combustível suficiente. Combustível atual: {Math.Round(QntTanqueAtual,2)} - Abasteça-o!");

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
