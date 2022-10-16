using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadonlyAndConstant
{
    public class Human
    {
        //universal truth as complie time constant 
        public const int noofeyes = 2;
        public const int noofhands = 2;
        public const int nooflegs = 2;

        //readonly fields runtime time constant 
        public readonly string placeofbirth;
        public readonly string name;
        public readonly string gender;
        
        public Human(string p_placeofbirth,string p_name, string p_gender)
        {
            placeofbirth = p_placeofbirth;
            name = p_name;
            gender=p_gender;
            
        }


        public void HumanInfo()
        {   
            Console.WriteLine("What is your name {0} ",name);
            Console.WriteLine("What is your gender {0} ", gender);
            Console.WriteLine("What is your placeofbirth {0} ", placeofbirth);
        }
    }
}
