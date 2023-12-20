using System;
namespace GIK299_Grupp_29__Projekt
{
    public class mathHandler
    {
        public static mathHandler calculate()
        {
            double[] result = { 0 ,0};

            Console.WriteLine("Tal");
            double num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Operation:  +  -  *  /  ^   √  ");
            char Operator = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("tal 2");
            double num2 = Convert.ToInt32(Console.ReadLine());



            switch (Operator)
            {
                case '+':
                    result[0] = num1 + num2;
                    break;

                case '-':
                    result[0]= num1 - num2;
                    break;

                case '/':
                    result[0] = num1 / num2;
                    result[1] = num1 % num2;

                       
                    break;

                case '*':
                    result[0] = num1 * num2;
                    break;

                case '^':
                    result[0]= Math.Pow(num1, num2);
                    break;

                case '√':
                    result[0] = Math.Sqrt(num1);
                    break;
            }

            mathHandler math1 = new mathHandler(num1, num2, result, Operator);
            math1.SaveToFile(); // Lägger till SaveToFile för att spara beräkningen i filen
            return math1;
        }

        public static mathHandler continoue(mathHandler b)
        {
            double[] result = { 0, 0 };

            Console.WriteLine("Operator   +  -  *  /  ^   √   ");

            char Operator = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Tal");

            double num2 = Convert.ToInt32(Console.ReadLine());

            double num1 = b.result[0];



            switch (Operator)
            {
                case '+':
                    result[0] = num1 + num2;
                    break;

                case '-':
                    result[0] = num1 - num2;
                    break;

                case '/':
                    result[0] = num1 / num2;
                    result[1] = num1 % num2;


                    break;

                case '*':
                    result[0] = num1 * num2;
                    break;

                case '^':
                    result[0] = Math.Pow(num1, num2);
                    break;

                case '√':
                    result[0] = Math.Sqrt(num1);
                    break;
            }

            mathHandler math2 = new mathHandler(num1, num2, result, Operator);
            math2.SaveToFile(); // Lägger till SaveToFile för att spara beräkningen i filen
            return math2;
        }

        public double num1 { get; set; }
        public double num2 { get; set; }
        public double[] result { get; set; }
        public char operatoR { get; set; }
       

        public mathHandler(double a, double b, double [] c, char d)
        {
            this.num1 = a;
            this.num2 = b;
            this.result = c;
            this.operatoR = d;
        }

        public override string ToString()
        {
        
             string a =  string.Format(" --------------------\n Resultat: {0} rest {4} \n {1} {2} {3} = {0} rest {4} \n -------------------- ", result[0], num1, operatoR, num2, result[1].ToString());

             string b = string.Format(" --------------------\n Resultat: {0} \n {1} {2} {3} = {0} \n -------------------- ",  result[0] , num1, operatoR, num2.ToString());

            if (result[1] > 0)
            {
                return a;
            }

            else 
            {
                return b;
            }
        }

        public void SaveToFile()
        {
            try
            {
                string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string filePath = Path.Combine(folderPath, "calculations.txt");

                // Använd StreamWriter för att skriva till filen
                using (StreamWriter sw = File.AppendText(filePath))
                {
                    sw.WriteLine($"Beräkningen: {DateTime.Now} - {this}");
                }

                Console.WriteLine("Beräkningen har sparats i calculations.txt.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Det uppstod ett fel vid sparande till fil: {ex.Message}");
            }
        }
    }
}



