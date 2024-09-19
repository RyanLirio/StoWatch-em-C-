using System;
using System.Net.NetworkInformation;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main (string[] args)
        {
            Menu();

        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Se desejar contar em segundos, digite -> 10s");
            Console.WriteLine("Se desejar contar em minutos, digite -> 10m");
            Console.WriteLine("Se desejar sair, digite -> 0");
            Console.WriteLine("Quanto tempo você deseja contar?");

            String hour = Console.ReadLine().ToLower();
            char type = char.Parse(hour.Substring(hour.Length-1, 1));
            

            int timeR = int.Parse(hour.Substring(0, hour.Length-1));


            int multiplier = 1;

            if(type == 'm')
            {
                multiplier = 60;
            }
            if(type == 0)
            {
                System.Environment.Exit(0);
            }

            PreStart((timeR*multiplier));
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Preparar..");
            Thread.Sleep(1000);
            Console.WriteLine("Apontar...");
            Thread.Sleep(1000);
            Console.WriteLine("Já!");
            Thread.Sleep(1000);

            Start(time);
        }

        static void Start(int time)
        {
            int currentTime = 0;
            
            while(currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine (currentTime);
                Thread.Sleep(1000);
            }
            Console.Clear();
            End();
        } 
    
        static void End()
        {
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Seu tempo acabou");
            Thread.Sleep(1000);

            Menu();
        }

    }
}