using System;

namespace Aula03Csharp
{
    public class Carro : Veiculo
    {
        public int Cavalos;
        public bool FiltroCombustivelEntupido;

        public Carro(string modelo, string marca, string paisOrigem, double qntTanque, bool flex, double qtdTanqueCombustivel,int cavalinho)
        {
            Modelo = modelo;
            Marca = marca;
            PaisDeOrigem = paisOrigem;
            QntTanqueAtual = qntTanque;
            Flex = flex;
            QntTanqueCombustivel = qtdTanqueCombustivel;
            Cavalos = cavalinho;
        }

        public Carro(int cavalos)
        {
            Cavalos = cavalos;
        }

        public void Dirigir(double xKms)
        {

            if (AutonomiaAtual() >= xKms)
                Console.WriteLine($"O carro avançou {xKms} quilometro(s). Combustível atual : {Math.Round(Consumo(xKms),2)} litros.");
            else
                Console.WriteLine($"O carro não possui combustível suficiente. Combustível atual: {Math.Round(QntTanqueAtual,2)} - Abasteça-o!");

        }

        public double Consumo(double xKms)
        {
            if (FiltroCombustivelEntupido)
                return QntTanqueAtual -= xKms / KmPorLitro + (KmPorLitro * 20 / 100);
            else
                return QntTanqueAtual -= xKms / KmPorLitro;

        }

    }
}
