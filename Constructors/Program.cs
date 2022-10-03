using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        //static void Main(string[] args)     // For Date Constructor ....
        //{
        //    Date d1=new Date();   // non-parametric constructor ..
        //    Console.WriteLine(d1.GetValues());

        //    Date d2=new Date(3,2022,"Oct"); // parametric constructor ..
        //    Console.WriteLine(d2.GetValues());
        //}


        //static void Main(string[] args) // For Student Constructor...
        //{
        //    Student s1=new Student();
        //    Console.WriteLine(s1.GetValues());

        //    Student s2=new Student(1,9511798053,"Nitin");
        //    Console.WriteLine(s2.GetValues());

        //}

        static void Main()
        { 
           Employee e1=new Employee(101,25,"Sachin","Nashik");
            Console.WriteLine(e1.GetValues());


            Employee e2 = new Employee(102,26,"Nitin","Malegaon");
            Console.WriteLine(e2.GetValues());
        }
    }

    
}
