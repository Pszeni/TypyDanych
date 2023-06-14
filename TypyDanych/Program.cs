using System;
namespace Zadanie1

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ZADANIE 1
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
            Console.WriteLine();

            //ZADANIE 2
            char Zmienna1 = 'A';
            char Zmienna2 = 'B';
            char Zmienna3 = 'C';

            Console.WriteLine($"{Zmienna3}{Zmienna2}{Zmienna1}");

            //ZADANIE 3

            double A, B, D ;
            Console.WriteLine("Program obliczający długość przekątnej prostokąta");
            Console.WriteLine();

            Console.WriteLine("Podaj długość boku a ");
            double.TryParse(Console.ReadLine(), out A);

            Console.WriteLine("Podaj długość boku b ");
            double.TryParse(Console.ReadLine(), out B);

            A = Math.Pow(A, 2);
            B = Math.Pow(B, 2);
            D = A+B;
           
            Console.WriteLine($"Długość przekątnej prostokąta wynosi:{Math.Sqrt(D)} ");

        }
    }
}