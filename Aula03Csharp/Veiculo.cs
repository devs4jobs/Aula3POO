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
        public decimal KmPorLitro = 8;
        public bool Clima;
        public bool FiltroCombustivelEntupido;

        public Veiculo(string marca, string paisOrigem, decimal qntTanque, bool flex,decimal qtdAtual)
        {

            Marca = marca;
            PaisDeOrigem = paisOrigem;
            QntTanqueCombustivel = qntTanque;
            Flex = flex;
            QntTanqueAtual = qtdAtual;
        }

        public Veiculo()
        {

        }

        public void KmLitro(decimal kmPorLitro) { KmPorLitro = kmPorLitro; }

        public decimal AutonomiaAtual() { return QntTanqueAtual * KmPorLitro; }

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

            Console.WriteLine("Tanque cheio!");
        }
    }
}
