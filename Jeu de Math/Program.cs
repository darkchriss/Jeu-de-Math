using System;

namespace Jeu_de_Math
{
    internal class Program
    {
        const int VAL_MIN = 1;
        const int VAL_MAX = 10;
        //Définition des limites de valeur

        enum OPERATEUR
        {
            ADDITION,
            MULTIPLICATION,
            SOUSTRACTION
        }

        private static int GetOperateur()
        {
            Random random = new Random();
            int operateur = random.Next(1, 4);

            if (operateur == 1)
            {
                return (int)OPERATEUR.ADDITION;
            }
            else if (operateur == 2)
            {
                return (int)OPERATEUR.MULTIPLICATION;
            }
            return (int)OPERATEUR.SOUSTRACTION;
        }

        private static bool DemanderOperation()
        {
            Random random = new Random();
            int chiffreA = random.Next(VAL_MIN, VAL_MAX);
            int chiffreB = random.Next(VAL_MIN, VAL_MAX);
            //Génération de 2 chiffre aléatoire compris entre les limites
            int operateur = GetOperateur();

            while (true)
            {
                if (operateur == (int)OPERATEUR.ADDITION)
                {
                    int résultat = chiffreA + chiffreB;
                    Console.Write(chiffreA + " + " + chiffreB + " = ");
                    string réponseUser = Console.ReadLine();

                    int chiffreUser = 0;

                    if (int.TryParse(réponseUser, out chiffreUser))
                    {
                        //La conversion s'est bien passé
                        if (chiffreUser == résultat)
                        {
                            Console.WriteLine("Bravo vous avez trouvé la bonne réponse !");
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("Dommage, ceci n'est pas la bonne réponse ! " + chiffreA + " + " + chiffreB + " = " + résultat);
                            return false;
                        }
                    }
                    else
                    {
                        //La conversion s'est mal passé
                        Console.WriteLine("ERREUR : Veuillez entrez un nombre.");
                    }
                }
                else if (operateur == (int)OPERATEUR.MULTIPLICATION)
                {
                    int résultat = chiffreA * chiffreB;
                    Console.Write(chiffreA + " * " + chiffreB + " = ");
                    string réponseUser = Console.ReadLine();

                    int chiffreUser = 0;

                    if (int.TryParse(réponseUser, out chiffreUser))
                    {
                        //La conversion s'est bien passé
                        if (chiffreUser == résultat)
                        {
                            Console.WriteLine("Bravo vous avez trouvé la bonne réponse !");
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("Dommage, ceci n'est pas la bonne réponse ! " + chiffreA + " * " + chiffreB + " = " + résultat);
                            return false;
                        }
                    }
                    else
                    {
                        //La conversion s'est mal passé
                        Console.WriteLine("ERREUR : Veuillez entrez un nombre.");
                    }
                }
                else if (operateur == (int)OPERATEUR.SOUSTRACTION)
                {
                    if (chiffreA < chiffreB)
                    {
                        int temp = chiffreA;
                        chiffreA = chiffreB;
                        chiffreB = temp;
                    }
                    int résultat = chiffreA - chiffreB;
                    Console.Write(chiffreA + " - " + chiffreB + " = ");
                    string réponseUser = Console.ReadLine();

                    int chiffreUser = 0;

                    if (int.TryParse(réponseUser, out chiffreUser))
                    {
                        //La conversion s'est bien passé
                        if (chiffreUser == résultat)
                        {
                            Console.WriteLine("Bravo vous avez trouvé la bonne réponse !");
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("Dommage, ceci n'est pas la bonne réponse ! " + chiffreA + " - " + chiffreB + " = " + résultat);
                            return false;
                        }
                    }
                    else
                    {
                        //La conversion s'est mal passé
                        Console.WriteLine("ERREUR : Veuillez entrez un nombre.");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            const int LIMITE = 6;
            int question = 0;
            int bonneReponse = 0;
            int mauvaiseReponse = 0;

            for (question = 1; question < LIMITE; question++)
            {
                Console.WriteLine("");
                Console.WriteLine("Question " + question + "/5");

                if (DemanderOperation() == true)
                {
                    bonneReponse++;
                }
                else
                {
                    mauvaiseReponse++;
                }

                int Resultat = bonneReponse - mauvaiseReponse;
                if (question == 5)
                {
                    Console.WriteLine("");
                    if (Resultat == 5)
                    {
                        Console.WriteLine("Bravo ! Vous avez répondu correctement à toutes les questions.");
                    }
                    else if ((Resultat == 4) || (Resultat == 3))
                    {
                        Console.WriteLine("Pas mal ! Vous avez répondu correctement à " + bonneReponse + " questions sur " + question);
                    }
                    else
                    {
                        Console.WriteLine("Peut mieux faire. Vous avez " + bonneReponse + " bonne réponses sur " + question + " questions");
                    }
                }
            }
        }
    }
}
