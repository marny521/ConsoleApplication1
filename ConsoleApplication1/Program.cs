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
            //Loopa 25 gånger
            if (count < 25)
            {
               
                Console.WriteLine(count);
                Looop(count+1);
            }
            
            //Stanna loopen
            else
            {
                count = 0;
                Looop(count);
            }

        }
    }
}
