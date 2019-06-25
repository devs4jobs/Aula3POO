using System;

namespace Aula03Csharp
{
    public class Carro : Veiculo
    {
        public int Cavalos;
        public string Modelo;
        public Carro()
        {
        }
        public Carro(string marca,string paisOrigem,decimal QtTanque,bool flex,decimal QtdAtual, bool filtro, int cavalos,string modelo) : base(marca, paisOrigem, QtTanque, flex, QtdAtual,filtro)
        {
            Cavalos = cavalos;
            Modelo = modelo;
        }

        public void Dirigir(decimal xKms,decimal Viagem)
        {

            if (AutonomiaAtual() >= xKms)
            {
                viagem += xKms;
                if (viagem > Viagem)
                {
                    viagem = Viagem;
                    Console.WriteLine("Você ja chegou ao seu destino");
                }
                if(Math.Round(Consumo(xKms),2)==0)
                    Console.WriteLine($"O carro avançou {xKms} quilometro(s). Combustível atual : {Math.Round(Consumo(xKms), 2)} litros - Abasteça-o!");
                else
                    Console.WriteLine($"O carro avançou {xKms} quilometro(s). Combustível atual : {Math.Round(Consumo(xKms), 2)} litros.");
            }
            else
                Console.WriteLine($"O carro não possui combustível suficiente. Combustível atual: {Math.Round(QntTanqueAtual, 2)} - Abasteça-o!");
        }
        public override decimal AutonomiaAtual()
        {
            if (Clima && FiltroCombustivelEntupido) { return QntTanqueAtual * KmPorLitro - (KmPorLitro * 40 / 100); }
            else if (Clima) { return QntTanqueAtual * KmPorLitro - (KmPorLitro * 15 / 100); }
            else if (FiltroCombustivelEntupido) { return QntTanqueAtual * KmPorLitro - (KmPorLitro * 20 / 100); }
            else return QntTanqueAtual * KmPorLitro;
        }
        public decimal Consumo(decimal xKms)
        {

            if (FiltroCombustivelEntupido && Clima) { return QntTanqueAtual -= xKms / KmPorLitro - (KmPorLitro * 35 / 100); }
            else if (FiltroCombustivelEntupido) { return QntTanqueAtual -= xKms / KmPorLitro - (KmPorLitro * 20 / 100); }
            else if (Clima) {return QntTanqueAtual -= xKms / KmPorLitro - (KmPorLitro * 15 / 100); }
            else return QntTanqueAtual -= xKms / KmPorLitro;
        }
        public override string ToString()
        {
            return "Marca:" + Marca
                + "\nModelo:" + Modelo
                + "\nTanque:" + QntTanqueCombustivel
                + "\nTanque Atual:" + QntTanqueAtual
                + "\nFlex:" + Flex
                + "\nFiltroEntupiu:" + FiltroCombustivelEntupido
                + "\nPotencia:" + Cavalos;
                
        }

    }
}
