using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3_2_variants_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int f = num / 100;//first digit
            int s = (num / 10) % 10;//second digit
            int t = num % 10;//third digit
            int max;
            if (f > s)
            {
                if (f > t)
                {
                    max = f * 100 + (s > t ? s * 10 + t : t * 10 + s);
                }
                else
                {
                    max = t * 100 + f * 10 + s;
                }
            }
            else
            {
                if (s > t)
                {
                    max = s * 100 + (f> t ? f * 10 + t : t * 10 + f);
                }
                else
                {
                    max = t * 100 + s * 10 + f;
                }
            }

            Console.WriteLine($"The largest possible number: {max}");
            Console.ReadLine();
        }
    }
}
        
    

