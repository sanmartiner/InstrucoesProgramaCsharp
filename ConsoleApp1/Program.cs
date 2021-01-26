using System;

namespace Instrucoes
{
    class Program
    {
        static void Declaracoes()
        {
            int a;
            int b = 2, c = 3;
            const int d = 4;
            a = 1;
            Console.WriteLine(a + b + c + d);
        }
        
        static void InstrucaoIf(string[] args) 
        {
            if(args.Length == 0)
            {
                Console.WriteLine("Nenhum Argumento");
            } 
            else if{
                Console.WriteLine("Um argumento");
            }
            else
            {
                Console.WriteLine($"{args.Length} argumentos");
            }
        }

        static void InstrucaoSwitch(string[] args)
        { }

        static void InstrucaoDo(string[] args)
        { }

        static void InstrucaoFor(string[] args)
        { }

        
    }
}
