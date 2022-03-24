using System;

namespace PeriodosAtraz.ConsoleApp
{
    internal class Program
    {
      
        static void Main(string[] args)
        {

            DateTime data = new DateTime(2001, 05, 27, 03, 02, 30);
            //DateTime data = new DateTime(2022, 03, 24, 01, 18, 23);

            ConversorOficial conversor = new ConversorOficial(data);

            Console.WriteLine(conversor.diasPorExtenso);
        }

    }
}
