        string again = "a";
        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("****************************");
            Console.WriteLine("***** Přesýpací Hodiny *****");
            Console.WriteLine("****************************");
            Console.WriteLine();

            int size;
            Console.Write("Zadejte velikost přesýpacích hodin (celé kladné číslo): ");
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.Write("Nezadali jste platné celé kladné číslo. Zadejte velikost znovu: ");
            }

           
            for (int i = 0; i < size; i++)
            {
        
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                
                for (int j = 0; j < (size - i) * 2; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        
            for (int i = 1; i <= size; i++)
            {
                
                for (int j = 0; j < size - i; j++)
                {
                    Console.Write(" ");
                }
                
                for (int j = 0; j < i * 2; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Program můžete opakovat stiskem klávesy 'a'");
            again = Console.ReadLine();
        }