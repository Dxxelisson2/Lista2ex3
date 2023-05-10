using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double A, B, C;

            Console.WriteLine("o(os) maiores entre 3 números. ");
            Console.WriteLine();

            Console.WriteLine("digite o primeiro número:");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine("digite o segundo número:");
            B = double.Parse(Console.ReadLine());
            Console.WriteLine("digite o terceiro número:");
            C = double.Parse(Console.ReadLine());

            if (A == B && A == C)
                Console.WriteLine("os três números digitados foram iguais a {0}.", A);
            else
                if (C > A && C > B && A == B)
                Console.WriteLine("o terceiro número digitado {0} foi o maior", C);
            else
                if (B > A && B > C && A == C)
                Console.WriteLine("o segundo número digitado {0} foi o maior", B);
            else
                if (A < B && A < C)
                Console.WriteLine("o segundo e o terceiro números que são respectivamente {0} e {1} foram os maiores", B, C);
            else
                if (A > B && A > C && B == C)
                Console.WriteLine("o primeiro número digitado {0} foi o maior", A);
            else
                if (B < A && B < C)
                Console.WriteLine("o primeiro e o terceiro números que são respectivamente {0} e {1} foram os maiores", A, C);
            else
                if (C < A && C < B)
                Console.WriteLine("o primeiro e o segundo números que são respectivamente {0} e {1} foram os maiores", A, B);

        }

    }
}

