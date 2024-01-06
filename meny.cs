using System;
namespace GIK299_Grupp_29__Projekt
{
    public class Meny
    {
        public static void getMeny()
        {
            bool doAgain = false;
            bool start = true;
            int counterr = 0; // räknar plats i listan
            int counter;   // räknar plats av utskrift i listan
            bool checkEx = true;


            List<mathHandler> tal = new List<mathHandler>();

            while (checkEx)
            {
                
                while (start)
                {



                    try
                    {

                        tal.Add(mathHandler.calculate());
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Fel format, skriv om tack");
                        break;
                    }

                    Console.WriteLine(tal[counterr].ToString());

                    counterr++;

                    counter = counterr - 1;  // påbörja uträkning från senaste utskrift i (A)

                    Console.WriteLine("Vill du fortsätta på beräkningen  Y/N Q för att avsluta");

                    string answer = Console.ReadLine().ToUpper();

                    if (answer == "Y") { doAgain = true; } else if (answer == "Q") { start = false; checkEx = false; } else { doAgain = false; }

                    while (doAgain)
                    {



                        try
                        {

                            tal.Add(mathHandler.continoue(tal[counter]));
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine("Fel format");
                            Console.WriteLine("Programmet börjar om...");
                            break;
                        }

                        Console.WriteLine(tal[counter + 1].ToString()); // (A)
                        counter++;

                        Console.WriteLine("Fortsätta Y/N Q för avsluta");
                        string answerr = Console.ReadLine().ToUpper();

                        if (answerr == "N") { doAgain = false; } else if (answerr == "Q") { start = false; checkEx = false; doAgain = false; } else { doAgain = true; }
                    }

                }

            }

            Console.WriteLine("Programmet avslutas...");
        }
    }
}
