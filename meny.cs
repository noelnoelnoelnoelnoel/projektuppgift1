using System;
namespace GIK299_Grupp_29__Projekt
{
    public class meny
    {
        public static void getMeny()
        {
            bool doAgain = true;
            bool start = true;

            List<mathHandler> tal = new List<mathHandler>();

            while (start)
            {
                int counter = 0;


                tal.Add(mathHandler.calculate());

                Console.WriteLine(tal[counter].ToString());

                Console.WriteLine(" F = forsätt beräkning, valfri = ny beräkning ");

                string answer = Console.ReadLine();

                if (answer == "F") { doAgain = true; } else { doAgain = false; }


                while (doAgain)
                {

                    for (int i = 0; i <100; i++)
                    {

                        tal.Add(mathHandler.continoue(tal[i]));

                        Console.WriteLine(tal[i].ToString());
                                          

                    }

                    counter++;
                }
            }
        }
    }
}

