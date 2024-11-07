// chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a") {
            //Console.Clear();
            Console.WriteLine("******************************");
            Console.WriteLine("******* Analýza Textu ********");
            Console.WriteLine("******************************");
            Console.WriteLine("******** Jakub Samek *********");
            Console.WriteLine("******************************\n\n");
            Console.WriteLine();

            Console.Write("\nZadejte text pro analýzu");
            string myText = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine(myText);
            Console.WriteLine(myText[0]);
            Console.WriteLine(myText.Length);
            Console.WriteLine(myText[myText.Length-1]);

            string samohlasky = "aáeéiíoóuúůyý";
            string souhlasky = "bcčdďfghjklmnňprřsštťvwxzž";
            string cislice = "0123456789";

            int pocetSamohlasek = 0;
            int pocetSouhlasek = 0;
            int pocetCislic = 0;
            int pocetOstatnich = 0;

            foreach(char znak in myText) 
            {
                if (samohlasky.Contains(znak)) {
                    pocetSamohlasek++;
                }
                else if (souhlasky.Contains(znak)) {
                    pocetSouhlasek++;
                }
                else if (cislice.Contains(znak)) {
                    pocetCislic++;
                }
                else
                    pocetOstatnich++;
            }

            Console.WriteLine("\n\nPočet souhlásek: {0}", pocetSouhlasek);
            Console.WriteLine("\n\nPočet samohlásek: {0}", pocetSamohlasek);
            Console.WriteLine("\n\nPočet číslic: {0}", pocetCislic);


            // Vstup od uživatele - lepší varianta
            Console.Write("Zadejte první číslo řady (celé číslo): ");
            int first;
            while(!int.TryParse(Console.ReadLine(), out first)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu první číslo řady (celé číslo): ");
            }

            
            // Opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }