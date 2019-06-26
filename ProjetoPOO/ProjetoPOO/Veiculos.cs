using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoPOO
{
    public class Veiculo
    {
        public string Marca;
        public string Modelo;
        public string PaisDeOrigem;
        public decimal QntTanqueCombustivel;
        public decimal QntTanqueAtual;
        public bool Flex;
        public decimal KmPorLitro = 8;
        public bool FiltroCombustivelEntupido;
        public string ClimaRuim;




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
                Console.WriteLine($"Carro abastecido! Tanque atual: {Math.Round(QntTanqueAtual, 2)}");

            Console.WriteLine("Tanque cheio!");
        }

        public virtual void Dirigir(decimal CarroAndouKms)
        {
            if (AutonomiaAtual() >= CarroAndouKms)
            {
                Console.WriteLine($"O carro avançou {CarroAndouKms} quilometro(s). Combustível atual : {Math.Round(Consumo(CarroAndouKms), 2)} litros.");
                CarroAndouKms += CarroAndouKms;
            }
            else
                Console.WriteLine($"O carro não possui combustível suficiente. Combustível atual: {Math.Round(QntTanqueAtual, 2)} Litros -  Abasteça-o!");

        }

        public decimal Consumo(decimal CarroAndouKms)
        {
            if (FiltroCombustivelEntupido && ClimaRuim == "SIM")
                return QntTanqueAtual -= CarroAndouKms / KmPorLitro - (KmPorLitro * 35 / 100);
            else if (ClimaRuim == "SIM")
                return QntTanqueAtual -= CarroAndouKms / KmPorLitro - (KmPorLitro * 15 / 100);
            else if (FiltroCombustivelEntupido)
                return QntTanqueAtual -= CarroAndouKms / KmPorLitro - (KmPorLitro * 20 / 100);
            else
                return QntTanqueAtual -= CarroAndouKms / KmPorLitro;

        }
        public decimal ConsumoMoto(decimal CarroAndouKms)
        {
            if (FiltroCombustivelEntupido && ClimaRuim == "SIM")
                return QntTanqueAtual -= CarroAndouKms / KmPorLitro - (KmPorLitro * 40 / 100);
            else if (FiltroCombustivelEntupido || ClimaRuim == "SIM")
                return QntTanqueAtual -= CarroAndouKms / KmPorLitro - (KmPorLitro * 20 / 100);
            else
                return QntTanqueAtual -= CarroAndouKms / KmPorLitro;

        }
    }


    public class Carro : Veiculo
    {
        public int Cavalos;

        public Carro()
        {
        }



    }

    public class Moto : Veiculo
    {
        public int Cilindradas;

        public Moto()
        {

        }

    }



}

