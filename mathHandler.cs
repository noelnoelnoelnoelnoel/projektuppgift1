using System;
namespace ProjektkUppgiftGrupp29
{
	public class mathHandler
	{

		public static double calculate(double a,double b, double result, char d)
		{
            

            switch (d)
			{

				case '+':
                    result = a + b;
                    
					break;

                case '-':
                    result = a - b;

                    break;

                case '/':
                    result = a / b;

                    break;

                case '*':
                    result = a * b;

                    break;

                       case '^':
                    result = Math.Pow(a,b);

                    break;

                case '√':
                    result = Math.Sqrt(a);

                    break;





            }




            return a;
		}



		
	
    }
}

