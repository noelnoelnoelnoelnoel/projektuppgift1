using System;
using System.Collections.Generic;
using ProjektkUppgiftGrupp29;

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
                int counter = 1;

                doAgain = true;

                tal.Add(mathHandler.calculate());

                Console.WriteLine(tal[0].ToString());

                while (doAgain)
                {

                    for (int i = 0; i <counter; i++)
                    {

                        Console.WriteLine("Avslutning skriv X, fortsättning skriv in valfri bokstav");
                        string exit = Console.ReadLine();

                        tal.Add(mathHandler.continoue(tal[i]));

                        Console.WriteLine(tal[counter].ToString());
                        counter++;

                        

                        if (exit == "X"){ doAgain = false; }
                    }

                }
            }
        }
    }
}
