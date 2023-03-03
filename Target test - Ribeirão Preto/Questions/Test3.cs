using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Target_test___Ribeirão_Preto.Questions
{
    public class Test3
    {
        /*
         3) Descubra a lógica e complete o próximo elemento:

            a) 1, 3, 5, 7, ___

            b) 2, 4, 8, 16, 32, 64, ____

            c) 0, 1, 4, 9, 16, 25, 36, ____

            d) 4, 16, 36, 64, ____

            e) 1, 1, 2, 3, 5, 8, ____

            f) 2,10, 12, 16, 17, 18, 19, ____

         */

        public Test3()
        {
            Answers();
        }

        private void Answers()
        {
            Console.WriteLine("\n3) Descubra a lógica e complete o próximo elemento: ");
            Console.WriteLine("a) 1, 3, 5, 7, ___");
            Console.WriteLine("Resposta: 9. Trata-se de uma seqência de números ímpares.\n");
            Console.WriteLine("b) 2, 4, 8, 16, 32, 64, ____");
            Console.WriteLine("Resposta: 128. Trata-se de uma progressão geométrica onde q = 2.\n");
            Console.WriteLine("c) 0, 1, 4, 9, 16, 25, 36, ____");
            Console.WriteLine("Resposta: 49. A sequência é determinada por uma razão aritimética.\n");// 1 3 5 7 9 11 13
            Console.WriteLine("d) 4, 16, 36, 64, ____");
            Console.WriteLine("Resposta: 100. O próximo ítem é igual a diferença do anterior somado a 8.\n"); // 12 20 28 36
            Console.WriteLine("e) 1, 1, 2, 3, 5, 8, ____");
            Console.WriteLine("Resposta: 13. Trata-se da sequência Fibbonaci.\n");
            Console.WriteLine("f) 2,10, 12, 16, 17, 18, 19, ____"); 
            Console.WriteLine("Resposta: 200. Todos os números começam com D. Já conhecia essa charada :) \n");
        }
    }
}
