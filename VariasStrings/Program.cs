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

            int numero = 64;
            int numero1 = 70;
            string a = "Abc";
            string c = a + numero;
            string d = $"Valor de x = {numero},  valor de y = {numero1}";
            string b = String.Format("Valor de x = {0},  valor de y = {1}", 
            numero, numero1);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);


        }
    }
}
