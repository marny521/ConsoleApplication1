using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hund");
            Looop(1);
        }

        static void Looop (int count)
        {
            if (count < 25)
            {
                //Kör
                Console.WriteLine(count);
                Looop(count+1);
            }
            else
            {
                //Stop
                Looop(1);
            }

        }
    }
}
