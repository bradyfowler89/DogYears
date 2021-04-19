using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogyears
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old is your dog in human years? ");
            int years = Convert.ToInt32(Console.ReadLine());
            if (years == 1)
            {
                years = 15;
            }
            else if (years == 2)
            {
                years = 15 + 10;
            }
            else
            {
                years = 25 + (7 * (years - 2));
            }
            Console.WriteLine("In dog years, your dog is " + years + " years old.");
            Console.ReadKey();
        }
    }
}
