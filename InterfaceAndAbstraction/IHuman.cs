using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndAbstraction
{
    interface IHuman
    {
        public sealed int Eyes { get { return 2; } set {  } }
        private int hands {  get { return 2; } set { } }
        public int Legs { get; set; }
        public int Heart { get; set; }

        public virtual void Walk()
        {
            Console.WriteLine("Can walk also");
        }

        public  void EAT()
        {
            Console.WriteLine("Can walk also");
        }

        abstract void Talk();
    }
}
