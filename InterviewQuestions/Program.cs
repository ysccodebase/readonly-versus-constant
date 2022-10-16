using System;
using System.Xml.Serialization;

using System.Linq;
using System.Collections.Generic;

namespace InterviewQuestions
{
    class Program
    {
        /*
        A constant variable is a type of variable which if assigned a certain value at compile time,
       then it would not be possible to reassign some other value.*/
        private  const int onemeter =100;  // compile time constant


        /*
        A readonly variable is a type of variable which if assigned a certain value at runtime ,
       then it would not be possible to reassign some other value.*/
        private static  readonly int setting;  // runtime constant
        
         static  Program()
        {
            /*
            int j = 0;   
            //int k = null;
            int? p= null;
            Console.WriteLine("Enter the read only value for this application");
           // int i = Convert.ToInt32( Console.ReadLine()) ;
            //setting = i;
            setting = j;
            int myvale =(int) RatingStaus.Large;
            Console.WriteLine("hello there"+p);
         
            Console.WriteLine("hello there" +j);
            Console.WriteLine("Enum value : "+ myvale);
            */

        }
        static void Main(string[] args)
        {
            //MyClass obj1 = new MyClass("Test1 ","Test2 ");

            MyClass obj1 = new MyClass();
            /*
            Method1();

            string v1 = "SMALL";
            if(v1==RatingStaus.Small.ToString().ToUpper())
            {
                Console.WriteLine("Correct");
            }
            */
        }

        public static void Method1()
        {
            
           // Console.WriteLine("This is the value of readonly variable. "+ setting);
          //  Console.WriteLine("This is the value of Constant varaible. " + onemeter);
        }
    }

    public class MyClass
    {
        string Myendpoint;

        static MyClass()
        {
           // new MyClass();
            Console.WriteLine("This will be called always!!");
        }
        public MyClass()
        {
            Console.WriteLine("Hello dear friends!!");
            new MyClass(Myendpoint);
        }

        public MyClass(string P1)
        {
            Console.WriteLine("This is single parameter  " + P1 );
        }

        public MyClass(string P1, String P2) : this(P1)
        {
            Console.WriteLine("This is two parameter construction  " + P1 + ""+ P2);
        }
    }

   

    public enum RatingStaus
    {
        Small,
        Large
    }
}
