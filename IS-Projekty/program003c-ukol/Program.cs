
        string again = "a";
        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("****************************");
            Console.WriteLine("******** Písmeno N *********");
            Console.WriteLine("****************************");
            Console.WriteLine();

            int size;
            Console.Write("Zadejte velikost písmena N (celé kladné číslo): ");
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.Write("Nezadali jste platné celé kladné číslo. Zadejte velikost znovu: ");
            }

            
            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    
                    if (x == 0 || x == size - 1 || x == y)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  "); 
                    }
                }
                Console.WriteLine(); 
            }

            Console.WriteLine();
            Console.WriteLine("Program můžete opakovat stiskem klávesy 'a'");
            again = Console.ReadLine();
        }