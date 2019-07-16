using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APALLAKTIKIERGASIA2
{
    class StartTheQuiz
    {
        Random r = new Random();
        public string str1, str2, str3, str4;
        public int[] numbers = new int[8];
        public double add, min, mul, div;

        public StartTheQuiz()
        {

        }

        public int GetNumber()
        {
            int tyxaios = r.Next(100);
            return tyxaios;
        }

        public void fillArray()
        {
            for (int i = 0; i < 8; i++)
                numbers[i] = GetNumber();

            if (numbers[7] != 0)
            {

                str1 = numbers[0].ToString() + "\t + \t" + numbers[1].ToString() + "\t\t =";
                str2 = numbers[2].ToString() + "\t - \t" + numbers[3].ToString() + "\t\t =";
                str3 = numbers[4].ToString() + "\t * \t" + numbers[5].ToString() + "\t\t =";
                str4 = numbers[6].ToString() + "\t / \t" + numbers[7].ToString() + "\t\t =";
            }
            else
            {
                numbers[7] = r.Next(1, 100);
                str1 = numbers[0].ToString() + "\t + \t" + numbers[1].ToString() + "\t\t =";
                str2 = numbers[2].ToString() + "\t - \t" + numbers[3].ToString() + "\t\t =";
                str3 = numbers[4].ToString() + "\t * \t" + numbers[5].ToString() + "\t\t =";
                str4 = numbers[6].ToString() + "\t / \t" + numbers[7].ToString() + "\t\t =";
            }
        }
        public double Add()
        {
            add = numbers[0] + numbers[1];
            return add;
        }

        public double Min()
        {
            min = numbers[2] - numbers[3];
            return min;
        }

        public double Mul()
        {
            mul = numbers[4] * numbers[5];
            return mul;
        }

        public double Div()
        {
            div = numbers[6] / numbers[7];
            return div;
        }
    }
}
