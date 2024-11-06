        string again = "a";
        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("****************************");
            Console.WriteLine("******** Obdelníky ***********");
            Console.WriteLine("****************************");
            Console.WriteLine();

            int size;
            Console.Write("Zadejte velikost obdelníku (celé kladné číslo): ");
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.Write("Nezadali jste platné celé kladné číslo. Zadejte velikost znovu: ");
                Console.WriteLine();
            }

            int rows = 4;

            for (int i = 0; i < rows; i++)
            {
                Console.Write(new string('\t', 4)); 
                for (int j = 0; j < size; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine(); 
            }

            
            Console.WriteLine(); 

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Program můžete opakovat stiskem klávesy 'a'");
            again = Console.ReadLine();
        }