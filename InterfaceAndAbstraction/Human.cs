using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndAbstraction
{
    public  class Human : IHuman
    {
        public int Legs { get { return 2; } set { } }
        public int Heart { get { return 2; } set { } }

        public void Talk()
        {
            throw new NotImplementedException();
        }
    }
}
