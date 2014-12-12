using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTemplatePattern
{
    public class RollingGrassKeeper : Greenkeeping
    {
        public override void Rollinggrassorsow()
        {
            Console.WriteLine("Putting on rolling grass");
        }
    }
}
