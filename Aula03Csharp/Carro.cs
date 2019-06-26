using System;

namespace Aula03Csharp
{
    public class Carro : Veiculo
    {
        public int Cavalos;

        public Carro()
        {
        }
        // metodos de dirigir e comsumo
        public void Dirigir(decimal xKms, string clima)
        {

            if  (xKms <= AutonomiaAtual(false,clima) )
            {
                Console.WriteLine($"O CARRO AVANÇOU {xKms} QUILOMETRO(S).  COMBUSTIVEL ATUAL : {Math.Round(Consumo(xKms, clima), 2)} LITROS.");
                viajar += xKms;
            }
            else
                Console.WriteLine($"O CARRO NAO POSSUI AUTONOMIA OU COMBUSTIVEL SUFICIENTE, RODE E ABASTESÇA OU ABASTEÇA \n {Math.Round(QntTanqueAtual, 2)} ");
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
