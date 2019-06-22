using System;
using System.Collections.Generic;
using System.Text;

namespace Aula03Csharp
{
    class Metedos
    {
        public string Marca;
        public string PaisDeOrigem;
        public double QntTanqueCombustivel;
        public double QntTanqueAtual;
        public bool Flex;
        public double KmPorLitro = 8;
        string[] vet = new string[3];
        public List<Carro> CadastroCarros(string Marca, string PaisDeOrigem, double QntTanqueCombustivel, double QntTanqueAtual, bool Flex, double KmPorLitro)
        {

            for (int i = 0; i < 3; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                this.Marca = vet[0];
                this.PaisDeOrigem = vet[1];
                this.QntTanqueCombustivel = Convert.ToDouble(vet[2]);
                this.QntTanqueAtual = Convert.ToDouble(vet[3]);
                this.Flex = Convert.ToBoolean(vet[4]);
                this.KmPorLitro = Convert.ToDouble(vet[5]);

                Console.WriteLine("Insira a : Marca , Pais de Origem , Quantidade Maxima do tanque de Combustivél , Quantidade Atual do Tanque , se ele é Flex ou não , Km por Litros");



            }

        }
        public void CadastroCarros()
        {

        }
    }
}
