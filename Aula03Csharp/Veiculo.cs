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
        public virtual decimal Consumo(decimal xKms, string clima)
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
                Console.WriteLine($"Carro abastecido! Tanque atual: {Math.Round(QntTanqueAtual, 2)}");

            Console.WriteLine("Tanque abastecido");
        }

        public decimal ValidacaoDeci(decimal valor)
        {
            QntTanqueCombustivel = valor;
            KmPorLitro = valor;
            QntTanqueAtual = valor;
            if (valor < 0)
            {
                while (valor < 0)
                {
                    Console.WriteLine("Insira um valor válido\n");
                    valor = decimal.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
                return valor;
            }
            else
                return valor;

        }

        public virtual int ValidacaoInt(int valor)
        {
            if (valor < 0)
            {
                while (valor < 0)
                {
                    Console.WriteLine("Insira um valor válido\n");
                    valor = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
                return valor;
            }
            else
                return valor;
        }
    }


    public class Carro : Veiculo
    {
        public int Cavalos;

        public Carro()
        {
        }
        public void Dirigir(decimal xKms, string clima)
        {

            if (xKms <= AutonomiaAtual(false, clima))
            {
                Console.WriteLine($"O carro avançou {xKms} quilometro(s).  Combustível atual : {Math.Round(Consumo(xKms, clima), 2)} litros.");
                viajar += xKms;
            }
            else
                Console.WriteLine($"O carro não possui autonomia ou combustivel suficiente. Combustível atual: {Math.Round(QntTanqueAtual, 2)}Litros - Abasteça-o!");
        }

        public override decimal Consumo(decimal xKms, string clima)
        {
            if (FiltroCombustivelEntupido && clima == "RUIM")
                return QntTanqueAtual * (KmPorLitro - (KmPorLitro * 35 / 100));
            else if (FiltroCombustivelEntupido)
                return QntTanqueAtual * (KmPorLitro - (KmPorLitro * 20 / 100));
            else if (clima == "RUIM")
                return QntTanqueAtual * (KmPorLitro - (KmPorLitro * 15 / 100));
            else
                return QntTanqueAtual -= xKms / KmPorLitro;
        }

        public override int ValidacaoInt(int valor)
        {
            Cavalos = valor;
            if (valor < 0)
            {
                while (valor < 0)
                {
                    Console.WriteLine("Insira um valor válido\n");
                    valor = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
                return valor;
            }
            else
                return valor;
        }

    }

    public class Moto : Veiculo
    {
        public int Cilindradas;
        public Moto()
        {

        }
        public void Dirigir(decimal xKms, string clima)
        {
            viajar += xKms;

            if (xKms <= AutonomiaAtual(true, clima))
                Console.WriteLine($"A moto avançou {xKms} quilometro(s). Combustível atual : {Math.Round(Consumo(xKms, clima), 2)} litros.");
            else
                Console.WriteLine($"A moto não possui combustível suficiente. Combustível atual: {Math.Round(QntTanqueAtual, 2)}Litros  -  Abasteça-a!");
        }
        public override decimal Consumo(decimal xKms, string clima)
        {
            if (FiltroCombustivelEntupido && clima == "RUIM")
                return QntTanqueAtual -= xKms / (KmPorLitro - (KmPorLitro * 40 / 100));
            else if (FiltroCombustivelEntupido || clima == "RUIM")
                return QntTanqueAtual -= xKms / (KmPorLitro - (KmPorLitro * 20 / 100));
            else
                return QntTanqueAtual -= xKms / KmPorLitro;

        }

        public override int ValidacaoInt(int valor)
        {
            Cilindradas = valor;
            if (valor < 0)
            {
                while (valor < 0)
                {
                    Console.WriteLine("Insira um valor válido\n");
                    valor = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
                return valor;
            }
            else
                return valor;
        }

    }

}
