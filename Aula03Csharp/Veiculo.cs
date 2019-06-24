using System;

namespace Aula03Csharp
{
    public class Veiculo 
    {

        public string Modelo;
        public string Marca;
        public string PaisDeOrigem;
        public double QntTanqueCombustivel;
        public double QntTanqueAtual;
        public bool Flex;
        public double KmPorLitro = 8;

        public Veiculo(string marca, string paisOrigem, double  qntTanque, bool flex)
        {

            Marca = marca;
            PaisDeOrigem = paisOrigem;
            QntTanqueCombustivel = qntTanque;
            Flex = flex;

        }
        public Veiculo()
        {

        }
        public void KmLitro(double kmPorLitro) { KmPorLitro = kmPorLitro; }

        public double AutonomiaAtual() { return QntTanqueAtual * KmPorLitro; }

        public void Abastecer(double  litros)
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
