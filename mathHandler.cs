namespace ProjektkUppgiftGrupp29
{
    public class mathHandler
    {

        public static void calculate()
        {
            double result;

            Console.WriteLine("Tal 1");

            double num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("tal 2");
            double num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Operation");
            char Operator = Convert.ToChar(Console.ReadLine());


            switch (Operator)
            {

                case '+':
                    result = num1 + num2;

                      mathHandler math = new mathHandler (num1,num2,result,Operator);

                    break;

                case '-':
                    result = num1 - num2;

                    mathHandler math1 = new mathHandler(num1, num2, result, Operator);

                    break;

                case '/':
                    result = num1 / num2;
                    mathHandler math2 = new mathHandler(num1, num2, result, Operator);

                    break;

                case '*':
                    result = num1 * num2;
                    mathHandler math3 = new mathHandler(num1, num2, result, Operator);

                    break;

                case '^':
                    result = Math.Pow(num1, num2);
                    mathHandler math4 = new mathHandler(num1, num2, result, Operator);

                    break;

                case '√':
                    result = Math.Sqrt(num1);
                    mathHandler math5 = new mathHandler(num1, num2, result, Operator);

                    break;


            }


        }
    


        public  double num1 {get; set;}
        public  double num2 { get; set; }
        public  double result{ get; set; }
        public  char operatoR { get; set; }

        public mathHandler(double a,double b,double c, char d)
        {

            this.num1 = a;
            this.num2 = b;
            this.result = c;
            this.operatoR = d;



        }



        public override string ToString()
        {
            return string.Format($" Resultat: {result} \n {num1} {operatoR} {num2} = {result} ".ToString());
        }




    }
}

