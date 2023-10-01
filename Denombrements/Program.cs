using System;

namespace Denombrements
{
    class Program
    {
        static int MultiplicationSuites(int count, int valeur2)
        {
            int valeur1 = 1;
            for (int k = count; k <= valeur2; k++)
                valeur1 *= k;

            return valeur1;
        }

        static void Main(string[] args)
        {

            int choix = -1;
            while (choix != 0)
            { 
                // boucle la saisie d'un choix tant qu'elle n'est pas correcte
                do
                {
                    try
                    {
                        Console.WriteLine("Permutation ...................... 1");
                        Console.WriteLine("Arrangement ...................... 2");
                        Console.WriteLine("Combinaison ...................... 3");
                        Console.WriteLine("Quitter .......................... 0");
                        Console.Write("Choix :                            ");
                        choix = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        
                    }
                } while (choix < 0 || choix > 3);
                
                
                // fermeture du programme lorsque choix 0
                if (choix == 0) { Environment.Exit(0); }

                if (choix == 1)
                {
                    // le nombre d'éléments à gérer
                    Console.Write("nombre total d'éléments à gérer = ");
                    // saisir le nombre
                    int nombre = int.Parse(Console.ReadLine());

                    // calcul de resultat                                       
                    long resultat = MultiplicationSuites(1, nombre);
                    Console.WriteLine(nombre + "! = " + resultat);
                }
                else
                {
                    if (choix == 2)
                    {
                        // le nombre d'éléments à gérer
                        Console.Write("nombre total d'éléments à gérer = ");
                        // saisir le nombre
                        int nombre = int.Parse(Console.ReadLine());
                        // le sous ensemble
                        Console.Write("nombre d'éléments dans le sous ensemble = ");
                        // saisir le nombre sous ensemble
                        int nombreElements = int.Parse(Console.ReadLine()); 

                        // calcul de resultat
                        long resultat = MultiplicationSuites((nombre - nombreElements + 1), nombre);

                        //affichage du résultat
                        Console.WriteLine("A(" + nombre + "/" + nombreElements + ") = " + resultat);
                    }
                    else
                    {
                        // le nombre d'éléments à gérer
                        Console.Write("nombre total d'éléments à gérer = ");
                        // saisir le nombre
                        int nombre = int.Parse(Console.ReadLine());
                        // le sous ensemble
                        Console.Write("nombre d'éléments dans le sous ensemble = ");
                        // saisir le nombre sous ensemble
                        int nombreElements = int.Parse(Console.ReadLine()); 

                        // calcul de r1
                        long r1 = MultiplicationSuites((nombre - nombreElements + 1), nombre);
                        // calcul de r2
                        long r2 = MultiplicationSuites(1, nombreElements);

                        // affichage du résultat
                        Console.WriteLine("C(" + nombre + "/" + nombreElements + ") = " + (r1 / r2));
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
