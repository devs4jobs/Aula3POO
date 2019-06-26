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
        public bool FiltroCombustivelEntupido;
        public string Modelo;
        public decimal KmPorLitro = 8;
        public bool climaruim;
        public decimal viagem =0;


        public Veiculo(string marca, string paisOrigem, decimal qntTanque, bool flex, string modelo)
        {

            Marca = marca;
            PaisDeOrigem = paisOrigem;
            QntTanqueCombustivel = qntTanque;
            Flex = flex;
            Modelo = modelo;
        }

        public Veiculo()
        {

        }

        public void KmLitro(decimal kmPorLitro) { KmPorLitro = kmPorLitro; }

        public decimal AutonomiaAtual(bool moto, string clima)
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
                return QntTanqueAtual * (KmPorLitro - (KmPorLitro * 20 / 100));

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
                Console.WriteLine($"Veiculo abastecido! Tanque atual: {Math.Round(QntTanqueAtual,2)}");

            Console.WriteLine("Tanque cheio!");
        }
    }
}
