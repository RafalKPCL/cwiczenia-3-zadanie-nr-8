using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Pomyśl o liczbie z przedziału 1-20.");

        int min = 1;
        int max = 20;
        int guess;
        char answer;

        do
        {
            guess = (min + max) / 2;

            Console.WriteLine($"Czy pomyślana liczba to {guess}? Odpowiedz ujemną (<), dodatnią (>) lub zero (=).");
            answer = Console.ReadKey().KeyChar;

            if (answer == '<')
            {
                max = guess - 1;
            }
            else if (answer == '>')
            {
                min = guess + 1;
            }

        } while (answer != '=');

        Console.WriteLine($"\nOdgadłem! Pomyślana liczba to {guess}.");

        Console.ReadKey();
    }
}
