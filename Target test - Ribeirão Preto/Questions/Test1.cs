using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Target_test___Ribeirão_Preto.Questions
{
    public class Test1
    {
        /*
        1) Observe o trecho de código abaixo:
        
        enquanto K<INDICE faça
        
{

            K = K + 1;

            SOMA = SOMA + K;

        }

        imprimir(SOMA);



        Ao final do processamento, qual será o valor da variável SOMA?
        */

        int INDICE = 13, SOMA = 0, K = 0;

        public Test1()
        {
            Console.WriteLine("\n1) Ao final do processamento, qual será o valor da variável SOMA?");
            Console.WriteLine("Resposta: " + DoTest()); // expected 91
        }

        private int DoTest()
        {
            while( K < INDICE)
            {
                K++;
                SOMA += K;
            }

            return SOMA;
        }
    }
}
