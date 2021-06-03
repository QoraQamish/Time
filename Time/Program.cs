using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1- Vaqtni kirting: (hh:mm:ss)");
            string[] timemas = Console.ReadLine().Split(':');
            TimeA time1 = new TimeA(int.Parse(timemas[0]), 
                int.Parse(timemas[1]),
                int.Parse(timemas[2]));
            Console.WriteLine("2- Vaqtni kirting: (hh:mm:ss)");
            string[] timemas2 = Console.ReadLine().Split(':');
            TimeA time2 = new TimeA(int.Parse(timemas2[0]),
                int.Parse(timemas2[1]),
                int.Parse(timemas2[2]));
            TimeA res = new TimeA();
            res = time1 + time2;
            Console.WriteLine("Vaqtlar qo'shish");
            Console.WriteLine(res.fResult());
            TimeA res2= new TimeA();
            res2 = time1 - time2;
            Console.WriteLine("Vaqtlar ayrish");
            Console.WriteLine(res2.fResult());
           
            Console.ReadKey();
        }
    }
}
