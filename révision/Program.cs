/***************************************************/
/*************      AllInOne 2025        ***********/
/***************************************************/

using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

while (true)
{
     // définir variables

    int valeur;
    string bienvenue = $"Bienvenue dans le hub C#\n";
    string programSelect = $"Choisisez une application a lancer:\n\n";
    string choice = "\nVotre choix: ";

    ///////////////////////////////////////////////////
    var Applications = new Dictionary<string, int>(); // création de dictionnaire avec les programmes

    Applications["Fourchette"] = 1;
    Applications["Calculatrice"] = 2;

    foreach (char c in bienvenue)
    {
        Console.Write(c);
        Thread.Sleep(15);
    }

    foreach (char c in programSelect) // animation print
    {
        Console.Write(c);
        Thread.Sleep(15);
    }

    foreach (var app in Applications)
    {
        Console.WriteLine("Application numéro {1}, {0}", app.Key, app.Value);
    }

    do foreach (char c in choice)
        {
            Console.Write(c);
            Thread.Sleep(15);
        }
    while (!int.TryParse(Console.ReadLine(), out valeur));


    switch (valeur)
    {
        case 1:
            Console.WriteLine("Vous avez choisi l'Application numéro {1}, {0}", "Fourchette", Applications["Fourchette"]);

            int nbMin;
            int nbMax;
            int essais;
            int guess;
            int userGuess;
            
            while (true)
            {
                do Console.Write("\nQuelle est la borne inférieure ? ");
                while (!int.TryParse(Console.ReadLine(), out nbMin));

                if (nbMin < 0)
                {
                }
                else
                {
                    do
                    {
                        Console.Write("\nQuelle est la borne supérieure ? ");
                    } while (!int.TryParse(Console.ReadLine(), out nbMax));

                    if (nbMax <= nbMin)
                    {
                    }
                    else
                    {
                        do
                        {
                            Console.Write("\nQuel est le nombre d'essais ? ");
                        } while (!int.TryParse(Console.ReadLine(), out essais));

                        if (essais < 0)
                        {
                        }

                        else
                        {
                            Random random = new Random();
                            guess = random.Next(nbMin, nbMax);
                            
                            Console.WriteLine($"Résumé:\nBorne inférieure: {nbMin}\nBorne supérieure: {nbMax}\nNombre d'essais: {essais}");
                            Console.WriteLine($"-------------------------------------------------------\nLE JEU COMMENCE\n-------------------------------------------------------");

                            Console.WriteLine(guess); 

                            for (int i = 0; i <= essais; i++)
                            {
                                
                                do { 
                                Console.WriteLine("GUESS UN TRUC");
                                } while (!int.TryParse(Console.ReadLine(), out userGuess));


                                // VARIABLES //
                                string lowGuess = $"{userGuess} < x";
                                string highGuess = $"{userGuess} > x";
                                string ggGuess = $"{userGuess} = x ({guess})";



                                if (userGuess < guess)
                                {
                                    foreach (char c in lowGuess)
                                        {
                                            Console.Write(c);
                                            Thread.Sleep(75);
                                        }
                                    Console.WriteLine(("\nEssais restants: ") + (essais - i));
                                }
                                 else if (userGuess > guess)
                                {
                                    foreach (char c in highGuess)
                                    {
                                        Console.Write(c);
                                        Thread.Sleep(75);
                                    }
                                    Console.WriteLine(("\nEssais restants: ") + (essais - i));
                                }
                                 else if (userGuess == guess)
                                {
                                    foreach (char c in ggGuess)
                                    {
                                        Console.Write(c);
                                        Thread.Sleep(75);
                                    }
                                    Console.WriteLine("GG mon beau");   
                                }
                            }


                        }

                    }

                }
            }

            break;
        case 2:
            Console.WriteLine("Vous avez choisi l'Application numéro {1}, {0}", "Calculatrice", Applications["Calculatrice"]);
















            break;
        default:
            Console.WriteLine("Choix invalide. Veuillez choisir un numéro d'application valide.");
            break;
    }


    Console.WriteLine("Voulez-vous quitter le hub ? (O/N)");
    string exitChoice = Console.ReadLine();
    if (exitChoice.ToLower() == "o" || exitChoice.ToLower() == "y")
    {
        break;
    }
}


