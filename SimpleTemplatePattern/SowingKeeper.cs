using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTemplatePattern
{
    public class SowingKeeper : Greenkeeping
    {
        public override void Rollinggrassorsow()
        {
            Console.WriteLine("Sowing the fucking field");
        }
    }
}
