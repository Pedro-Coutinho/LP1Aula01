using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string normal = "Isto é uma string normal";
            string codigos = "Isto é uma aspa \", isto é um código \u0001";
            string verbatim = @"Literalmente o que está escrito ||||";

            Console.WriteLine(normal);
            Console.WriteLine(codigos);
            Console.WriteLine(verbatim);

        }
    }
}
