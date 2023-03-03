using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Target_test___Ribeirão_Preto.Questions
{
    public class Test5 : ITest
    {
        /*
         5) Escreva um programa que inverta os caracteres de um string.

            IMPORTANTE:

            a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;

            b) Evite usar funções prontas, como, por exemplo, reverse;
         */
        public Test5()
        {
            string str = "O coração, se pudesse pensar, pararia.";
            Console.WriteLine("\n5) Escreva um programa que inverta os caracteres de um string.");
            ReverseStr(str);
        }
        
        public void DoTest()
        {
            Console.WriteLine("\nDigite sua string: ");
            string read = Console.ReadLine();
            if (String.IsNullOrEmpty(read))
                DoTest();
            else
                ReverseStr(read);
        }

        private static void ReverseStr(string str)
        {
            string rev = "";

            for (int i = str.Length-1; i >= 0; i--)
            {
                rev += str[i];
            }

            Console.WriteLine($"\nOriginal: {str}");
            Console.WriteLine($"Inversão: {rev}");
            Console.WriteLine("\nExecute novamente para digitar sua própria string.");
        }

    }
}
