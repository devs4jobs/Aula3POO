using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoPOO
{
    class ClasseViagem : Veiculo
    {

        public decimal DistanciaKms;
        public string Destino;


        public ClasseViagem(decimal distanciakms, string destino, string climaruim)
        {
            DistanciaKms = distanciakms;
            Destino = destino;
            ClimaRuim = climaruim;
        }

        public ClasseViagem() { }

    }


}
