using System;
using System.Security.Principal;

class Program
{
    static void Main(string[] args)
    {
        string again = "a";
        while (again == "a")
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("******* Generátor pseudonáhodných čísel *******");
            Console.WriteLine("***********************************************");
            Console.WriteLine("**************** Jakub Samek ******************");
            Console.WriteLine("***********************************************\n\n");
            Console.WriteLine();

            Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.Write("Nezadali jste celé číslo. Zadejte počet čísel znovu (celé číslo): ");
            }

            Console.Write("Zadejte dolní mez (celé číslo): ");
            int dm;
            while (!int.TryParse(Console.ReadLine(), out dm))
            {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez (celé číslo): ");
            }

            Console.Write("Zadejte horní mez (celé číslo): ");
            int hm;
            while (!int.TryParse(Console.ReadLine(), out hm))
            {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu horní mez (celé číslo): ");
            }

            Console.WriteLine("\n\n====================");
            Console.WriteLine("Uživatelský vstup: ");
            Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dm, hm);
            Console.WriteLine("====================\n\n");

            int[] myArray = new int[n];

            Random randomNumber = new Random();

            Console.WriteLine("Náhodná čísla: ");

            for (int i = 0; i < n; i++)
            {
                myArray[i] = randomNumber.Next(dm, hm + 1);
                Console.Write("{0}; ", myArray[i]);
            }

            int minValue = myArray[0];
            int maxValue = myArray[0];
            int minIndex = 0;
            int maxIndex = 0;

            for (int i = 1; i < n; i++)
            {
                if (myArray[i] < minValue)
                {
                    minValue = myArray[i];
                    minIndex = i;
                }
                if (myArray[i] > maxValue)
                {
                    maxValue = myArray[i];
                    maxIndex = i;
                }
            }

            Console.WriteLine("\n\nNejmenší číslo: {0} (index: {1})", minValue, minIndex);
            Console.WriteLine("Největší číslo: {0} (index: {1})", maxValue, maxIndex);

            // Opakování programu
            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }
}