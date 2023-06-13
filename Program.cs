using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConraditoAirlines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mes1 = "08 - Agosto";
            string mes2 = "09 - Setembro";
            string mes3 = "10 - Outubro";
            int dia1 = 6;
            int dia2 = 21;

            Console.WriteLine("Boas vindas ao sistema de viagens ConraditoAirlines\n");
            Console.WriteLine("Por favor escolha o número de um dos três meses:");
            Console.WriteLine($"{mes1}");
            Console.WriteLine($"{mes2}");
            Console.WriteLine($"{mes3}");
            int mes = int.Parse(Console.ReadLine());
            if (mes < 8 || mes > 10)
            {

                Console.WriteLine("Mês invalido");
                Main(null);
                return;

            }
            else
            {
                Console.WriteLine("Prosseguindo no registro");
            }
            Console.WriteLine($"Agora escolhe um dia entre dos dias {dia1} e {dia2}");
            int dia = int.Parse(Console.ReadLine());
            if (dia < 6 || dia > 21)
            {
                Console.WriteLine("Dia inválido!");
                Main(null);
                return;
            }
            Console.WriteLine("\nEm qual período deseja comprar a passagem?");
            Console.WriteLine("As opções são:");
            Console.WriteLine("•Tarde");
            Console.WriteLine("•Manhã");
            Console.WriteLine("•Noite");
            string periodo = Console.ReadLine();
            if (periodo == "Noite" || periodo == "Manhã" || periodo == "Tarde" || periodo == "noite" || periodo == "manhã" || periodo == "tarde")
            {

                Console.WriteLine($"Parabéns sua passagem foi comprada com sucesso no dia {dia}, mês {mes} e período {periodo} ");

            }
           

            Console.ReadKey();






        }
    }
}
