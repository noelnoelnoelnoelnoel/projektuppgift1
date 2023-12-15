using System;
namespace ProjektkUppgiftGrupp29
{
	public class mathHandler
	{

        public double result;

	public double numb1 { get; set; }
        public double numb2 { get; set; }
        public char operatoR { get; set; }

        public double Result
		{
			get { return result; }
			set {

                switch (operatoR)
                {
                    case '+':

                        result = numb1 + numb1;
                        break;

                    case '*':
                        result = numb1 * numb2;
                        break;

                    case '-':
                        result  = numb1 - numb2;
                        break;

                    case '/':
                        result = numb1 / numb2;
                        break;

                    case '^':

                        for (int i = 0; i < numb2; i++)
                        {
                            result = numb1 * numb1;
                        }

                        break;
                }

                result = value;
               
            }
		}
		

        public mathHandler(double result, double numb1, double numb2, char operatoR)
		{

            this.result = result;
            this.numb1 = numb1;
            this.numb2 = numb2;
            this.operatoR = operatoR;

		}

        public override string ToString()
        {
            return string.Format($" \n Resultat: {result} \n {numb1} {operatoR} {numb2} = {result}" ).ToString();
        }

	
    }
}

