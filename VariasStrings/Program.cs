using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            double xx = 0.12345;
            int ii = 18;

            //Normal Strings
            string normal = "Isto é uma string normal";
            string codigos = "Isto é uma aspa \", isto é um código \u0001";
            string verbatim = @"Literalmente o que está escrito ||||";
            //Print Normal strings
            Console.WriteLine(normal);
            Console.WriteLine(codigos);
            Console.WriteLine(verbatim);

            //String Fotmating
            int numero = 64;
            int numero1 = 70;
            string a = "Abc";
            string c = a + numero;
            string d = $"Valor de x = {numero},  valor de y = {numero1}";
            string b = String.Format("Valor de x = {0},  valor de y = {1}", 
            numero, numero1);

            //Print formated strings
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);

            string numero2CasasDecimaisEPercentagem = $"x em decimal = {xx:f2}, x em percentagem = {xx:p1}";
            string numerodoii = $"ii em hexadecimal = {ii:X}, em moeda {ii:C}";

            Console.WriteLine(numero2CasasDecimaisEPercentagem);
            Console.WriteLine(numerodoii);

        }
    }
}
