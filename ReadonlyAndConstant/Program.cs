using System;

namespace ReadonlyAndConstant
{
    /*
     Watch this youtube video to understand this code.
    Video link : https://youtu.be/a3NCl2fieog
     */

    class Program
    {
        static void Main(string[] args)
        {

            Human human1 = new Human("Delhi", "Ram", "Male");
            human1.HumanInfo();

            Human human2 = new Human("Noida", "Shyam", "Male");
            human2.HumanInfo();
        }
    }
}
