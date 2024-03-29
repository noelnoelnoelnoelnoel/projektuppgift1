using System;
namespace GIK299_Grupp_29__Projekt
{
    public class mathHandler
    {

        
        public static mathHandler calculate()
        {
            double[] result = { 0, 0, 0 };

            int num2;

            Console.WriteLine("Tal");
            double num1 = Convert.ToInt32(Console.ReadLine()); // fixa


            Console.WriteLine("Operation:  +  -  *  /  ^   √  ");
            char Operator = Convert.ToChar(Console.ReadLine()); // fixa


            if (Operator != '√') // 1 siffra behövs bara för kvadratrot
            {
                Console.WriteLine("tal 2");
                num2 = Convert.ToInt32(Console.ReadLine()); // fixa
            }

            else
            {
                num2 = 0;

            }

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
                    result[2] = Math.Floor(result[0]);
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

            round(result[0]);
            mathHandler math1 = new mathHandler(num1, num2, result, Operator);
            math1.SaveToFile(); // Lägger till SaveToFile för att spara beräkningen i filen
            return math1;
        }

        public static mathHandler continoue(mathHandler b)
        {
            double[] result = { 0, 0, 0 };
            double num2;

            Console.WriteLine("Operator   +  -  *  /  ^   √   ");

            char Operator = Convert.ToChar(Console.ReadLine());  // fixa

            Console.WriteLine("Tal");

            if (Operator != '√')
            {
                
                num2 = Convert.ToInt32(Console.ReadLine());  // fixa
            }

            else
            {
                num2 = 0;

            }

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
                    result[2] = Math.Floor(result[0]);


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

            round(result[0]);

            mathHandler math2 = new mathHandler(num1, num2, result, Operator);
            math2.SaveToFile(); // Lägger till SaveToFile för att spara beräkningen i filen
            return math2;
        }

        public double num1 { get; set; }
        public double num2 { get; set; }
        public double[] result { get; set; }
        public char operatoR { get; set; }


        public mathHandler(double a, double b, double[] c, char d)
        {
            this.num1 = a;
            this.num2 = b;
            this.result = c;
            this.operatoR = d;
        }

        public override string ToString()
        {


            string a = string.Format($" --------------------\n Resultat: {result[0]} \n heltals division {result[2]} rest {result[1]} \n {num1} {operatoR} {num2} = {result[0]} \n heltals division {result[2]} , {result[1]} \n -------------------- ".ToString());
            string b = string.Format(" --------------------\n Resultat: {0} \n {2}{1} = {0} \n -------------------- ", result[0], num1, operatoR.ToString());
            string c = string.Format($"--------------------\n Resultat = {result[0]} \n {num1} {operatoR} {num2} = {result[0]} \n -------------------- ");

            if (result[1] != 0)
            {
                return a;
            }

            else if (operatoR == '√')
            {
                return b;
            }

            else
            {
                return c;
            }
        }

        public static double round(double a)
        {
            Math.Round(a, 2);
            return a;
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



