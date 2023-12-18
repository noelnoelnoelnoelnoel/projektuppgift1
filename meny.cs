using System;
namespace GIK299_Grupp_29__Projekt
{
    public class meny
    {
        public static void getMeny()
        {
            bool doAgain = false;
            bool start = true;
            int counterr = 0;
            int counter;



            List<mathHandler> tal = new List<mathHandler>();

            while (start)
            {

                tal.Add(mathHandler.calculate());

                
                Console.WriteLine(tal[counterr].ToString());


                counterr++;

                counter = counterr;

                while (doAgain)
                {



                        tal.Add(mathHandler.continoue(tal[counter]));

                        Console.WriteLine(tal[counter].ToString());
                        counter++;

                }


            }
        }
    }
}
