using System;
namespace Zadanie1

{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name = "Tomasz";
            string LastName = "Pszeniczka";
            int Age = 38;
            char Sex = 'm';
            long Pesel = 84111111111;
            long EmployeeNumber = 2509324094;

            Console.WriteLine($"Imię: {Name}");
            Console.WriteLine($"Nazwisko: {LastName}");
            Console.WriteLine($"Wiek: {Age}");
            Console.WriteLine($"Płeć: {Sex}");
            Console.WriteLine($"PESEL: {Pesel}");
            Console.WriteLine($"Numer pracownika: {EmployeeNumber}");


        }
    }
}