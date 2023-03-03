using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Target_test___Ribeirão_Preto.Questions
{
    public class Test4
    {
        /*
         4 - Dois veículos (um carro e um caminhão) saem respectivamente de cidades opostas pela mesma rodovia. 
         O carro de Ribeirão Preto em direção a Franca, a uma velocidade constante de 110 km/h 
         e o caminhão de Franca em direção a Ribeirão Preto a uma velocidade constante de 80 km/h. 
         Quando eles se cruzarem na rodovia, qual estará mais próximo a cidade de Ribeirão Preto?

            IMPORTANTE:

            a) Considerar a distância de 100km entre a cidade de Ribeirão Preto <-> Franca.

            b) Considerar 2 pedágios como obstáculo e que o caminhão leva 5 minutos a mais para passar em cada um deles e o carro possui tag de pedágio (Sem Parar)

            c) Explique como chegou no resultado.

            S = v t
        
         */

        public Test4()
        {
            Console.WriteLine("\n4) Dois veículos (um carro e um caminhão) saem respectivamente de cidades opostas pela mesma rodovia. " +
                "O carro de Ribeirão Preto em direção a Franca, a uma velocidade constante de 110 km/h e o caminhão de Franca em direção " +
                "a Ribeirão Preto a uma velocidade constante de 80 km/h. Quando eles se cruzarem na rodovia, qual estará mais próximo a cidade de Ribeirão Preto?");

            Console.WriteLine("\nResposta:\n Ao se cruzarem na rodovia, ambos os veículos estarão igualmente próximos da cidade de Ribeirão Preto." +
                " Neste caso seria necessário usar a equação horária afim de determinar o ponto do cruzamento, entretanto a questão não pede essa informação.");
        }

    }
}
