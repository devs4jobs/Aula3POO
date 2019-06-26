using System;
using System.Collections.Generic;
using System.Globalization;
namespace Aula03Csharp
{
    class Program
    {
        static void Main(string[] args)
        {   bool clima=false;
            decimal Viagem=0;
            int i;
            List<Carro> Carros = new List<Carro>();
            List<Moto> Motos = new List<Moto>();
            //registro carro
            for(i=0;i<3;i++)
            {
                try
                {
                    Carro carrinho = new Carro();
                    carrinho.RegistraCarro();
                    Carros.Add(carrinho);
                }catch(Exception e){
                    Console.WriteLine("Digite valor valido");
                    Console.WriteLine(e.Message);
                    i--;
                }
            } 
            //registro moto
            for(i=0;i<2;i++)
            {
                try
                {
                    Moto motinha= new Moto();
                    motinha.RegistraMoto();
                    Motos.Add(motinha);
                }
                catch (Exception e) {
                    Console.WriteLine("Digite valor valido");
                    Console.WriteLine(e.Message);
                    i--;
                }
            }
            do
            {
                try
                {
                    //Tamanho da Viajem
                    Console.Write("Digite o tamanho da viagem:");
                    Viagem = Convert.ToDecimal(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                catch (Exception e) { Console.WriteLine(e.Message); }
            } while (Viagem <= 0);
            //Controle do clima
            Console.Write("Qual o clima da viajem(bom/ruim):");
            string estado = Console.ReadLine();
            if (estado.ToUpper() == "RUIM")
                clima = true;
            //Viagens Carros
            for (i = 0; i < 3; i++)
            {
                Carros[i].Clima = clima;
                Carros[i].Viajando(Carros[i], Viagem);
            }
            //Viagens Motos
            for (i = 0; i < 2; i++)
            {
                Motos[i].Clima = clima;
                Motos[i].Viajando(Motos[i], Viagem);
            }
            Console.Write("Completou a viajem!");
            Console.ReadLine();
        }
    }
}
