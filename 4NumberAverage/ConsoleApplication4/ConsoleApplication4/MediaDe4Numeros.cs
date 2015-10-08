using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x,y,z,v;
            Console.WriteLine("Escreva um número: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva outro número: ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva mais um número: ");
            z = int.Parse(Console.ReadLine());
            Console.WriteLine("Mais um número: ");
            v = int.Parse(Console.ReadLine());
            int t = x + y + z + v;
            int m = (x + y + z + v) / 4;
            Console.WriteLine("Total: {0}, Média: {1}", t,m);
            Console.WriteLine("Pressione Enter para sair");
            Console.Read();
        }
    }
}
