using System;

namespace ENTRADA_DE_DADOS_EM_C_SHARP_PART1
{
    class Program
    {
        static void Main(string[] args)
        {
       
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            

            string[] v = Console.ReadLine().Split(' '); // Quando colocar o comando lembrar de dar espaço entre as aspas dentro dos parenteses  ('  ')

            string a = v[0];
            string b = v[1];
            string c = v[2];

            Console.WriteLine("você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

        }
    }
}
