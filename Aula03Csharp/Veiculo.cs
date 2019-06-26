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
        public decimal KmPorLitro;
        public bool FiltroCombustivelEntupido;
        public string Modelo;
        public int potencia;
        public bool climaruim;
        public decimal viajar = 0;


        public Veiculo()
        {

        }
        // kmlitro
        public void KmLitro(decimal kmPorLitro) { KmPorLitro = kmPorLitro; }

        //  método autonomia maxima do carro
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
        // método de abastecimento dos veiculos
        public void Abastecer(decimal litros)
        {

            if (QntTanqueAtual == QntTanqueCombustivel)
                Console.WriteLine("TANQUE CHEIO!\n");

            if (QntTanqueAtual < QntTanqueCombustivel)
                if (QntTanqueAtual + litros > QntTanqueCombustivel)
                    QntTanqueAtual = QntTanqueCombustivel;
                else
                    QntTanqueAtual += litros;
            else
                Console.WriteLine($"CARRO ABASTECIDO! TANQUE ATUAL:\n {Math.Round(QntTanqueAtual, 2)}");

            Console.WriteLine("TANQUE ABASTECIDO\n");
        }
    }
}
