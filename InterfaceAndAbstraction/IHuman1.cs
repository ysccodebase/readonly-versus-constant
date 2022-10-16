using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndAbstraction
{
    interface IHuman1 : IHuman
    {
        void IHuman.Talk()
        {

        }

        void IHuman.Walk()
        {

        }

        void IHuman.EAT()
        {
            Console.WriteLine("Can walk also");
        }
    }
}
