using System;

namespace InterfaceAndAbstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the example of diffrence between interface and abstraction.");

            IHuman human = new Human();
            human.Walk();
        }
    }                               
}