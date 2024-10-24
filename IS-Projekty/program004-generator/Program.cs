﻿using System.Threading.Tasks.Dataflow;

string again = "a";
        while(again == "a") {
            //Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("******* Generátor pseudonáhodných čísel *******");
            Console.WriteLine("***********************************************");
            Console.WriteLine("**************** Jakub Samek ******************");
            Console.WriteLine("***********************************************\n\n");
            Console.WriteLine();

            
            Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
            int n;
            while(!int.TryParse(Console.ReadLine(), out n)) {
                Console.Write("Nezadali jste celé číslo. Zadejte počet čísel znovu (celé číslo): ");
            }

            Console.Write("Zadejte dolní mez (celé číslo): ");
            int dm;
            while(!int.TryParse(Console.ReadLine(), out dm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez (celé číslo): ");
            }

            Console.Write("Zadejte horní mez (celé číslo): ");
            int hm;
            while(!int.TryParse(Console.ReadLine(), out hm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu horní mez (celé číslo): ");
            }

            Console.WriteLine("\n\n====================");
            Console.WriteLine("Uživatelský vstup: ");
            Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dm, hm);
            Console.WriteLine("====================\n\n");

            // Deklarace pole
            int[] myArray = new int[n];

            // Příprava pro generování náhodných čísel
            Random randomNumber = new Random();

            int kladna = 0;
            int zaporna = 0;
            int nuly = 0;

            Console.WriteLine("Náhodná čísla: ");
            for(int i=0; i<n; i++) {
                
                myArray[i] = randomNumber.Next(dm, hm+1);
                Console.Write("{0}; ", myArray[i]);

                if(myArray[1]>0)
                    kladna++;
                if(myArray[1]<0)
                    zaporna++;
                if(myArray[1]==0)
                    nuly++;    
            }

            Console.WriteLine("\n\Počet kladných čísel: {0}", kladna);
            Console.WriteLine("\n\Počet záporných čísel: {0}", zaporna);
            Console.WriteLine("\n\Počet nul: {0}", nuly);

            // Opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }