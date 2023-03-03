using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Target_test___Ribeirão_Preto.Questions
{
    public class Test2 : ITest
    {
        /*
        2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores 
        (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, ele 
        calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

        IMPORTANTE:

        Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;
         */
        public Test2() 
        {
            DoTest();
        }

        public void DoTest()
        {
            CheckNumber();
        }

        private string Fibbonaci(int value)
        {
            List<int> fibo = new List<int>(){ 0, 1 };

            while (fibo.Last() <= value)
            {
                int last = fibo.Last();
                int secToLast = fibo[fibo.Count - 2];

                fibo.Add(last + secToLast);
            }

            foreach (int fib in fibo)
                if (fib == value)
                    return $"{value} faz parte da sequência fibonacci";

            return $"{value} não faz parte da sequência fibonacci";
        }

        private void CheckNumber()
        {
            int value;
            Console.WriteLine("\n2) Digite o número que será verificado se faz parte da sequência fibonnaci: ");

            if(int.TryParse(Console.ReadLine(), out value))
                Console.WriteLine(Fibbonaci(value));
            else
            {
                Console.WriteLine("Not a number\n");
                CheckNumber();
            }
        }
    }
}
