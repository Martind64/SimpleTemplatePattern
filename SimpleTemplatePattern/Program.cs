using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTemplatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Greenkeeping keeping = new RollingGrassKeeper();
            keeping.GreenKeeping();

            Console.WriteLine();

            Greenkeeping sowing = new SowingKeeper();
            sowing.GreenKeeping();
            
            

        }
    }
}
