using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTemplatePattern
{
    public abstract class Greenkeeping
    {
        public void ReadyTheEarth()
        {
            Console.WriteLine("Making the earth ready");
        }

        public abstract void Rollinggrassorsow();

        public void Fertilise()
        {
            Console.WriteLine("Fertilising the whooole earth... wooow");
        }

        public void GreenKeeping()
        {
            ReadyTheEarth();
            Rollinggrassorsow();
            Fertilise();

        }




    }
}
