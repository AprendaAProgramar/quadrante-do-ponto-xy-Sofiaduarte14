using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Introduza o valor da abscissa:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduza o valor da ordenada:");
            y = Convert.ToInt32(Console.ReadLine());
            if (x > 0)
            {
                if (y > 0)
                    Console.WriteLine ("O ponto ({0},{1}) está no primeiro quadrante", x, y);
                else
                    Console.WriteLine ("O ponto ({0},{1}) está no quarto quadrante", x, y);
            }
            else
                if (y > 0)
                    Console.WriteLine ("O ponto ({0},{1}) está no segundo quadrante", x, y);
                else
                    Console.WriteLine ("O ponto ({0},{1}) está no terceiro quadrante", x, y);
        }
    }
}
