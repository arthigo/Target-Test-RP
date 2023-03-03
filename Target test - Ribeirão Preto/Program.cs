using Target_test___Ribeirão_Preto.Questions;

namespace Target_test___Ribeirão_Preto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reposta dos desafios: \n\n");

            Test1 test1 = new Test1();
            Advance();
            Test2 test2 = new Test2();            
            AdvanceOrRedo(test2);
            Test3 test3 = new Test3();
            Advance();
            Test4 test4 = new Test4();
            Advance();
            Test5 test5 = new Test5();
            AdvanceOrRedo(test5);

        }

        static private void Advance()
        {
            Console.WriteLine("\nPressione qualquer tecla para avançar para a próxima resposta\n");
            Console.ReadKey();
            Console.WriteLine("\n\n---------------------------------------------------------------------------\n\n");
        }

        static private void AdvanceOrRedo(ITest test)
        {
            Console.WriteLine("\n\n**** Pressione (r) para executar novamente ou (Enter) para avançar. ****\n");

            var key =  Console.ReadKey();

            if (key.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("\n\n---------------------------------------------------------------------------\n\n");
                return;
            }
            else if (key.Key == ConsoleKey.R)
                test.DoTest();

            AdvanceOrRedo(test);
        }
    }
}