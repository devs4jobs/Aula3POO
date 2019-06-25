using System;


namespace Aula03Csharp
{
    public class Moto : Veiculo
    {
        public int Cilindradas;
         
        public Moto()
        {

        }
        public Moto(string marca,string pais,decimal qnttanque,bool flex,decimal qtdAtual, bool filtro, int cilindradas):base(marca,pais,qnttanque,flex,qtdAtual,filtro)
        {
            Cilindradas = cilindradas;
        }
        public void Dirigir(decimal xKms,decimal Viagem)
        {

            if (AutonomiaAtual() >= xKms)
            {
                viagem += xKms;
                if (viagem > Viagem)
                {
                    viagem = Viagem;
                    Console.WriteLine("Você ja chegou ao destino");
                }
                if(Math.Round(Consumo(xKms),2)==0)
                    Console.WriteLine($"O moto avançou {xKms} quilometro(s). Combustível atual : {Math.Round(Consumo(xKms), 2)} litros - Abasteça-o!");
                else Console.WriteLine($"O moto avançou {xKms} quilometro(s). Combustível atual : {Math.Round(Consumo(xKms), 2)} litros.");
            }
            else
                Console.WriteLine($"O moto não possui combustível suficiente. Combustível atual: {Math.Round(QntTanqueAtual, 2)} - Abasteça-o!");

        }
        public override decimal AutonomiaAtual()
        {
            if (Clima && FiltroCombustivelEntupido) { return QntTanqueAtual * (KmPorLitro - (KmPorLitro * 40 / 100)); }
            else if (Clima||FiltroCombustivelEntupido) { return QntTanqueAtual * (KmPorLitro - (KmPorLitro * 20 / 100)); }
            else return QntTanqueAtual * KmPorLitro;
        }
        public decimal Consumo(decimal xKms)
        {
            if (Clima && FiltroCombustivelEntupido){return QntTanqueAtual -= xKms / (KmPorLitro +(KmPorLitro * 40 / 100));}
            else if (Clima||FiltroCombustivelEntupido){return QntTanqueAtual -= xKms / (KmPorLitro + (KmPorLitro * 20 / 100));}
            else return QntTanqueAtual -= xKms / KmPorLitro;
        }
        public override string ToString()
        {
            return "Marca:" + Marca
                + "\nTanque:" + QntTanqueCombustivel
                + "\nTanque Atual:" + QntTanqueAtual
                + "\nFlex:" + Flex
                + "\nFiltroEntupiu:" + FiltroCombustivelEntupido
                + "\nPotencia:" + Cilindradas;

        }
    }
}
