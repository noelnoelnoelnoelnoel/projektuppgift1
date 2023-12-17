using System;
using System.Collections.Generic;
using ProjektkUppgiftGrupp29;

namespace Miniräknare
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
                doAgain = true;

                tal.Add(mathHandler.calculate());

                Console.WriteLine(tal[0].ToString());

                while (doAgain)
                {
                    tal.Add(mathHandler.continoue(tal[0]));

                    Console.WriteLine(tal[1].ToString());

                    doAgain = false;
                }
            }
        }
    }
}
