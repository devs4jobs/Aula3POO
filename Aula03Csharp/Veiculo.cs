using System;

namespace Aula03Csharp
{
    public class Veiculo
    {
        public string Marca;
        public string PaisDeOrigem;
        public decimal QntTanqueCombustivel;
        public decimal QntTanqueAtual;
        public bool Flex;
        public decimal KmPorLitro ;
        public bool FiltroCombustivelEntupido;
        public string Modelo;
        public int potencia;
        public bool climaruim;
        public decimal viajar = 0;

        public Veiculo(string marca, string paisOrigem, decimal qntTanque, bool flex)
        {
            Marca = marca;
            PaisDeOrigem = paisOrigem;
            QntTanqueCombustivel = qntTanque;
            Flex = flex;
        }

        public Veiculo()
        {

        }

        public void KmLitro(decimal kmPorLitro) { KmPorLitro = kmPorLitro; }

        public decimal AutonomiaAtual(bool moto,string clima)
        {
            if (FiltroCombustivelEntupido && clima == "RUIM")
                return QntTanqueAtual * (KmPorLitro - (KmPorLitro * 35 / 100));
            else if (FiltroCombustivelEntupido)
                return QntTanqueAtual * (KmPorLitro - (KmPorLitro * 20 / 100));
            else if (clima == "RUIM")
                return QntTanqueAtual * (KmPorLitro - (KmPorLitro * 15 / 100));
            else if (FiltroCombustivelEntupido && clima == "RUIM" && moto == true)
              return QntTanqueAtual * (KmPorLitro - (KmPorLitro * 40 / 100));
              else if (FiltroCombustivelEntupido || clima == "RUIM" && moto == true)
               return QntTanqueAtual *  (KmPorLitro - (KmPorLitro * 20 / 100));

                else return QntTanqueAtual * KmPorLitro;
        }

        public void Abastecer(decimal litros)
        {
            
            if (QntTanqueAtual == QntTanqueCombustivel)
                Console.WriteLine("Tanque cheio!");

            if (QntTanqueAtual < QntTanqueCombustivel)
                if (QntTanqueAtual + litros > QntTanqueCombustivel)
                    QntTanqueAtual = QntTanqueCombustivel;
                else
                    QntTanqueAtual += litros;
            else
                Console.WriteLine($"Carro abastecido! Tanque atual: {Math.Round(QntTanqueAtual,2)}");

            Console.WriteLine("Tanque abastecido");
        }
    }
}
