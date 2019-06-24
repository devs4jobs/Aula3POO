using System;
using System.Collections.Generic;
using System.Text;

namespace Aula03Csharp
{
    public class Moto : Veiculo
    {
        public int Cilindradas;

        public Moto(string modelo, string marca, string paisOrigem, double qntTanque, bool flex, double qtdTanqueCombustivel, int cilindradas)
        {
            Modelo = modelo;
            Marca = marca;
            PaisDeOrigem = paisOrigem;
            QntTanqueAtual = qntTanque;
            Flex = flex;
            QntTanqueCombustivel = qtdTanqueCombustivel;
            Cilindradas = cilindradas;
        }

        public Moto (int cilindradas)
        {
            
        }

    }
}
 