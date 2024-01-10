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


            List<mathHandler> tal = new List<mathHandler>();

           

                while (start)
                {


                    tal.Add(mathHandler.calculate());


                    Console.WriteLine(tal[counterr].ToString());

                    counterr++;

                    counter = counterr - 1;  // påbörja uträkning från senaste utskrift i (A)

                    Console.WriteLine("Vill du fortsätta på beräkningen  Y/N Q för att avsluta");

                    string answer = Console.ReadLine().ToUpper();

                    if (answer == "Y") { doAgain = true; } else if (answer == "Q") { start = false;} else { doAgain = false; }

                    while (doAgain)
                    {

                        tal.Add(mathHandler.continoue(tal[counter]));

                        Console.WriteLine(tal[counter + 1].ToString()); // (A)
                        counter++;

                        Console.WriteLine("Fortsätta Y/N Q för avsluta");
                        string answerr = Console.ReadLine().ToUpper();

                        if (answerr == "N") { doAgain = false; } else if (answerr == "Q") { start = false; doAgain = false; } else { doAgain = true; }
                    }

                  
                }


            

            Console.WriteLine("Programmet avslutas...");


        }
    }
}
