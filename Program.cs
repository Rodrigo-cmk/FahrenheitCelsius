using System;

namespace FahrenheitCelsius
{
    class Program
    {
        static void Main(string[] args)
        {





           string F;
           double C, C2;

           Console.WriteLine();
           Console.WriteLine();
           Console.WriteLine("---------------------------------");
           Console.WriteLine("Conversor Fahrenheit para Celsius");
           Console.WriteLine("---------------------------------");
           Console.WriteLine();
           Console.WriteLine(" - Digite o valor a ser convertido...");
           Console.WriteLine();

           F = Console.ReadLine();
           Console.WriteLine();
           
           C = Convert.ToDouble(F);
           C2 = (C-32)*5/9;


           Console.WriteLine("Conversão:");
           Console.WriteLine($"{C2:N2} °C");



            
            
            
            




















        }
    }
}
