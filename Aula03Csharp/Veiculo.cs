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
        public bool FiltroCombustivelEntupido;
        public decimal viagem = 0;
        public bool Clima;
        public Veiculo(string marca, string paisOrigem, decimal qntTanque, bool flex,decimal qtdAtual,bool filtro)
        {

            Marca = marca;
            PaisDeOrigem = paisOrigem;
            QntTanqueCombustivel = qntTanque;
            Flex = flex;
            QntTanqueAtual = qtdAtual;
            FiltroCombustivelEntupido = filtro;
        }

        public Veiculo()
        {

        }

        public void KmLitro(decimal kmPorLitro) { KmPorLitro = kmPorLitro; }

        public virtual decimal AutonomiaAtual()
        {
            if (Clima && FiltroCombustivelEntupido){return QntTanqueAtual * KmPorLitro - (KmPorLitro * 40 / 100);}
            if (Clima) { return QntTanqueAtual * KmPorLitro - (KmPorLitro * 20 / 100); }
            return QntTanqueAtual * KmPorLitro;
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

            Console.WriteLine("Tanque cheio!");
        }
    }
}
