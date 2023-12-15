using System;
namespace ProjektkUppgiftGrupp29
{
    public class meny
    {

        public static void getMeny()
        {
            bool doAgain = true;
            bool start = true;
            int result = 0;
            List<mathHandler> mathList = new List<mathHandler>();



            while (start)
            {
                int counter = 0;

                Console.WriteLine("Skriv in tal 1");
                double num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Skriv in tal 2");
                double num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Mata in räknesätt");
                char operatoR = Convert.ToChar(Console.ReadLine());

                mathHandler maths = new mathHandler(result,num1,num2,operatoR);
                mathList.Add(maths);




                while (counter == 0)
                {

                    foreach(var x in mathList)
                    {
                        Console.WriteLine(x.ToString());
                    }


                    counter = 1;
                }

            }
        }



    }
}