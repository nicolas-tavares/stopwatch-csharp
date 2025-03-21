using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundos  (10s = 10 segundos)");
            Console.WriteLine("M = Minutos  (1m = 1 minuto)");
            Console.WriteLine("0s = Sair do Stopwatch");
            Console.WriteLine("\nQuanto tempo deseja contar ?");

            string data = Console.ReadLine().ToLower(); //Armazena dentro de "data" o que o usuário escreveu (e transforma em minusculo, caso insira em maiusculo)
            char type = char.Parse(data.Substring(data.Length - 1, 1)); //Seleciona o último caracter que o usuario digitou e armazena no "type" ("s" ou "m")
            int time = int.Parse(data.Substring(0, data.Length - 1)); //Seleciona todos os outros caracteres que o usuario digitou ignorando o último e armazenando em "time"

            /*
            // Para testar

            Console.WriteLine(data); 
            Console.WriteLine(type);
            Console.WriteLine(time);
            */

            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;


            if (time == 0)
                System.Environment.Exit(0);

            Start(time * multiplier, data);

        }

        static void Start(int time, string data)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                Console.WriteLine($"STOPWATCH - até {data}\n");
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000); //Esperar 1seg para mostrar o próximo número
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado... Retornando para o menu");
            Thread.Sleep(4000);

            Menu();

        }
    }
}
